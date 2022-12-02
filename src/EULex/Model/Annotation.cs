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
    public partial class Annotation
    {
        [XmlElement ("ARTICLE")]
        public Collection<Literal> Article { get; set; }

        [XmlElement ("BUILD_INFO")]
        public string BuildInfo { get; set; }

        [XmlElement ("REFERENCE_TO_MODIFIED_LOCATION")]
        public Collection<string> ReferenceToModifiedLocation { get; set; }

        [XmlElement ("START_OF_VALIDITY")]
        public Collection<string> StartOfValidity { get; set; }

        [XmlElement ("TYPE_OF_LINK_TARGET")]
        public Collection<string> TypeOfLinkTarget { get; set; }

        [XmlElement ("COMMENT")]
        public Collection<string> Comment { get; set; }

        [XmlElement ("COMMENT_ON_DATE")]
        public Collection<string> CommentOnDate { get; set; }

        [XmlElement ("COMMENT_ON_LEGAL_BASIS")]
        public Collection<string> CommentOnLegalBasis { get; set; }

        [XmlElement ("ERROR_MESSAGE")]
        public Collection<string> ErrorMessage { get; set; }

        [XmlElement ("PARAGRAPH")]
        public Collection<string> Paragraph { get; set; }

        [XmlElement ("QUALITY_ISSUE")]
        public Collection<string> QualityIssue { get; set; }

        [XmlElement ("SUBPARAGRAPH")]
        public Collection<string> Subparagraph { get; set; }

        [XmlElement ("TYPE_OF_DATE")]
        public Collection<string> DateType { get; set; }

        [XmlElement ("SENTENCE")]
        public Collection<string> Sentence { get; set; }

        [XmlElement ("OLD_VALUE")]
        public Collection<string> OldValue { get; set; }

        [XmlElement ("FRAGMENT_CITED_TARGET")]
        public Collection<string> FragmentCitedTarget { get; set; }

        [XmlElement ("FRAGMENT_CITING_SOURCE")]
        public Collection<string> FragmentCitingSource { get; set; }

        [XmlElement ("ROLE2")]
        public Collection<string> Role2 { get; set; }

        [XmlElement ("LANGUAGE_LIST")]
        public Collection<string> LanguageList { get; set; }

        [XmlElement ("INDENT")]
        public Collection<string> Indent { get; set; }

        [XmlElement ("END_OF_VALIDITY")]
        public Collection<string> EndOfValidity { get; set; }

        [XmlElement ("ALINEA")]
        public Collection<string> Alinea { get; set; }

        [XmlElement ("FAMILLE")]
        public Collection<string> Famille { get; set; }

        [XmlElement ("TRANSPOSITION_DEADLINE_TRANSMITTED")]
        public Collection<string> TranspositionDeadlineTransmitted { get; set; }

        [XmlElement ("TRANSPOSITION_NOTIFICATION")]
        public Collection<string> TranspositionNotification { get; set; }

        [XmlElement ("ELI_TARGET")]
        public Collection<string> EliTarget { get; set; }

        [XmlElement ("ANNEX")]
        public Collection<string> Annex { get; set; }

        [XmlElement ("CHAPTER")]
        public Collection<string> Chapter { get; set; }

        [XmlElement ("COUNTRY")]
        public Collection<string> Country { get; set; }

        [XmlElement ("ELI_SOURCE")]
        public Collection<string> EliSource { get; set; }

        [XmlElement ("PROTOCOL")]
        public Collection<string> Protocol { get; set; }

        [XmlElement ("REFERENCE_TO_MODIFYING_LOCATION")]
        public Collection<string> ReferenceToModifyingLocation { get; set; }

        [XmlElement ("ORDER")]
        public Collection<string> Order { get; set; }

        [XmlElement ("CHANGED_TO_IDENTIFIER")]
        public Collection<string> ChangedToIdentifier { get; set; }

    }
}

