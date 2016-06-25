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
    public class ResultsListTests : AssertionHelper
    {
        Client client;
        SearchRequest search_request;
        int page_size = 20;

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

            Expect (result_count, GreaterThan (page_size));
            Expect (response.Page, EqualTo (1));
            Expect (response.Language, EqualTo (Language.en));
            Expect (response.NumHits, EqualTo (page_size));
            Expect (response.Results.Count, EqualTo (page_size));

            Expect (response.Results [page_size - 1].Content.Notice.Work, Not.Null);
        }

        [Test]
        public async Task CheckSecondAndLastPages ()
        {
            search_request.Page = 2;
            var response = await client.DoQueryAsync (search_request);

            var result_count = response.TotalHits;

            Expect (response.Page, EqualTo (2));

            int last_page = (result_count / page_size) + 1;
            int last_count = result_count % page_size;

            search_request.Page = last_page;
            response = await client.DoQueryAsync (search_request);

            Expect (response.Page, EqualTo (last_page));
            Expect (response.NumHits, EqualTo (last_count));
            Expect (response.Results.Count, EqualTo (last_count));

            Expect (response.Results [last_count - 1].Content.Notice.Work, Not.Null);
        }

    }
}

