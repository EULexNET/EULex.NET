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
    public partial class Manifestation
    {
        [XmlElement ("MANIFESTATION_CASE-LAW_COSTS_DECISIONS")]
        public Literal CaseLawCostsDecision { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_ENDORSEMENTS")]
        public Literal CaseLawEndorsements { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_GROUNDS")]
        public Literal CaseLawGrounds { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_KEYWORDS")]
        public Literal CaseLawKeywords { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_OPERATIVE_PART")]
        public Literal CaseLawOperativePart { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_OPINION_ADVOCATE-GENERAL")]
        public Collection<Literal> CaseLawAdvocateGeneralOpinion { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_PARTIES")]
        public Literal CaseLawParties { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_STAFF_CASE_SUMMARY")]
        public Collection<Literal> CaseLawSummaryStaffCase { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_SUBJECT")]
        public Literal CaseLawSubject { get; set; }

        [XmlElement ("MANIFESTATION_CASE-LAW_SUMMARY")]
        public Collection<Literal> CaseLawSummary { get; set; }

        [XmlElement ("MANIFESTATION_COURT-REPORT_PART_PAGE_FIRST")]
        public Literal CourtReportPartFirstPage { get; set; }

        [XmlElement ("MANIFESTATION_COURT-REPORT_PART_TYPE")]
        public Literal CourtReportPartType { get; set; }

        [XmlElement ("MANIFESTATION_COURT-REPORT_PART_YEAR")]
        public Literal CourtReportPartYear { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_AUTHOR_PRINTER")]
        public Collection<Literal> OfficialJournalPartPrinterAuthors { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_PAGE_FIRST")]
        public Literal OfficialJournalPartFirstPage { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_PAGE_LAST")]
        public Literal OfficialJournalPartLastPage { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_SECTION_OJ")]
        public Literal OfficialJournalPartSection { get; set; }

        [XmlElement ("MANIFESTATION_OFFICIAL-JOURNAL_PART_TYPEDOC_PRINTER")]
        public Literal OfficialJournalPartPrinterDocumentType { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-COURT-REPORT_PART_PAGE_FIRST")]
        public Literal SpecialCourtReportPartFirstPage { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-COURT-REPORT_PART_TYPE")]
        public Literal SpecialCourtReportPartType { get; set; }

        [XmlElement ("MANIFESTATION_SPECIAL-COURT-REPORT_PART_YEAR")]
        public Literal SpecialCourtReportPartYear { get; set; }

        [XmlElement ("MANIFESTATION_TYPE")]
        public Literal ManifestationType { get; set; }

        [XmlElement ("MANIFESTATION_URI")]
        public Collection<Literal> ExternalUris { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("TYPE")]
        public Relation Type { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }
    }
}

