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
    [XmlType (AnonymousType=true, Namespace="http://eur-lex.europa.eu/search")]
    public partial class DocumentLink
    {
        public DocumentLink ()
        {
            this.Type = "required";
        }

        [XmlAttribute ("type")]
        [System.ComponentModel.DefaultValue ("required")]
        public string Type { get; set; }

        [XmlText ()]
        public string Value { get; set; }
    }

    /// <summary>
    /// Represents a result item returned by the web service.
    /// </summary>
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class Result
    {
        /// <summary>
        /// Gets or sets the reference of the result, which is a unique identifier of the entity represented in
        /// the result.
        /// </summary>
        /// <value>The reference of the result.</value>
        [XmlElement ("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the rank of the result in the result list.
        /// </summary>
        /// <value>The rank of the result.</value>
        [XmlElement (DataType="int")]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets the document links.
        /// </summary>
        /// <value>The document links.</value>
        [XmlElement ("document-link")]
        public Collection<DocumentLink> DocumentLinks { get; set; }

        /// <summary>
        /// Gets or sets the content of the result.
        /// </summary>
        /// <value>The content of the result.</value>
        [XmlElement ("content")]
        public Document Content { get; set; }
    }
}

