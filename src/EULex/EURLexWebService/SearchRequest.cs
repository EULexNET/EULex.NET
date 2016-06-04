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
using System.Xml.Serialization;

using EULex.Model;

namespace EULex.EURLexWebService
{
    /// <summary>
    /// Represents all the parameters of a search request.
    /// </summary>
    [XmlRoot ("searchRequest", Namespace="http://eur-lex.europa.eu/search")]
    public partial class SearchRequest
    {
        /// <summary>
        /// Gets or sets the expert query.
        /// </summary>
        /// <value>The expert query.</value>
        [XmlElement ("expertQuery")]
        public string ExpertQuery { get; set; }

        /// <summary>
        /// Gets or sets the page number of the results to be returned.
        /// </summary>
        /// <value>The page number.</value>
        [XmlElement ("page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the size of the page of results to be returned.
        /// </summary>
        /// <value>The maximum number of results to be returned in one page.</value>
        [XmlElement ("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the language in which the search should be run.
        /// </summary>
        /// <value>The language in which to run the search.</value>
        [XmlElement ("searchLanguage")]
        public Language SearchLanguage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to limit the results to the latest consolidation.
        /// </summary>
        /// <value>True to limit to the latest consolidation. The default value is false.</value>
        /// <remarks>The restriction to the latest consolidation only applies for the results which are consolidated
        /// texts. Other types of results are not affected.</remarks>
        [XmlElement ("limitToLatestConsleg")]
        public string LimitToLatestConsolidation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to exclude all consolidation from the results.
        /// </summary>
        /// <value>True to exclude all consolidated texts from the results. The default value is false.</value>
        [XmlElement ("excludeAllConsleg")]
        public string ExcludeAllConsolidation { get; set; }
    }
}

