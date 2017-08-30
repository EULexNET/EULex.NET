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
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

using EULex.Model;

namespace EULex.IntegrationTests
{
    [TestFixture]
    public class Document32012L0007Test
    {
        Notice notice;

        [OneTimeSetUp]
        protected async Task SetUp ()
        {
            notice = await TestUtils.GetSingleNotice ("DN = 32012L0007", Language.en);
        }

        [Test]
        public void HasWork ()
        {
            Assert.That (notice.Work, Is.Not.Null);
        }

        [Test]
        public void CheckAddressesInstitution ()
        {
            var v = notice.Work.AddressesInstitutions [0].Identifier;
            Assert.That (v, Is.EqualTo ("27EM"));
        }

        [Test]
        public void CheckBasedOn ()
        {
            var v = notice.Work.BasedOn [0].SameAs.First (i => i.Type == "celex").Identifier;
            Assert.That (v, Is.EqualTo ("32009L0048"));
        }

        [Test]
        public void CheckBasedOnTreaty ()
        {
            var v = notice.Work.BasedOnTreaties [0].Identifier;
            Assert.That (v, Is.EqualTo ("TFEU_2008"));
        }

        [Test]
        public void CheckCelex ()
        {
            var v = notice.Work.Celex [0].Value;
            Assert.That (v, Is.EqualTo ("32012L0007"));
        }

        [Test]
        public void CheckCreatedByAgent ()
        {
            var v = notice.Work.CreatedByAgent [0];
            Assert.That (v.Identifier, Is.EqualTo ("COM"));
            Assert.That (v.CompactUri, Is.EqualTo ("corporate-body:COM"));
        }

        [Test]
        public void CheckDateDocument ()
        {
            var v = notice.Work.DateDocument [0].Value;
            Assert.That (v, Is.EqualTo ("2012-03-02"));
        }

        [Test]
        public void CheckDateEndOfValidity ()
        {
            var v = notice.Work.DateEndOfValidity [0].Value;
            Assert.That (v, Is.EqualTo ("9999-12-31"));
        }

        [Test]
        public void CheckDateEntryIntoForce ()
        {
            var d = notice.Work.DateEntryIntoForce [0];
            Assert.That (d.Value, Is.EqualTo ("2012-03-23"));
            Assert.That (d.Annotation.CommentOnDate [0], Does.StartWith ("{DATPUB"));
            Assert.That (d.Annotation.DateType [0], Does.StartWith ("{EV"));
        }

        [Test]
        public void CheckDateLastModification ()
        {
            // DateLastModification can change at any time, so only check internal consistency
            var d = notice.Work.DateLastModification;
            Assert.That (d.Value, Does.Match (d.Day + "/"));
            Assert.That (d.Value, Does.Match ("/" + d.Month + "/"));
            Assert.That (d.Value, Does.Match("/" +d.Year));
        }

        [Test]
        public void CheckDateTransposition ()
        {
            var d = notice.Work.DateTranspositionDirective [0];
            Assert.That (d.Value, Is.EqualTo ("2013-01-20"));
            Assert.That (d.Year, Is.EqualTo ("2013"));
            Assert.That (d.Month, Is.EqualTo ("01"));
            Assert.That (d.Day, Is.EqualTo ("20"));
            Assert.That (d.Annotation.CommentOnDate [0], Does.StartWith ("{AU+TARD"));
        }

        [Test]
        public void CheckDocumentType ()
        {
            var v = notice.Work.DocumentType [0].Value;
            Assert.That (v, Is.EqualTo ("L"));
        }

        [Test]
        public void CheckDocumentYear ()
        {
            var v = notice.Work.DocumentYear [0].Value;
            Assert.That (v, Is.EqualTo ("2012"));
        }

        [Test]
        public void CheckDirectoryCodes ()
        {
            var v = notice.Work.DirectoryCodes;
            Assert.That (v.Any (e => e.Level3.Identifier == "133099"));
            Assert.That (v.Any (e => e.Level3.Identifier == "152030"));
        }

        [Test]
        public void CheckEli ()
        {
            var v = notice.Work.Eli [0].Value;
            Assert.That (v, Is.EqualTo ("http://data.europa.eu/eli/dir/2012/7/oj"));
        }

        [Test]
        public void CheckEurovoc ()
        {
            var v = notice.Work.Eurovoc;
            Assert.That (v.Any (e => e.Concept.Identifier == "1391"));
            Assert.That (v.Any (e => e.Concept.Identifier == "5234"));
            Assert.That (v.Any (e => e.Concept.Identifier == "3730"));
            Assert.That (v.Any (e => e.Concept.Identifier == "4036"));
            Assert.That (v.Any (e => e.Concept.Identifier == "192"));
            Assert.That (v.Any (e => e.Concept.Identifier == "3135"));
            Assert.That (v.Any (e => e.Concept.Identifier == "758"));
            Assert.That (v.Any (e => e.Concept.Identifier == "3836"));
        }

        [Test]
        public void CheckExpressions ()
        {
            var v = notice.Work.Expressions;
            Assert.That (v.Count, Is.EqualTo (23));
            Assert.That (v, Is.All.Not.Null);
        }

        [Test]
        public void CheckInForce ()
        {
            var v = notice.Work.IsInForce;
            Assert.That (v, Is.True);
        }

        [Test]
        public void CheckInternalComment ()
        {
            var v = notice.Work.InternalComments [0].Value;
            Assert.That (v, Is.EqualTo ("MAN2"));
        }

        [Test]
        public void CheckMiscellaneousInformation ()
        {
            var v = notice.Work.MiscellaneousInformation [0].Value;
            Assert.That (v, Does.StartWith ("{P/EEE"));
        }

        [Test]
        public void CheckPartOfCollection ()
        {
            var v = notice.Work.PartOfCollection;
            Assert.That (v.Any (e => e.Identifier == "JO"));
            Assert.That (v.Any (e => e.Identifier == "CELEX"));
        }

        [Test]
        public void CheckPublishedInOfficialJournal ()
        {
            var v = notice.Work.PublishedInOfficialJournal [0].SameAs [0].Identifier;
            Assert.That (v, Is.EqualTo ("JOL_2012_064_R"));
            var n = notice.Work.PublishedInOfficialJournal [0].EmbeddedNotice;
            Assert.That (n.Work.OfficialJournalCollection [0].Identifier, Is.EqualTo ("OJ-L"));
        }

        [Test]
        public void CheckPublishedInSpecialOfficialJournal ()
        {
            var v = notice.Work.PublishedInSpecialOfficialJournal [0].SameAs.First (i => i.Type == "oj");
            Assert.That (v.Identifier, Is.EqualTo ("DD_2013_13_048_HR"));
            var n = notice.Work.PublishedInSpecialOfficialJournal [0].EmbeddedNotice;
            Assert.That (n.Work.SpecialOfficialJournalVolume [0].Value, Is.EqualTo ("048"));
        }

        [Test]
        public void CheckRepertoire ()
        {
            var v = notice.Work.Repertoire [0].Value;
            Assert.That (v, Is.EqualTo ("LIE"));
        }

        [Test]
        public void CheckResourceType ()
        {
            var v = notice.Work.ResourceType [0].Identifier;
            Assert.That (v, Is.EqualTo ("DIR"));
        }

        [Test]
        public void CheckSector ()
        {
            var v = notice.Work.Sector.Value;
            Assert.That (v, Is.EqualTo ("3"));
        }

        [Test]
        public void CheckSubjectMatter ()
        {
            var v = notice.Work.SubjectMatters;
            Assert.That (v.Any (e => e.Concept.Identifier == "PROT"));
            Assert.That (v.Any (e => e.Concept.Identifier == "MARI"));

        }

        [Test]
        public void CheckExpressionTitle ()
        {
            var v = notice.Expression.Title [0].Value;
            Assert.That (v, Does.StartWith ("Commission Directive 2012/7/EU"));
        }

        [Test]
        public void CheckExpressionLanguage ()
        {
            var v = notice.Expression.Language [0].Uri.Identifier;
            Assert.That (v, Is.EqualTo ("ENG"));
        }
    }
}

