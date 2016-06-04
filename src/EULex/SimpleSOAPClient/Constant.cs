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
    /// <summary>
    /// Class with some constant values
    /// </summary>
    public static class Constant
    {
        /// <summary>
        /// Namespace constants
        /// </summary>
        public static class Namespace
        {
            /// <summary>
            /// The SOAP 1.2 Envelope namespace
            /// </summary>
            public const string SoapSchemasSoapEnvelope =
                "http://www.w3.org/2003/05/soap-envelope";

            /// <summary>
            /// The Oasis Security namespace
            /// </summary>
            public const string Oasis200401WssWssecuritySecext10 =
                "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

            /// <summary>
            /// The Oasis Security Utilities namespace
            /// </summary>
            public const string Oasis200401WssWssecurityUtility10 =
                "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";

            /// <summary>
            /// The URL for the password type in the username token
            /// </summary>
            public const string Oasis200401WssUsernameTokenProfile10PasswordText =
                "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText";
        }
    }
}