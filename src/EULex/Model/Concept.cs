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

namespace EULex.Model
{
    [XmlType (AnonymousType=true, Namespace="http://eur-lex.europa.eu/search")]
    public partial class ConceptFallback
    {
        private object pREFLABELField;

        private object lANGField;

        public object PREFLABEL {
            get {
                return this.pREFLABELField;
            }
            set {
                this.pREFLABELField = value;
            }
        }

        public object LANG {
            get {
                return this.lANGField;
            }
            set {
                this.lANGField = value;
            }
        }
    }

    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class Concept
    {
        [XmlElement ("ALTLABEL")]
        public Collection<string> AltLabels { get; set; }

        [XmlElement ("ANNOTATION")]
        public Collection<Annotation> Annotations { get; set; }

        [XmlElement ("COMPACT_URI")]
        public string CompactUri { get; set; }

        [XmlElement ("FALLBACK")]
        public Collection<ConceptFallback> Fallbacks { get; set; }

        [XmlElement ("IDENTIFIER")]
        public string Identifier { get; set; }

        [XmlElement ("OP-CODE")]
        public string OpCode { get; set; }

        [XmlElement ("PREFLABEL")]
        public string PrefLabel { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }
    }
}

