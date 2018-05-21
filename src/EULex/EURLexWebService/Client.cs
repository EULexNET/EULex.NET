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
using System.Threading;
using System.Threading.Tasks;

using EULex.SimpleSOAPClient;
using EULex.SimpleSOAPClient.Helpers;
using EULex.SimpleSOAPClient.Models;
using EULex.SimpleSOAPClient.Models.Headers;

namespace EULex.EURLexWebService
{
    /// <summary>
    /// Client implementation for the EUR-Lex SOAP web service.
    /// </summary>
    public class Client : IDisposable
    {
        const string default_server_url = "https://eur-lex.europa.eu/EURLexWebService";
        const string default_user_agent = "EULex.NET";

        SoapClient soap_client;
        string server_url;
        string username;
        string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="EULex.EURLexWebService.Client"/> class with the default
        /// server URL, and a username and password.
        /// </summary>
        /// <param name="username">Username for the web service. This is an ECAS unique identifier (uid).</param>
        /// <param name="password">Password for the web service. This is provided by e-mail after registering
        /// as a web service user.</param>
        public Client (string username, string password) : this (default_server_url, username, password)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EULex.EURLexWebService.Client"/> class with a specific
        /// server URL, username and password.
        /// </summary>
        /// <param name="server_url">Server URL.</param>
        /// <param name="username">Username for the web service. This is an ECAS unique identifier (uid).</param>
        /// <param name="password">Password for the web service. This is provided by e-mail after registering
        /// as a web service user.</param>
        public Client (string server_url, string username, string password)
        {
            soap_client = new SoapClient ();
            soap_client.HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd (default_user_agent);

            this.server_url = server_url;
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// Releases all resource used by the <see cref="EULex.EURLexWebService.Client"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose()"/> when you are finished using the <see cref="EULex.EURLexWebService.Client"/>. The
        /// <see cref="Dispose()"/> method leaves the <see cref="EULex.EURLexWebService.Client"/> in an unusable state.
        /// After calling <see cref="Dispose()"/>, you must release all references to the
        /// <see cref="EULex.EURLexWebService.Client"/> so the garbage collector can reclaim the memory that the
        /// <see cref="EULex.EURLexWebService.Client"/> was occupying.</remarks>
        public void Dispose ()
        {
            Dispose (true);
            GC.SuppressFinalize (this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="EULex.EURLexWebService.Client"/> and optionally
        /// disposes of the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to releases only
        /// unmanaged resources.</param>
        protected virtual void Dispose (bool disposing)
        {
            if (disposing) {
                soap_client.Dispose ();
            }
        }

        /// <summary>
        /// Gets or sets the value of the User-Agent HTTP header that will be sent with each request.
        /// The default value is "EULex.NET".
        /// </summary>
        public string UserAgent {
            get {
                return soap_client.HttpClient.DefaultRequestHeaders.UserAgent.ToString();
            }
            set {
                soap_client.HttpClient.DefaultRequestHeaders.UserAgent.Clear();
                soap_client.HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(value);
            }
        }

        /// <summary>
        /// Handler that can access and manipulate the generated XML string before sending it to the server.
        /// </summary>
        public Func<string, string, string> RawRequestHandler {
            get => soap_client.RequestRawHandler;
            set => soap_client.RequestRawHandler = value;
        }

        /// <summary>
        /// Handler that can access and manipulate the returned XML string before deserialization.
        /// </summary>
        public Func<string, string, string> RawResponseHandler {
            get => soap_client.ResponseRawHandler;
            set => soap_client.ResponseRawHandler = value;
        }


		/// <summary>
		/// Sends a search request as an asynchronous operation.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		/// <param name="search_request">The search request sent to the web service.</param>
        /// <exception cref="FaultException">Thrown if the server returned a fault.</exception>
		public async Task<SearchResults> DoQueryAsync (SearchRequest search_request)
        {
            var header = KnownHeader.Oasis.Security.UsernameTokenAndPasswordText (username, password);
            var requestEnvelope = SoapEnvelope.Prepare().WithHeaders(header).Body(search_request);

            var responseEnvelope = await soap_client.SendAsync (server_url, requestEnvelope).ConfigureAwait (false);

            return responseEnvelope.Body<SearchResults>();
        }
    }
}

