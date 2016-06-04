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
using System.Collections.ObjectModel;
using System.Xml.Serialization;

using EULex.Model;

namespace EULex.EURLexWebService
{
    /// <summary>
    /// Represents a warning returned by the web service.
    /// </summary>
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class Warning
    {
        /// <summary>
        /// Gets or sets the message in the warning.
        /// </summary>
        /// <value>The message.</value>
        [XmlElement ("message")]
        public string Message { get; set; }
    }

    /// <summary>
    /// Represents the search results returned by a web service call.
    /// </summary>
    [XmlRoot ("searchResults", Namespace="http://eur-lex.europa.eu/search")]
    public partial class SearchResults
    {
        /// <summary>
        /// Gets or sets the number of hits returned as results in the current page.
        /// </summary>
        /// <value>The number results returned.</value>
        [XmlElement ("numhits", DataType="int")]
        public int NumHits { get; set; }

        /// <summary>
        /// Gets or sets the total number of hits in the results.
        /// </summary>
        /// <value>The total number of results.</value>
        [XmlElement ("totalhits", DataType="int")]
        public int TotalHits { get; set; }

        /// <summary>
        /// Gets or sets the page number for the results returned.
        /// </summary>
        /// <value>The page number for the results returned.</value>
        [XmlElement ("page", DataType="int")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the language of the results.
        /// </summary>
        /// <value>The language of the results.</value>
        [XmlElement ("language")]
        public Language Language { get; set; }

        /// <summary>
        /// Gets or sets the list of results.
        /// </summary>
        /// <value>The list of results.</value>
        [XmlElement ("result")]
        public Collection<Result> Results { get; set; }

        /// <summary>
        /// Gets or sets the list of warnings.
        /// </summary>
        /// <value>The list of warnings.</value>
        [XmlElement ("warning")]
        public Collection<Warning> Warnings { get; set; }
    }
}

