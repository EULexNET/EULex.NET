//
// Copyright (c) 2016 Bertrand Lorentz
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Threading.Tasks;
using NUnit.Framework;

using EULex.EURLexWebService;
using EULex.Model;

namespace EULex.IntegrationTests
{
    [TestFixture]
    public class ResultsListTests
    {
        Client client;
        SearchRequest search_request;
        readonly int page_size = 20;

        [OneTimeSetUp]
        protected void SetUp ()
        {
            client = TestUtils.GetClient ();

            search_request = new SearchRequest {
                ExpertQuery = "TI ~ privacy",
                SearchLanguage = Language.en,
                PageSize = page_size,
                Page = 1
            };
        }

        [Test]
        public async Task CheckFirstPage ()
        {
            var response = await client.DoQueryAsync (search_request);

            var result_count = response.TotalHits;

            Assert.That (result_count, Is.GreaterThan (page_size));
            Assert.That (response.Page, Is.EqualTo (1));
            Assert.That (response.Language, Is.EqualTo (Language.en));
            Assert.That (response.NumHits, Is.EqualTo (page_size));
            Assert.That (response.Results.Count, Is.EqualTo (page_size));

            for (int i = 0; i < page_size; i++) {
                Assert.That (response.Results [i].Rank, Is.EqualTo (i + 1));
            }

            Assert.That (response.Results [page_size - 1].Content.Notice, Is.Not.Null);
        }

        [Test]
        public async Task CheckSecondAndLastPages ()
        {
            search_request.Page = 2;
            var response = await client.DoQueryAsync (search_request);

            var result_count = response.TotalHits;

            Assert.That (response.Page, Is.EqualTo (2));

            int last_page = result_count / page_size;
            int last_count = result_count % page_size;
            if (last_count == 0) {
                last_count = page_size;
            } else {
                last_page++;
            }

            search_request.Page = last_page;
            response = await client.DoQueryAsync (search_request);

            Assert.That (response.Page, Is.EqualTo (last_page));
            Assert.That (response.NumHits, Is.EqualTo (last_count));
            Assert.That (response.Results.Count, Is.EqualTo (last_count));

            Assert.That (response.Results [last_count - 1].Content.Notice, Is.Not.Null);
        }

        [Test]
        public async Task CheckResultItem ()
        {
            var response = await client.DoQueryAsync (search_request);

            var item = response.Results[0];

            Assert.That (item.Reference, Does.StartWith ("eng_cellar:"));
            Assert.That (item.Rank, Is.EqualTo(1));
            Assert.That (item.DocumentLinks[0].Type, Is.AnyOf("doc", "html", "pdf"));
            Assert.That (item.DocumentLinks[0].Value, Does.StartWith("https://eur-lex.europa.eu"));

            Assert.That (item.Content, Is.Not.Null);
            Assert.That (item.Content.SubDomains, Does.Contain("ALL_ALL"));
            Assert.That (item.Content.Notice, Is.Not.Null);
        }
    }
}

