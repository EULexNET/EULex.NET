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
using System.Configuration;

using EULex.EURLexWebService;
using EULex.Model;

namespace EULex.IntegrationTests
{
    public class TestUtils
    {
        public static Notice GetSingleNotice (string query, Language lang)
        {
            var username = ConfigurationManager.AppSettings ["username"];
            var password = ConfigurationManager.AppSettings ["password"];

            using (var client = new Client (username, password)) {

                var request = new SearchRequest ();
                request.ExpertQuery = query;
                request.PageSize = 1;
                request.Page = 1;
                request.SearchLanguage = lang;

                var task = client.DoQueryAsync (request);
                task.Wait ();
                var response = task.Result;

                return response.Results [0].Content.Notice;
            }
        }
    }
}

