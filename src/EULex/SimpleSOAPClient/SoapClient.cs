#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 João Simões
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace EULex.SimpleSOAPClient
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Helpers;
    using Models;

    /// <summary>
    /// The SOAP client that can be used to invoke SOAP Endpoints
    /// </summary>
    public class SoapClient : IDisposable
    {
        /// <summary>
        /// The used HTTP client
        /// </summary>
        public HttpClient HttpClient { get; }

        #region Constructors

        /// <summary>
        /// Creates a new SOAP Client
        /// </summary>
        public SoapClient () : this (new HttpClient ())
        { }

        /// <summary>
        /// Creates a new SOAP Client
        /// </summary>
        /// <param name="handler">The handler to be used by the <see cref="HttpClient"/></param>
        public SoapClient (HttpMessageHandler handler)
        {
            if (handler == null) throw new ArgumentNullException (nameof (handler));

            HttpClient = new HttpClient (handler);
        }

        /// <summary>
        /// Creates a new SOAP Client
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used</param>
        public SoapClient (HttpClient httpClient)
        {
            if (httpClient == null) throw new ArgumentNullException (nameof (httpClient));

            HttpClient = httpClient;
        }

        #endregion

        /// <summary>
        /// Handler that can manipulate the <see cref="SoapEnvelope"/>
        /// before serialization.
        /// </summary>
        public Func<string, SoapEnvelope, SoapEnvelope> RequestEnvelopeHandler { get; set; }

        /// <summary>
        /// Handler that can manipulate the generated XML string.
        /// </summary>
        public Func<string, string, string> RequestRawHandler { get; set; }

        /// <summary>
        /// Handler that can manipulate the <see cref="SoapEnvelope"/> returned
        /// by the SOAP Endpoint.
        /// </summary>
        public Func<string, SoapEnvelope, SoapEnvelope> ResponseEnvelopeHandler { get; set; }

        /// <summary>
        /// Handler that can manipulate the returned string before deserialization.
        /// </summary>
        public Func<string, string, string> ResponseRawHandler { get; set; }

        /// <summary>
        /// Sends the given <see cref="SoapEnvelope"/> into the specified url.
        /// </summary>
        /// <param name="url">The url that will receive the request</param>
        /// <param name="requestEnvelope">The <see cref="SoapEnvelope"/> to be sent</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>A task to be awaited for the result</returns>
        public virtual async Task<SoapEnvelope> SendAsync (
            string url, SoapEnvelope requestEnvelope, CancellationToken ct = default (CancellationToken))
        {
            if (RequestEnvelopeHandler != null) {
                requestEnvelope = RequestEnvelopeHandler (url, requestEnvelope);
            }

            var requestXml = requestEnvelope.ToXmlString ();
            if (RequestRawHandler != null) {
                requestXml = RequestRawHandler (url, requestXml);
            }

            var result =
                await HttpClient.PostAsync (
                    url, new StringContent (requestXml, Encoding.UTF8, "application/soap+xml"), ct).ConfigureAwait (false);

            var responseXml = await result.Content.ReadAsStringAsync ().ConfigureAwait (false);
            if (ResponseRawHandler != null) {
                responseXml = ResponseRawHandler (url, responseXml);
            }

            var responseEnvelope = responseXml.ToObject<SoapEnvelope> ();

            if (ResponseEnvelopeHandler != null) {
                responseEnvelope = ResponseEnvelopeHandler (url, responseEnvelope);
            }

            return responseEnvelope;
        }

        /// <summary>
        /// Sends the given <see cref="SoapEnvelope"/> into the specified url.
        /// </summary>
        /// <param name="url">The url that will receive the request</param>
        /// <param name="requestEnvelope">The <see cref="SoapEnvelope"/> to be sent</param>
        /// <returns>The resulting <see cref="SoapEnvelope"/></returns>
        public virtual SoapEnvelope Send (string url, SoapEnvelope requestEnvelope)
        {
            return SendAsync (url, requestEnvelope).Result;
        }

        #region Implementation of IDisposable

        public void Dispose ()
        {
            Dispose (true);
            GC.SuppressFinalize (this);
        }

        protected virtual void Dispose (bool disposing)
        {
            if (disposing) {
                HttpClient?.Dispose ();
            }
        }

        #endregion
    }
}
