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
    [XmlType (Namespace="http://eur-lex.europa.eu/search", IncludeInSchema=false)]
    public enum DirectoryCodeType
    {
        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_1")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_1,

        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_2")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_2,

        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_3")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_3,

        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_4")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_4,

        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_5")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_5,

        [XmlEnum ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_6")]
        RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORYCODE_6,
    }

    [XmlType (AnonymousType=true, Namespace="http://eur-lex.europa.eu/search")]
    public partial class DirectoryCode
    {
        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_1", typeof(Concept))]
        public Concept Level1 { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_2", typeof(Concept))]
        public Concept Level2 { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_3", typeof(Concept))]
        public Concept Level3 { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_4", typeof(Concept))]
        public Concept Level4 { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_5", typeof(Concept))]
        public Concept Level5 { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE_6", typeof(Concept))]
        public Concept Level6 { get; set; }
    }
}

