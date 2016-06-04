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
    public partial class Inverse
    {
        [XmlElement ("CASE-LAW_COMMUNICATED_ON_BY_COMMUNICATION_CJEU")]
        public Collection<Concept> CaseLawCommunicatedOnByCommunications { get; set; }

        [XmlElement ("CASE-LAW_DECISION_REVIEW_REQUESTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> CaseLawReviewRequestedByCommunications { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADDED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> AddedTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADOPTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AdoptedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDED_BY_CASE-LAW")]
        public Collection<Concept> AmendedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AmendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDMENT_PROPOSED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AmendmentProposedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ANNULMENT_REQUESTED_BY_CASE-LAW")]
        public Collection<Concept> AnnulmentRequestedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ANNULMENT_REQUESTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> AnnulmentRequestedByCommunications { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_DEFERRED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ApplicationDeferredBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_EXTENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ApplicationExtendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_SUSPENDED_BY_CASE-LAW")]
        public Collection<Concept> ApplicationSuspendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_BASIS_FOR_ACT_CONSOLIDATED")]
        public Collection<Concept> LegalBasisForConsolidatedAct { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COMPLETED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> CompletedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONFIRMED_BY_CASE-LAW")]
        public Collection<Concept> ConfirmedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONFIRMED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ConfirmedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONSOLIDATED_BY_ACT_CONSOLIDATED")]
        public Collection<Relation> ConsolidatedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CORRECTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> CorrectedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COR_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> CorOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VALID_BY_CASE-LAW")]
        public Collection<Concept> DeclaredValidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VOID_BY_CASE-LAW")]
        public Collection<Concept> DeclaredVoidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VOID_BY_PRELIMINARY_RULING_CASE-LAW")]
        public Collection<Concept> DeclaredVoidByPreliminaryRuling { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DEROGATED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> DerogatedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EESC_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> EescOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EP_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> EpOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ESTABLISHES_FAILURE_TO_FULFILL_OBLIGATION_REQUESTED_BY_CASE-LAW")]
        public Collection<Concept> FailureToFulfillObligationRequestedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ESTABLISHMENT_OF_FAILURE_OF_OBLIGATION_REQUESTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> FailureToFulfillObligationRequestedByCommunications { get; set; }

        [XmlElement ("RESOURCE_LEGAL_FAILURE_STATED_BY_CASE-LAW")]
        public Collection<Concept> FailureStatedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMMEDIATELY_ENFORCED_BY_CASE-LAW")]
        public Collection<Concept> ImmediatelyEnforcedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLEMENTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ImplementedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLICITLY_REPEALED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ImplicitlyRepealedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INAPPLICABILITY_REQUESTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> InapplicabilityRequestedByCommunication { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCIDENTALLY_DECLARED_VALID_CASE-LAW")]
        public Collection<Concept> IncidentallyDeclaredValidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCIDENTALLY_DECLARED_VOID_BY_CASE-LAW")]
        public Collection<Concept> IncidentallyDeclaredVoidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCORPORATED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> IncorporatedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETATION_REQUESTED_BY_CASE-LAW")]
        public Collection<Concept> InterpretationRequestedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETED_AUTHORITATIVELY_BY_RESOURCE_LEGAL")]
        public Collection<Concept> InterpretedAuthoritativelyBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETED_BY_CASE-LAW")]
        public Collection<Concept> InterpretedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETED_BY_JUDGEMENT_CASE-LAW")]
        public Collection<Concept> JudgmentInterpretedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_JUDGEMENT_CORRECTED_BY_CASE-LAW")]
        public Collection<Concept> JudgmentCorrectedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_OPINION_REQUESTED_BY_CASE-LAW")]
        public Collection<Concept> OpinionRequestedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_OPINION_REQUESTED_BY_COMMUNICATION_REQUEST_OPINION")]
        public Collection<Concept> OpinionRequestedByCommunications { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_ADOPTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyAdoptedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_ANNULLED_BY_CASE-LAW")]
        public Collection<Concept> PartiallyAnnulledByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_REFERRED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyReferredTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_SUSPENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallySuspendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIAL_ANNULMENT_REQUESTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> PartialAnnulmentRequestedByCommunication { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PRELIMINARY_QUESTION-SUBMITTED_BY_COMMUNICATION_CASE_NEW")]
        public Collection<Concept> PreliminaryQuestionSubmittedByCommunication { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PUBLISHED_IN_SPECIAL-OFFICIAL-JOURNAL")]
        public Collection<Relation> PublishedInSpecialOfficialJournal { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RECEIVED_OPINION_CJEU")]
        public Collection<Concept> ReceivedOpinionCjeu { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REESTABLISHED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ReestablishedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RELATED_QUESTION_TO_RESOURCE_LEGAL")]
        public Collection<Concept> QuestionRelatedTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RELATED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> RelatedToLegalResources { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RENDERED_OBSOLETE_BY_RESOURCE_LEGAL")]
        public Collection<Concept> RenderedObsoleteBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPEALED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> RepealedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPLACED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ReplacedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REVIEWED_BY_CASE-LAW")]
        public Collection<Concept> ReviewedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_SUSPENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> SuspendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_TACKLES_SIMILAR_QUESTION_AS_RESOURCE_LEGAL")]
        public Collection<Concept> TacklesSimilarQuestionAs { get; set; }

        [XmlElement ("RESOURCE_LEGAL_VALIDATION_REQUESTED_BY_CASE-LAW")]
        public Collection<Concept> ValidationRequestedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_VALIDITY_EXTENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ValidityExtendedBy { get; set; }

        [XmlElement ("WORK_PART_OF_DOSSIER")]
        public Collection<Relation> PartOfDossiers { get; set; }

        [XmlElement ("WORK_PART_OF_EVENT_LEGAL")]
        public Collection<Concept> PartOfEvents { get; set; }

        [XmlElement ("WORK_PART_OF_WORK")]
        public Collection<Relation> PartOfWorks { get; set; }

        [XmlElement ("WORK_RELATED_TO_WORK")]
        public Collection<Concept> RelatedTo { get; set; }

        [XmlElement ("WORK_SUMMARIZED_BY_SUMMARY")]
        public Collection<Concept> SummarizedBy { get; set; }
    }
}

