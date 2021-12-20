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
    public partial class Work
    {
        [XmlElement ("ACT_CONSOLIDATED_BASED_ON_RESOURCE_LEGAL")]
        public Collection<Concept> ConsolidationBasedOn { get; set; }

        [XmlElement ("ACT_CONSOLIDATED_DATE")]
        public Date DateConsolidatedAct { get; set; }

        [XmlElement ("AGREEMENT_INTERNATIONAL_ASSOCIATED_TO_RESOURCE_LEGAL")]
        public Collection<Relation> InternationalAgreementAssociatedTo { get; set; }

        [XmlElement ("AGREEMENT_INTERNATIONAL_HAS_TYPE_COMMENT_CONCEPT_TYPE_COMMENT")]
        public Collection<Concept> InternationalAgreementCommentType { get; set; }

        [XmlElement ("ASKED_BY")]
        public Collection<Concept> AskedBy { get; set; }

        [XmlElement ("CASE-LAW_AFFAIRE_NUMBER")]
        public Collection<Literal> CaseNumber { get; set; }

        [XmlElement ("CASE-LAW_AFFAIRE_YEAR")]
        public Collection<Literal> CaseYear { get; set; }

        [XmlElement ("CASE-LAW_AFFECTS_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawAffects { get; set; }

        [XmlElement ("CASE-LAW_AMENDS_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawAmends { get; set; }

        [XmlElement ("CASE-LAW_ARTICLE_JOURNAL_RELATED")]
        public Collection<Literal> CaseLawRelatedArticles { get; set; }

        [XmlElement ("CASE-LAW_COMMENTED_BY_AGENT")]
        public Collection<Concept> CaseLawCommentedBy { get; set; }

        [XmlElement ("CASE-LAW_CONFIRMS_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawConfirms { get; set; }

        [XmlElement ("CASE-LAW_CORRECTS_JUDGEMENT_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawCorrectsJudgments { get; set; }

        [XmlElement ("CASE-LAW_DECLARES_INCIDENTALLY_VALID_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawDeclaresIncidentallyValid { get; set; }

        [XmlElement ("CASE-LAW_DECLARES_VALID_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawDeclaresValid { get; set; }

        [XmlElement ("CASE-LAW_DECLARES_VOID_BY_PRELIMINARY_RULING_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawDeclaresVoidByPreliminaryRuling { get; set; }

        [XmlElement ("CASE-LAW_DECLARES_VOID_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawDeclaresVoid { get; set; }

        [XmlElement ("CASE-LAW_DEFENDED_BY_AGENT")]
        public Collection<Concept> CaseLawDefendedBy { get; set; }

        [XmlElement ("CASE-LAW_DEFERS_APPLICATION_OF_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawDefersApplicationOf { get; set; }

        [XmlElement ("CASE-LAW_DELIVERED_BY_ADVOCATE-GENERAL")]
        public Concept CaseLawDeliveredByAdvocateGeneral { get; set; }

        [XmlElement ("CASE-LAW_DELIVERED_BY_COURT_NATIONAL")]
        public Relation CaseLawDeliveredByNationalCourt { get; set; }

        [XmlElement ("CASE-LAW_DELIVERED_BY_JUDGE")]
        public Concept CaseLawDeliveredByJudge { get; set; }

        [XmlElement ("CASE-LAW_HAS_TYPE_PROCEDURE_CONCEPT_TYPE_PROCEDURE")]
        public Collection<Concept> CaseLawProcedureType { get; set; }

        [XmlElement ("CASE-LAW_IMMEDIATELY_ENFORCES_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawImmediatelyEnforces { get; set; }

        [XmlElement ("CASE-LAW_INCIDENTALLY_DECLARES_VOID_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawIncidentallyDeclaresVoid { get; set; }

        [XmlElement ("CASE-LAW_INTERPRETES_JUDGEMENT_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawInterpretesJudgments { get; set; }

        [XmlElement ("CASE-LAW_INTERPRETES_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawInterpretes { get; set; }

        [XmlElement ("CASE-LAW_IS_ABOUT_CONCEPT.MEMBERLIST")]
        public Collection<CaseLawDirectoryClassification> CaseLawIsAbout { get; set; }

        [XmlElement ("CASE-LAW_IS_ABOUT_CONCEPT_CASE-LAW")]
        public Collection<CaseLawDirectoryCode> CaseLawDirectoryCodes { get; set; }

        [XmlElement ("CASE-LAW_IS_ABOUT_CONCEPT_NEW_CASE-LAW")]
        public Collection<NewCaseLawDirectoryCode> CaseLawNewDirectoryCodes { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL-JUDGEMENT")]
        public Collection<Literal> CaseLawNationalJudgment { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_ACT_REFERENCE_EUROPEAN")]
        public Collection<Literal> CaseLawReferenceToEuropeanAct { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_ACT_REFERENCE_NATIONAL")]
        public Collection<Literal> CaseLawReferenceToNationalAct { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_BASED_ON_RESOURCE_LEGAL")]
        public Collection<Concept> NationalCaseLawBasedOn { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_DECISION_INTERNAL_IDENTIFIER")]
        public Collection<Literal> NationalCaseLawInternalIdentifier { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_JUDGEMENT_REFERENCE")]
        public Collection<Literal> NationalCaseLawJudgmentReference { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_KEYWORDS")]
        public Collection<Literal> NationalCaseLawKeywords { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_PARTIES")]
        public Collection<Literal> NationalCaseLawParties { get; set; }

        [XmlElement ("CASE-LAW_NATIONAL_REFERENCE_PUBLICATION")]
        public Collection<Literal> NationalCaseLawPublicationReference { get; set; }

        [XmlElement ("CASE-LAW_ORIGINATES_IN_COUNTRY")]
        public Collection<Concept> CaseLawOriginatesInCountry { get; set; }

        [XmlElement ("CASE-LAW_PARTIALLY_ANNULS_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawPartiallyAnnuls { get; set; }

        [XmlElement ("CASE-LAW_PUBLISHED_IN_ERECUEIL")]
        public Collection<Literal> CaseLawPublishedInERecueil { get; set; }

        [XmlElement ("CASE-LAW_REEXAMINED_BY_CASE_COURT")]
        public Collection<Literal> CaseLawReexaminedByCase { get; set; }

        [XmlElement ("CASE-LAW_REQUESTED_BY_AGENT")]
        public Collection<Concept> CaseLawRequestedBy { get; set; }

        [XmlElement ("CASE-LAW_REQUESTS_ANNULMENT_OF_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawRequestsAnnulmentOf { get; set; }

        [XmlElement ("CASE-LAW_REQUESTS_FOR_FAILURE_TO_FULFILL_AN_OBLIGATION_FOR_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawRequestsForFailureToFulfillAnObligationFor { get; set; }

        [XmlElement ("CASE-LAW_REQUESTS_INTERPRETATION_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawRequestsInterpretation { get; set; }

        [XmlElement ("CASE-LAW_REQUESTS_OPINION_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawRequestsOpinion { get; set; }

        [XmlElement ("CASE-LAW_REQUESTS_VALIDATION_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawRequestsValidation { get; set; }

        [XmlElement ("CASE-LAW_REVIEWS_JUDGEMENT_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawReviewsJudgment { get; set; }

        [XmlElement ("CASE-LAW_STATES_FAILURE_CONCERNING_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawStatesFailureConcerning { get; set; }

        [XmlElement ("CASE-LAW_SUBJECT_TO_APPEAL_IN_CASE_COURT")]
        public Collection<Literal> CaseLawSubjectToAppealInCase { get; set; }

        [XmlElement ("CASE-LAW_SUSPENDS_APPLICATION_OF_RESOURCE_LEGAL")]
        public Collection<Concept> CaseLawSuspendsApplicationOf { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_REQUESTS_ANNULMENT_OF_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationRequestsAnnulmentOf { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_REQUESTS_ESTABLISHMENT_OF_FAILURE_OF_OBLIGATION_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationRequestsEstablishmentOfFailureOfObligation { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_REQUESTS_INAPPLICABILITY_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationRequestsInapplicability { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_REQUESTS_PARTIAL_ANNULMENT_OF_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationRequestsPartialAnnulmentOf { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_REQUESTS_REVIEW_OF_DECISION_CASE-LAW")]
        public Collection<Concept> CaseCommunicationRequestsReviewOfDecision { get; set; }

        [XmlElement ("COMMUNICATION_CASE_NEW_SUBMITS_PRELIMINARY_QUESTION_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationSubmitsPreliminaryQuestion { get; set; }

        [XmlElement ("COMMUNICATION_CJEU_COMMUNICATES_ON_CASE-LAW")]
        public Collection<Concept> CaseCommunicationOn { get; set; }

        [XmlElement ("COMMUNICATION_CJEU_DEFENDED_BY_AGENT")]
        public Collection<Concept> CaseCommunicationDefendedBy { get; set; }

        [XmlElement ("COMMUNICATION_CJEU_HAS_TYPE_PROCEDURE_CONCEPT_TYPE_PROCEDURE")]
        public Collection<Concept> CaseCommunicationProcedureType { get; set; }

        [XmlElement ("COMMUNICATION_CJEU_REQUESTED_BY_AGENT")]
        public Collection<Concept> CaseCommunicationRequestedBy { get; set; }

        [XmlElement ("COMMUNICATION_REQUEST_OPINION_REQUESTS_OPINION_ON_RESOURCE_LEGAL")]
        public Collection<Concept> CaseCommunicationRequestsOpinion { get; set; }

        [XmlElement ("COOPERATION_POLICE-AND-JUDICIAL_DATE_TRANSPOSITION")]
        public Collection<Date> DateTranspositionCooperation { get; set; }

        [XmlElement ("CREATED_BY")]
        public Collection<Concept> CreatedBy { get; set; }

        [XmlElement ("DATE_CREATION_LEGACY")]
        public Date DateCreation { get; set; }

        [XmlElement ("DATE_DEBATE")]
        public Collection<Date> DateDebate { get; set; }

        [XmlElement ("DATE_NOTIFICATION")]
        public Collection<Date> DateNotification { get; set; }

        [XmlElement ("DATE_REPLY")]
        public Collection<Date> DateReply { get; set; }

        [XmlElement ("DATE_TRANSPOSITION")]
        public Collection<Date> DateTransposition { get; set; }

        [XmlElement ("DECISION_DATE_TRANSPOSITION")]
        public Collection<Date> DateTranspositionDecision { get; set; }

        [XmlElement ("DIRECTIVE_DATE_TRANSPOSITION")]
        public Collection<Date> DateTranspositionDirective { get; set; }

        [XmlElement ("ECLI")]
        public Literal Ecli { get; set; }

        [XmlElement ("ID_CELEX")]
        public Collection<Literal> Celex { get; set; }

        [XmlElement ("ID_LEGISSUM")]
        public Literal LegislationSummaryId { get; set; }

        [XmlElement ("ID_OBSOLETE_DOCUMENT")]
        public Collection<Literal> ObsoleteId { get; set; }

        [XmlElement ("ID_SECTOR")]
        public Literal Sector { get; set; }

        [XmlElement ("LASTMODIFICATIONDATE")]
        public Date DateLastModification { get; set; }

        [XmlElement ("LEGAL_EFFECT_PAPER")]
        public Literal LegalEffectPaper { get; set; }

        [XmlElement ("MEASURE_NATIONAL_IMPLEMENTING_DATE_TRANSPOSITION")]
        public Collection<Date> NationalImplementingMeasureDateTransposition { get; set; }

        [XmlElement ("MEASURE_NATIONAL_IMPLEMENTING_IMPLEMENTS_DIRECTIVE")]
        public Collection<Concept> NationalImplementingMeasureImplements { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_CLASS")]
        public Collection<Literal> OfficialJournalClass { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_NUMBER")]
        public Collection<Literal> OfficialJournalNumber { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_PART_OF_COLLECTION_DOCUMENT")]
        public Collection<Concept> OfficialJournalCollection { get; set; }

        [XmlElement ("OFFICIAL-JOURNAL_YEAR")]
        public Collection<Literal> OfficialJournalYear { get; set; }

        [XmlElement ("OPINION_CJEU_GIVEN_ON_RESOURCE_LEGAL")]
        public Collection<Concept> CjeuOpinionGivenOn { get; set; }

        [XmlElement ("PROCEDURE_NUMBER")]
        public Collection<Literal> ProcedureNumbers { get; set; }

        [XmlElement ("PROCEDURE_TYPE")]
        public Collection<Literal> ProcedureTypes { get; set; }

        [XmlElement ("PROCEDURE_YEAR")]
        public Collection<Literal> ProcedureYears { get; set; }

        [XmlElement ("PUBLISHED")]
        public Literal ParliamentaryQuestionPublished { get; set; }

        [XmlElement ("QUESTION_PARLIAMENTARY_ASKED_BY_GROUP_PARLIAMENTARY")]
        public Collection<Concept> ParliamentaryQuestionAskedByParliamentaryGroup { get; set; }

        [XmlElement ("QUESTION_PARLIAMENTARY_DATE_REPLY")]
        public Collection<Date> ParliamentaryQuestionDateReply { get; set; }

        [XmlElement ("RECOMMENDATION_DATE_TRANSPOSITION")]
        public Collection<Date> RecommandationDateTransposition { get; set; }

        [XmlElement ("RECOMMENDATION_ECSC_DATE_TRANSPOSITION")]
        public Collection<Date> EcscRecommandationDateTransposition { get; set; }

        [XmlElement ("REGULATION_DATE_TRANSPOSITION")]
        public Collection<Date> RegulationDateTransposition { get; set; }

        [XmlElement ("REPORTED_BY")]
        public Collection<Concept> ReportedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADDED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> AddedTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADDRESSES_AGENT")]
        public Collection<Concept> AddressesAgent { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADDS_TO_RESOURCE_LEGAL")]
        public Collection<Concept> AddsTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADOPTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AdoptedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ADOPTS_RESOURCE_LEGAL")]
        public Collection<Concept> Adopts { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDED_BY_CASE-LAW")]
        public Collection<Concept> AmendedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AmendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDMENT_PROPOSED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> AmendmentProposedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_AMENDS_RESOURCE_LEGAL")]
        public Collection<Concept> Amends { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_DEFERRED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ApplicationDeferredBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_EXTENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ApplicationExtendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_APPLICATION_SUSPENDED_BY_CASE-LAW")]
        public Collection<Concept> ApplicationSuspendedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_BASED_ON_CONCEPT_TREATY")]
        public Collection<Concept> BasedOnTreaties { get; set; }

        [XmlElement ("RESOURCE_LEGAL_BASED_ON_RESOURCE_LEGAL")]
        public Collection<Concept> BasedOn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COMMENT_INTERNAL")]
        public Collection<Literal> InternalComments { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COMPLETED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> CompletedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COMPLETES_RESOURCE_LEGAL")]
        public Collection<Concept> Completes { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONFIRMED_BY_CASE-LAW")]
        public Collection<Concept> ConfirmedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONFIRMED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ConfirmedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONFIRMS_RESOURCE_LEGAL")]
        public Collection<Concept> Confirms { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONTAINS_COR_OPINION_ON_RESOURCE_LEGAL")]
        public Collection<Concept> ContainsCorOpinionOn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONTAINS_EESC_OPINION_ON_RESOURCE_LEGAL")]
        public Collection<Concept> ContainsEescOpinionOn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CONTAINS_EP_OPINION_ON_RESOURCE_LEGAL")]
        public Collection<Concept> ContainsEpOpinionOn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CORRECTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> CorrectedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_CORRECTS_RESOURCE_LEGAL")]
        public Collection<Concept> Corrects { get; set; }

        [XmlElement ("RESOURCE_LEGAL_COR_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> CorOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_DEADLINE")]
        public Collection<Date> DateDeadline { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_DISPATCH")]
        public Collection<Date> DateDispatch { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_END-OF-VALIDITY")]
        public Collection<Date> DateEndOfValidity { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_ENTRY-INTO-FORCE")]
        public Collection<Date> DateEntryIntoForce { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_REQUEST_OPINION")]
        public Collection<Date> DateRequestOpinion { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_SIGNATURE")]
        public Collection<Date> DateSignature { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DATE_VOTE")]
        public Collection<Date> DateVote { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VALID_BY_CASE-LAW")]
        public Collection<Concept> DeclaredValidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VOID_BY_CASE-LAW")]
        public Collection<Concept> DeclaredVoidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DECLARED_VOID_BY_PRELIMINARY_RULING_CASE-LAW")]
        public Collection<Concept> DeclaredVoidByPreliminaryRuling { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DEFERS_APPLICATION_OF_RESOURCE_LEGAL")]
        public Collection<Concept> DefersApplicationOf { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DEROGATED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> DerogatedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_DEROGATES_RESOURCE_LEGAL")]
        public Collection<Concept> Derogates { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EESC_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> EescOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ELI")]
        public Collection<Literal> Eli { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EP_OPINION_CONTAINED_IN_RESOURCE_LEGAL")]
        public Collection<Concept> EpOpinionContainedIn { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EXTENDS_APPLICATION_RESOURCE_LEGAL")]
        public Collection<Concept> ExtendsApplication { get; set; }

        [XmlElement ("RESOURCE_LEGAL_EXTENDS_VALIDITY_OF_RESOURCE_LEGAL")]
        public Collection<Concept> ExtendsValidityOf { get; set; }

        [XmlElement ("RESOURCE_LEGAL_FAILURE_STATED_BY_CASE-LAW")]
        public Collection<Concept> FailureStatedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_ID_LOCAL")]
        public Collection<Literal> LocalId { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMMEDIATELY_ENFORCED_BY_CASE-LAW")]
        public Collection<Concept> ImmediatelyEnforcedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLEMENTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ImplementedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLEMENTS_RESOURCE_LEGAL")]
        public Collection<Concept> Implements { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLICITLY_REPEALED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ImplicitlyRepealedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IMPLICITLY_REPEALS_RESOURCE_LEGAL")]
        public Collection<Concept> ImplicitlyRepeals { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IN-FORCE")]
        public Literal InForce { get; set; }

        [XmlIgnore]
        public bool? IsInForce {
            get { return this.InForce?.Value.ToLower ().Equals ("true"); }
        }

        [XmlElement ("RESOURCE_LEGAL_INCIDENTALLY_DECLARED_VALID_CASE-LAW")]
        public Collection<Concept> IncidentallyDeclaredValidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCIDENTALLY_DECLARED_VOID_BY_CASE-LAW")]
        public Collection<Concept> IncidentallyDeclaredVoidByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCORPORATED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> IncorporatedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INCORPORATES_RESOURCE_LEGAL")]
        public Collection<Concept> Incorporates { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INFORMATION_MISCELLANEOUS")]
        public Collection<Literal> MiscellaneousInformation { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETED_AUTHORITATIVELY_BY_RESOURCE_LEGAL")]
        public Collection<Concept> InterpretedAuthoritativelyBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETED_BY_CASE-LAW")]
        public Collection<Concept> InterpretedByCaseLaw { get; set; }

        [XmlElement ("RESOURCE_LEGAL_INTERPRETES_AUTHORITATIVELY_RESOURCE_LEGAL")]
        public Collection<Concept> InterpretesAuthoritatively { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE")]
        public Collection<DirectoryCode> DirectoryCodes { get; set; }

        [XmlElement ("RESOURCE_LEGAL_IS_ABOUT_SUBJECT-MATTER")]
        public Collection<SubjectMatter> SubjectMatters { get; set; }

        [XmlElement ("RESOURCE_LEGAL_NUMBER_CORRIGENDUM")]
        public Collection<Literal> CorrigendumNumber { get; set; }

        [XmlElement ("RESOURCE_LEGAL_NUMBER_NATURAL_CELEX")]
        public Collection<Literal> NaturalNumberCelex { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_ADOPTED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyAdoptedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_ADOPTS_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyAdopts { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_REFERRED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyReferredBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_REFERS_TO_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallyReferesTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_SUSPENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallySuspendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PARTIALLY_SUSPENDS_RESOURCE_LEGAL")]
        public Collection<Concept> PartiallySuspends { get; set; }

        [XmlElement ("RESOURCE_LEGAL_POSITION_EESC")]
        public Collection<Literal> EescPosition { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PROPOSES_TO_AMEND_RESOURCE_LEGAL")]
        public Collection<Concept> ProposesToAmend { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PUBLISHED_IN_COURT-REPORT")]
        public Collection<Relation> PublishedInCourtReport { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PUBLISHED_IN_OFFICIAL-JOURNAL")]
        public Collection<Relation> PublishedInOfficialJournal { get; set; }

        [XmlElement ("RESOURCE_LEGAL_PUBLISHED_IN_SPECIAL-OFFICIAL-JOURNAL")]
        public Collection<Relation> PublishedInSpecialOfficialJournal { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REESTABLISHED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ReestablishedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REESTABLISHES_RESOURCE_LEGAL")]
        public Collection<Concept> Reestablishes { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RELATED_QUESTION_TO_RESOURCE_LEGAL")]
        public Collection<Concept> QuestionRelatedTo { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RELATED_TO_RESOURCE_LEGAL")]
        public Collection<Concept> RelatedToLegalResources { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RENDERED_OBSOLETE_BY_RESOURCE_LEGAL")]
        public Collection<Concept> RenderedObsoleteBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_RENDERS_OBSOLETE_RESOURCE_LEGAL")]
        public Collection<Concept> RendersObsolete { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPEALED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> RepealedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPEALS_RESOURCE_LEGAL")]
        public Collection<Concept> Repeals { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPERTOIRE")]
        public Collection<Literal> Repertoire { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPLACED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ReplacedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_REPLACES_RESOURCE_LEGAL")]
        public Collection<Concept> Replaces { get; set; }

        [XmlElement ("RESOURCE_LEGAL_SUSPENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> SuspendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_SUSPENDS_RESOURCE_LEGAL")]
        public Collection<Concept> Suspends { get; set; }

        [XmlElement ("RESOURCE_LEGAL_TACKLES_SIMILAR_QUESTION_AS_RESOURCE_LEGAL")]
        public Collection<Concept> TacklesSimilarQuestionAs { get; set; }

        [XmlElement ("RESOURCE_LEGAL_TYPE")]
        public Collection<Literal> DocumentType { get; set; }

        [XmlElement ("RESOURCE_LEGAL_USES_ORIGINALLY_LANGUAGE")]
        public Collection<Concept> OriginalLanguages { get; set; }

        [XmlElement ("RESOURCE_LEGAL_VALIDITY_EXTENDED_BY_RESOURCE_LEGAL")]
        public Collection<Concept> ValidityExtendedBy { get; set; }

        [XmlElement ("RESOURCE_LEGAL_YEAR")]
        public Collection<Literal> DocumentYear { get; set; }

        [XmlElement ("SAMEAS")]
        public Collection<SameAs> SameAs { get; set; }

        [XmlElement ("SERVICE_ASSOCIATED")]
        public Collection<Literal> AssociatedServices { get; set; }

        [XmlElement ("SERVICE_RESPONSIBLE")]
        public Collection<Literal> ResponsibleServices { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_IS_ABOUT_CONCEPT_DIRECTORY-CODE")]
        public Collection<SpecialOfficialJournalDirectoryCode> SpecialOfficialJournalDirectoryCode { get; set; }

        [XmlElement ("SPECIAL-OFFICIAL-JOURNAL_VOLUME")]
        public Collection<Literal> SpecialOfficialJournalVolume { get; set; }

        [XmlElement ("STORED_BY")]
        public Collection<Concept> StoredBy { get; set; }

        [XmlElement ("SUMMARY_LEGISLATION_EU_ID_DOC_RELATED")]
        public Collection<Literal> RelatedDocumentIds { get; set; }

        [XmlElement ("SUMMARY_LEGISLATION_EU_ID_DOC_SUMMARIZED")]
        public Collection<Concept> SummarizedDocumentIds { get; set; }

        [XmlElement ("SUMMARY_LEGISLATION_EU_IS_ABOUT_CLASSIFICATION_SUMMARY")]
        public Collection<Literal> SummaryClassifications { get; set; }

        [XmlElement ("SUMMARY_LEGISLATION_EU_OBSOLETE")]
        public Literal IsSummaryObsolete { get; set; }

        [XmlElement ("SUMMARY_LEGISLATION_EU_VALIDATED_BY_INSTITUTION")]
        public Collection<Concept> SummaryValidatedByInstitutions { get; set; }

        [XmlElement ("SUMMARY_SUMMARIZES_WORK")]
        public Collection<Relation> SummarizesWork { get; set; }

        [XmlElement ("TERM_PARLIAMENTARY")]
        public Collection<Literal> ParliamentaryTerm { get; set; }

        [XmlElement ("TYPE")]
        public Collection<Relation> Type { get; set; }

        [XmlElement ("URI")]
        public Uri Uri { get; set; }

        [XmlElement ("WORK_CITES_WORK")]
        public Collection<Concept> Cites { get; set; }

        [XmlElement ("WORK_CREATED_BY_AGENT")]
        public Collection<Concept> CreatedByAgent { get; set; }

        [XmlElement ("WORK_DATE_DOCUMENT")]
        public Collection<Date> DateDocument { get; set; }

        [XmlElement ("WORK_HAS_EXPRESSION")]
        public Collection<Relation> Expressions { get; set; }

        [XmlElement ("WORK_HAS_RESOURCE-TYPE")]
        public Collection<Concept> ResourceType { get; set; }

        [XmlElement ("WORK_IS_ABOUT_CONCEPT_EUROVOC")]
        public Collection<Eurovoc> Eurovoc { get; set; }

        [XmlElement ("WORK_PART_OF_COLLECTION_DOCUMENT")]
        public Collection<Concept> PartOfCollection { get; set; }

        [XmlElement ("WORK_RELATED_TO_WORK")]
        public Collection<Concept> RelatedTo { get; set; }

        [XmlElement ("WORK_TABLE-OF-CONTENTS")]
        public Collection<Literal> TableOfContents { get; set; }

        [XmlElement ("WORK_TITLE")]
        public Collection<Literal> Title { get; set; }

        [XmlElement ("LATEST_CONSLEG_DATE")]
        public Date LatestConsolidation { get; set; }
    }
}

