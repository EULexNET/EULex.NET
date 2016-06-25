//
// Copyright (c) 2016 Bertrand Lorentz
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
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

using EULex.Model;

namespace EULex.IntegrationTests
{
    [TestFixture]
    public class Document62004TJ0201Test : AssertionHelper
    {
        Notice notice;

        [OneTimeSetUp]
        protected async Task SetUp ()
        {
            notice = await TestUtils.GetSingleNotice ("DN = 62004TJ0201", Language.en);
        }

        [Test]
        public void HasWork ()
        {
            Expect (notice.Work, Not.Null);
        }

        [Test]
        public void CheckCaseLawRelatedArticles ()
        {
            var v = notice.Work.CaseLawRelatedArticles;
            Expect (v.Count, GreaterThanOrEqualTo (54));
            Expect (v.Any (e => e.Value.StartsWith ("López Miño, Antonio")));
        }

        [Test]
        public void CheckCaseLawCommentedBy ()
        {
            var v = notice.Work.CaseLawCommentedBy [0];
            Expect (v.Identifier, EqualTo ("OP_DATPRO"));
            Expect (v.Annotations [0].BuildInfo, StartsWith ("cdm:"));
            Expect (v.Annotations [0].ErrorMessage [0], StartsWith ("Data"));
            Expect (v.Annotations [0].QualityIssue [0], EqualTo ("DATWRO"));
        }

        [Test]
        public void CheckCaseLawDefendedBy ()
        {
            var v = notice.Work.CaseLawDefendedBy;
            Expect (v.Any (e => e.Identifier == "IC"));
            Expect (v.Any (e => e.Identifier == "COMM"));
        }

        [Test]
        public void CheckCaseLawProcedureType ()
        {
            var v = notice.Work.CaseLawProcedureType;
            Expect (v.Any (e => e.Identifier == "ANNU=OB"));
            Expect (v.Any (e => e.Identifier == "ANNU=RF"));
            Expect (v.Any (e => e.Identifier == "SANC=RF"));
        }

        [Test]
        public void CheckCaseLawIsAbout ()
        {
            // TODO CaseLawIsAbout
            //var v = notice.Work.CaseLawIsAbout;
            //Expect (v.Any (e => e.ClassificationEntries == "ANNU=OB"));
        }

        [Test]
        public void CheckCaseLawOriginatesInCountry ()
        {
            var v = notice.Work.CaseLawOriginatesInCountry;
            Expect (v.Any (e => e.Identifier == "USA"));
        }

        [Test]
        public void CheckCaseLawRequestedBy ()
        {
            var v = notice.Work.CaseLawRequestedBy;
            Expect (v.Any (e => e.Identifier == "PART"));
        }

        [Test]
        public void CheckEcli ()
        {
            var v = notice.Work.Ecli.Value;
            Expect (v, EqualTo ("ECLI:EU:T:2007:289"));
        }

        [Test]
        public void CheckCelex ()
        {
            var v = notice.Work.Celex [0].Value;
            Expect (v, EqualTo ("62004TJ0201"));
        }

        [Test]
        public void CheckObsoleteId ()
        {
            var v = notice.Work.ObsoleteId [0].Value;
            Expect (v, EqualTo ("62004A0201"));
        }

        [Test]
        public void CheckSector ()
        {
            var v = notice.Work.Sector.Value;
            Expect (v, EqualTo ("6"));
        }

        [Test]
        public void CheckBasedOnTreaties ()
        {
            var v = notice.Work.BasedOnTreaties [0].Identifier;
            Expect (v, EqualTo ("TEEC_1957"));
        }

        [Test]
        public void CheckInternalComments ()
        {
            var v = notice.Work.InternalComments [0].Value;
            Expect (v, EqualTo ("200709T0065"));
        }

        [Test]
        public void CheckDateRequestOpinion ()
        {
            var v = notice.Work.DateRequestOpinion [0].Value;
            Expect (v, EqualTo ("2004-06-07"));
        }

        [Test]
        public void CheckSubjectMatters ()
        {
            var v = notice.Work.SubjectMatters;
            Expect (v.Any (e => e.Concept.Identifier == "CONC"));
            Expect (v.Any (e => e.Concept.Identifier == "POSI"));
        }

        [Test]
        public void CheckDocumentType ()
        {
            var v = notice.Work.DocumentType [0].Value;
            Expect (v, EqualTo ("TJ"));
        }

        [Test]
        public void CheckOriginalLanguage ()
        {
            var v = notice.Work.OriginalLanguages [0].Identifier;
            Expect (v, EqualTo ("ENG"));
        }

        [Test]
        public void CheckDocumentYear ()
        {
            var v = notice.Work.DocumentYear [0].Value;
            Expect (v, EqualTo ("2004"));
        }

        [Test]
        public void CheckCreatedByAgent ()
        {
            var v = notice.Work.CreatedByAgent [0];
            Expect (v.Identifier, EqualTo ("GCEU"));
            Expect (v.CompactUri, EqualTo ("corporate-body:GCEU"));
        }

        [Test]
        public void CheckDateDocument ()
        {
            var v = notice.Work.DateDocument [0].Value;
            Expect (v, EqualTo ("2007-09-17"));
        }

        [Test]
        public void CheckExpressions ()
        {
            var v = notice.Work.Expressions;
            Expect (v.Count, EqualTo (23));
            Expect (v, All.Not.Null);
        }

        [Test]
        public void CheckResourceType ()
        {
            var v = notice.Work.ResourceType [0].Identifier;
            Expect (v, EqualTo ("JUDG"));
        }

        [Test]
        public void CheckPartOfCollection ()
        {
            var v = notice.Work.PartOfCollection;
            Expect (v.Any (e => e.Identifier == "CELEX"));
        }

        [Test]
        public void CheckExpressionTitle ()
        {
            var v = notice.Expression.Title [0].Value;
            Expect (v, StartsWith ("Judgment of the Court of First Instance (Grand Chamber) of 17 September 2007"));
        }

        [Test]
        public void CheckExpressionLanguage ()
        {
            var v = notice.Expression.Language [0].Uri.Identifier;
            Expect (v, EqualTo ("ENG"));
        }

        [Test]
        public void CheckManifestationMetadata ()
        {
            var v = notice.Manifestations [0];
            Expect (v.CourtReportPartFirstPage.Value, EqualTo ("03601"));
            Expect (v.CourtReportPartType.Value, EqualTo ("RJII"));
            Expect (v.CourtReportPartYear.Value, EqualTo ("2007"));
        }
    }
}

