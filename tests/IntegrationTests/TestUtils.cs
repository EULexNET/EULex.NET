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

using EULex.EURLexWebService;
using EULex.Model;

namespace EULex.IntegrationTests
{
    public class TestUtils
    {
        /// <summary>
        /// Return a web service client configured with username and password from environment variables
        /// EULEX_WEBSERVICE_USERNAME and EULEX_WEBSERVICE_PASSWORD.
        /// </summary>
        /// <returns>An instance of web service client. Disposing of the client is the responsibility of the caller.</returns>
        public static Client GetClient ()
        {
            var username = Environment.GetEnvironmentVariable ("EULEX_WEBSERVICE_USERNAME");
            var password = Environment.GetEnvironmentVariable ("EULEX_WEBSERVICE_PASSWORD");

            if (username == null || password == null) {
                throw new InvalidOperationException("Webservice credentials must be defined in environment variables EULEX_WEBSERVICE_USERNAME and EULEX_WEBSERVICE_PASSWORD.");
            }

            return new Client (username, password);
        }

        public static async Task<SearchResults> GetResults (string query, Language lang, int page_size, int page)
        {
            using (var client = GetClient ()) {

				var request = new SearchRequest
				{
					ExpertQuery = query,
					PageSize = page_size,
					Page = page,
					SearchLanguage = lang
				};

				var results = await client.DoQueryAsync (request);
                return results;
            }
        }

        public static async Task<Notice> GetSingleNotice (string query, Language lang)
        {
            var response = await GetResults (query, lang, 1, 1);

            return response.Results [0].Content.Notice;
        }
    }
}

