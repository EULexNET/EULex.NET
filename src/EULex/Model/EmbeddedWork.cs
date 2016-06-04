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
    public partial class EmbeddedWork
    {
        [XmlElement ("CONTAINER_CASE-LAW_COURT")]
        public Literal CaseLawContainerCourt { get; set; }

        [XmlElement ("CONTAINER_CASE-LAW_FASCICULE")]
        public Literal CaseLawContainerFascicule { get; set; }

        [XmlElement ("CONTAINER_CASE-LAW_ID_NUMPUB")]
        public Literal CaseLawContainerNumPub { get; set; }

        [XmlElement ("CONTAINER_CASE-LAW_NUMBER")]
        public Literal CaseLawContainerNumber { get; set; }

        [XmlElement ("CONTAINER_CASE-LAW_YEAR_DECISION")]
        public Literal CaseLawContainerYear { get; set; }

        [XmlElement ("COURT-REPORT_NUMBER")]
        public Literal CourtReportNumber { get; set; }

        [XmlElement ("DATE_PUBLICATION")]
        public Collection<Date> DatePublication { get; set; }

        [XmlElement ("ID_SECTOR")]
        public Collection<Literal> Sector { get; set; }

        [XmlElement ("LEGAL_EFFECT_PAPER")]
        public Literal LegalEffectPaper { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_CLASS")]
        public Collection<Literal> OfficialJournalClass { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_NUMBER")]
        public Collection<Literal> OfficialJournalNumber { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_PART_OF_COLLECTION_DOCUMENT")]
        public Collection<Concept> OfficialJournalCollection { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_YEAR")]
        public Collection<Literal> OfficialJournalYear { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE")]
        public Collection<DirectoryCode> DirectoryCodes { get; set; }

        [XmlElement ("RESOURCE_LEGAL_NUMBER_NATURAL_CELEX")]
        public Collection<Literal> NaturalNumberCelex { get; set; }

        [XmlElement ("RESOURCE_LEGAL_TYPE")]
        public Collection<Literal> DocumentType { get; set; }

        [XmlElement ("RESOURCE_LEGAL_YEAR")]
        public Collection<Literal> DocumentYear { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_FIRST_SERIES_HISTORICAL")]
        public Literal SpecialOfficialJournalFirstHistoricalSeries { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE")]
        public Collection<Concept> SpecialOfficialJournalDirectoryCode { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_SECOND_SERIES_HISTORICAL")]
        public Literal SpecialOfficialJournalSecondHistoricalSeries { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_VOLUME")]
        public Collection<Literal> SpecialOfficialJournalVolume { get; set; }

        [XmlElement ("WORK_DATE_DOCUMENT")]
        public Collection<Date> DateDocument { get; set; }

        [XmlElement ("WORK_IS_ABOUT_CONCEPT_EUROVOC")]
        public Collection<Eurovoc> Eurovoc { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("TYPE")]
        public Collection<Relation> Type { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }
    }
}

