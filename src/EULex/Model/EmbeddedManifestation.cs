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
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public partial class EmbeddedManifestation
    {
        [XmlElement ("MANIFESTATION_HAS_ITEM")]
        public Collection<Item> Items { get; set; }

        [XmlElement ("MANIFESTATION_TYPE")]
        public Literal Type { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_PAGE_FIRST")]
        public Literal OfficialJournalPartFirstPage { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_PAGE_LAST")]
        public Literal OfficialJournalPartLastPage { get; set; }

        [XmlElement ("MANIFESTATION_PART_OF_MANIFESTATION")]
        public Collection<Relation> PartOfManifestations { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-OFFICIAL-JOURNAL_PART_PAGE_FIRST")]
        public Literal SpecialOfficialJournalPartFirstPage { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-OFFICIAL-JOURNAL_PART_PAGE_LAST")]
        public Literal SpecialOfficialJournalPartLastPage { get; set; }

        [XmlElement ("MANIFESTATION-SPECIAL-OFFICIAL-JOURNAL-ACT_IS_ABOUT_CONCEPT_DIRECTORY-CODE")]
        public Collection<DirectoryCode> SpecialOfficialJournalActDirectoryCodes { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-OFFICIAL-JOURNAL-ACT_DATE_PUBLICATION")]
        public Date SpecialOfficialJournalActPublicationDate { get; set; }

        [XmlElement ("MANIFESTATION_URI")]
        public Collection<Literal> ExternalUris { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }

        [XmlAttribute ("MANIFESTATION-TYPE")]
        public string ManifestationType { get; set; }
    }
}

