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
    public partial class Dossier
    {
        [XmlElement ("BASED_ON")]
        public Collection<Concept> BasedOn { get; set; }

        [XmlElement ("BASIS_LEGAL")]
        public Collection<Literal> LegalBasis { get; set; }

        [XmlElement ("DOSSIER_ADOPTED-PROPOSAL")]
        public Literal IsAdopted { get; set; }

        [XmlElement ("DOSSIER_IDENTIFIER")]
        public Literal Identifier { get; set; }

        [XmlElement ("DOSSIER_INITIATED_BY_ACT_PREPARATORY")]
        public Collection<Relation> InitiatedByPreparatoryAct { get; set; }

        [XmlElement ("DOSSIER_IS_ABOUT_CONCEPT_TYPE_DOSSIER")]
        public Collection<Concept> DossierType { get; set; }

        [XmlElement ("DOSSIER_NUMBER_REFERENCE")]
        public Literal ReferenceNumber { get; set; }

        [XmlElement ("DOSSIER_PENDING-PROPOSAL")]
        public Literal IsPending { get; set; }

        [XmlElement ("DOSSIER_PRODUCES_RESOURCE_LEGAL")]
        public Collection<Concept> ProducesWorks { get; set; }

        [XmlElement ("DOSSIER_TYPE_REFERENCE")]
        public Literal ReferenceType { get; set; }

        [XmlElement ("DOSSIER_WITHDRAWN-PROPOSAL")]
        public Literal IsWithdrawn { get; set; }

        [XmlElement ("DOSSIER_YEAR_REFERENCE")]
        public Literal ReferenceYear { get; set; }

        [XmlElement ("NUMBER_PROCEDURE")]
        public Literal ProcedureNumber { get; set; }

        [XmlElement ("PROCEDURE_CODE_INTERINSTITUTIONAL_BASED_ON_RESOURCE_LEGAL")]
        public Collection<Relation> ProcedureBasedOn { get; set; }

        [XmlElement ("PROCEDURE_CODE_INTERINSTITUTIONAL_HAS_TYPE_CONCEPT_TYPE_PROCEDURE_CODE_INTERINSTITUTIONAL")]
        public Concept ProcedureType { get; set; }

        [XmlElement ("PROCEDURE_CODE_INTERINSTITUTIONAL_REFERENCE_PROCEDURE")]
        public Literal ProcedureReference { get; set; }

        [XmlElement ("PROCEDURE_CODE_INTERINSTITUTIONAL_YEAR_PROCEDURE")]
        public Literal ProcedureYear { get; set; }

        [XmlElement ("PROCEDURE_WITHOUT_CODE_INTERINSTITUTIONAL_BASED_ON_RESOURCE_LEGAL")]
        public Collection<Relation> OtherProcedureBasedOn { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }
    }
}

