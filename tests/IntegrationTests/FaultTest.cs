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
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

using EULex.Model;
using EULex.EURLexWebService;
using EULex.SimpleSOAPClient;

namespace EULex.IntegrationTests
{
    [TestFixture]
    public class FaultTest
    {
        Client client;

        [OneTimeSetUp]
        protected void SetUp ()
        {
            client = TestUtils.GetClient ();
        }

        [Test]
        public void QuerySyntaxError ()
        {
            var search_request = new SearchRequest {
                ExpertQuery = "BAD_SYNTAX",
                SearchLanguage = Language.en,
                PageSize = 1,
                Page = 1
            };

            var ex = Assert.ThrowsAsync<FaultException> (async () => { await client.DoQueryAsync (search_request); });

            Assert.That (ex.Message, Does.StartWith ("Error at line"));
            Assert.That (ex.Code, Does.Contain ("WS_QUERY_SYNTAX_ERROR"));
        }
    }
}

