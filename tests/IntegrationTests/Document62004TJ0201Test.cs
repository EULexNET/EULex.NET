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
    public class Document62004TJ0201Test
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
            Assert.That (notice.Work, Is.Not.Null);
        }

        [Test]
        public void CheckCaseLawRelatedArticles ()
        {
            var v = notice.Work.CaseLawRelatedArticles;
            Assert.That (v.Count, Is.GreaterThanOrEqualTo (54));
            Assert.That (v.Any (e => e.Value.IndexOf ("López Miño, Antonio") > 0));
        }

        [Test]
        public void CheckCaseLawDefendedBy ()
        {
            var v = notice.Work.CaseLawDefendedBy;
            Assert.That (v.Any (e => e.Identifier == "IC"));
            Assert.That (v.Any (e => e.Identifier == "COMM"));
        }

        [Test]
        public void CheckCaseLawProcedureType ()
        {
            var v = notice.Work.CaseLawProcedureType;
            Assert.That (v.Any (e => e.Identifier == "ANNU=OB"));
            Assert.That (v.Any (e => e.Identifier == "ANNU=RF"));
            Assert.That (v.Any (e => e.Identifier == "SANC=RF"));
        }

        [Test]
        public void CheckCaseLawIsAbout ()
        {
            // TODO CaseLawIsAbout
            //var v = notice.Work.CaseLawIsAbout;
            //Assert.That (v.Any (e => e.ClassificationEntries == "ANNU=OB"));
        }

        [Test]
        public void CheckCaseLawRequestedBy ()
        {
            var v = notice.Work.CaseLawRequestedBy;
            Assert.That (v.Any (e => e.Identifier == "PART"));
        }

        [Test]
        public void CheckEcli ()
        {
            var v = notice.Work.Ecli.Value;
            Assert.That (v, Is.EqualTo ("ECLI:EU:T:2007:289"));
        }

        [Test]
        public void CheckCelex ()
        {
            var v = notice.Work.Celex [0].Value;
            Assert.That (v, Is.EqualTo ("62004TJ0201"));
        }

        [Test]
        public void CheckSector ()
        {
            var v = notice.Work.Sector.Value;
            Assert.That (v, Is.EqualTo ("6"));
        }

        [Test]
        public void CheckBasedOnTreaties ()
        {
            var v = notice.Work.BasedOnTreaties [0].Identifier;
            Assert.That (v, Is.EqualTo ("TEEC_1957"));
        }

        [Test]
        public void CheckDateRequestOpinion ()
        {
            var v = notice.Work.DateRequestOpinion [0].Value;
            Assert.That (v, Is.EqualTo ("2004-06-07"));
        }

        [Test]
        public void CheckSubjectMatters ()
        {
            var v = notice.Work.SubjectMatters;
            Assert.That (v.Any (e => e.Concept.Identifier == "CONC"));
            Assert.That (v.Any (e => e.Concept.Identifier == "POSI"));
        }

        [Test]
        public void CheckDocumentType ()
        {
            var v = notice.Work.DocumentType [0].Value;
            Assert.That (v, Is.EqualTo ("TJ"));
        }

        [Test]
        public void CheckOriginalLanguage ()
        {
            var v = notice.Work.OriginalLanguages [0].Identifier;
            Assert.That (v, Is.EqualTo ("ENG"));
        }

        [Test]
        public void CheckDocumentYear ()
        {
            var v = notice.Work.DocumentYear [0].Value;
            Assert.That (v, Is.EqualTo ("2004"));
        }

        [Test]
        public void CheckCreatedByAgent ()
        {
            var v = notice.Work.CreatedByAgent [0];
            Assert.That (v.Identifier, Is.EqualTo ("GCEU"));
            Assert.That (v.CompactUri, Is.EqualTo ("corporate-body:GCEU"));
        }

        [Test]
        public void CheckDateDocument ()
        {
            var v = notice.Work.DateDocument [0].Value;
            Assert.That (v, Is.EqualTo ("2007-09-17"));
        }

        [Test]
        public void CheckExpressions ()
        {
            var v = notice.Work.Expressions;
            Assert.That (v.Count, Is.EqualTo (23));
            Assert.That (v, Is.All.Not.Null);
        }

        [Test]
        public void CheckResourceType ()
        {
            var v = notice.Work.ResourceType [0].Identifier;
            Assert.That (v, Is.EqualTo ("JUDG"));
        }

        [Test]
        public void CheckExpressionTitle ()
        {
            var v = notice.Expression.Title [0].Value;
            Assert.That (v, Does.StartWith ("Judgment of the Court of First Instance (Grand Chamber) of 17 September 2007"));
        }

        [Test]
        public void CheckExpressionLanguage ()
        {
            var v = notice.Expression.Language [0].Uri.Identifier;
            Assert.That (v, Is.EqualTo ("ENG"));
        }

        [Test]
        public void CheckManifestationMetadata ()
        {
            var v = notice.Manifestations.First(m => m.CourtReportPartFirstPage != null);
            
            Assert.That (v.CourtReportPartFirstPage.Value, Is.EqualTo ("03601"));
            Assert.That (v.CourtReportPartType.Value, Is.EqualTo ("RJII"));
            Assert.That (v.CourtReportPartYear.Value, Is.EqualTo ("2007"));
        }
    }
}

