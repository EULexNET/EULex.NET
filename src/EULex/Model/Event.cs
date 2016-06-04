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
    public partial class Event
    {
        [XmlElement ("EVENT_LEGAL_ADDRESSES_INSTITUTION")]
        public Collection<Concept> AddressesInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_ASSOCIATED_WITH_INSTITUTION")]
        public Collection<Concept> AssociatedWithInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_CONSULTS_INSTITUTION")]
        public Collection<Concept> ConsultsInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_CONTAINS_WORK")]
        public Collection<Concept> ContainsWorks { get; set; }

        [XmlElement ("EVENT_LEGAL_DATE")]
        public Date Date { get; set; }

        [XmlElement ("EVENT_LEGAL_DOCUMENT_REFERENCE")]
        public Collection<Literal> DocumentReferences { get; set; }

        [XmlElement ("EVENT_LEGAL_DRAFTED_BY_PERSON")]
        public Collection<Concept> DraftedByPerson { get; set; }

        [XmlElement ("EVENT_LEGAL_FORMALLY-ADDRESSES_INSTITUTION")]
        public Collection<Concept> FormallyAddressesInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_GETS_OPINION_OF_INSTITUTION")]
        public Collection<Concept> GetsOpinionOfInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_GETS_REPORT_OF_INSTITUTION")]
        public Collection<Concept> GetsReportOfInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_HAS_REMARK_CONCEPT_TYPE_REMARK")]
        public Collection<Concept> Remarks { get; set; }

        [XmlElement ("EVENT_LEGAL_HAS_TYPE_CONCEPT_TYPE_EVENT_LEGAL")]
        public Concept EventType { get; set; }

        [XmlElement ("EVENT_LEGAL_INFORMS_INSTITUTION")]
        public Collection<Concept> InformsInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_INITIATED_BY_INSTITUTION")]
        public Collection<Concept> InitiatedByInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_JOINT-RESPONSIBILITY_OF_INSTITUTION")]
        public Collection<Concept> JointResponsibilityOfInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_JOINT-RESPONSIBILITY_OF_PERSON")]
        public Collection<Concept> JointResponsibilityOfPersons { get; set; }

        [XmlElement ("EVENT_LEGAL_MANDATORILY-CONSULTS_INSTITUTION")]
        public Collection<Concept> MandatorilyConsultsInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_ON_AGENDA_CONCEPT_AGENDA_COUNCIL")]
        public Concept OnCouncilAgenda { get; set; }

        [XmlElement ("EVENT_LEGAL_OPTIONALLY-CONSULTS_INSTITUTION")]
        public Collection<Concept> OptionallyConsultsInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_RESPONSIBILITY_OF_INSTITUTION")]
        public Collection<Concept> ResponsibilityOfInstitutions { get; set; }

        [XmlElement ("EVENT_LEGAL_RESPONSIBILITY_OF_PERSON")]
        public Collection<Concept> ResponsibilityOfPersons { get; set; }

        [XmlElement ("EVENT_LEGAL_USES_CONCEPT_MODE_DECISION")]
        public Concept DecisionMode { get; set; }

        [XmlElement ("EVENT_LEGAL_USES_CONCEPT_TYPE_DECISION")]
        public Concept DecisionType { get; set; }

        [XmlElement ("EVENT_LEGAL_WAS_HISTORICALLY_ABOUT_CONCEPT_TYPE_DOSSIER")]
        public Concept DossierType { get; set; }

        [XmlElement ("REPORTED_BY")]
        public Collection<Concept> ReportedBy { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }
    }
}

