//
// Copyright 2016 Bertrand Lorentz
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
using System.Threading;
using System.Threading.Tasks;

using EULex.EURLexWebService;
using EULex.Model;

namespace ConsoleSample
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            MainAsync ().Wait ();
        }

        static async Task MainAsync ()
        {
            var username = ConfigurationManager.AppSettings ["username"];
            var password = ConfigurationManager.AppSettings ["password"];

            using (var client = new Client (username, password)) {

                client.RawResponseHandler = (url, xml) => {
                    Console.WriteLine ("SOAP response from {0}:\n{1}", url, xml);
                    return xml;
                };

                var request = new SearchRequest {
                    ExpertQuery = "SELECT DN, AU, TI_DISPLAY, MANIFESTATION_ID WHERE TI ~ privacy",
                    SearchLanguage = Language.en,
                    PageSize = 10,
                    Page = 1
                };

                var response = await client.DoQueryAsync (request);
                var notice = response.Results [0].Content.Notice;
                var work = notice.Work;
                var exp = notice.Expression;

                var celex = work?.Celex [0].Value;
                var author = work?.CreatedByAgent [0].OpCode;
                var title = exp?.Title [0].Value;

                Console.WriteLine ("Results : " + response.TotalHits);
                Console.WriteLine ("CELEX : " + celex);
                Console.WriteLine ("Author : " + author);
                Console.WriteLine ("Title : " + title);
                foreach (DocumentLink link in response.Results[0].DocumentLinks) {
                    Console.WriteLine ("Link : " + link.Type + " " + link.Value);
                }
            }
        }
    }
}
