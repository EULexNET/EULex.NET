//
// Copyright 2022 Bertrand Lorentz
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

namespace EULex.Model
{
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class Item
    {
        [XmlElement ("BELONGS_TO")]
        public BelongsTo BelongsTo { get; set; }

        [XmlElement ("IDENTIFIER")]
        public Literal Identifier { get; set; }

        [XmlElement ("ITEM_BELONGS_TO_MANIFESTATION")]
        public BelongsTo ItemBelongsToManifestation { get; set; }

        [XmlElement ("ITEM_IDENTIFIER")]
        public Literal ItemIdentifier { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("TECHMD")]
        public string TechnicalMetadata { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }
    }

    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class BelongsTo
    {
        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }

        [XmlAttribute ("TYPE")]
        public string Type { get; set; }

    }
}