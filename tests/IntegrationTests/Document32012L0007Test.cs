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
    public class Document32012L0007Test : AssertionHelper
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
            Expect (notice.Work, Not.Null);
        }

        [Test]
        public void CheckAddressesInstitution ()
        {
            var v = notice.Work.AddressesInstitutions [0].Identifier;
            Expect (v, EqualTo ("27EM"));
        }

        [Test]
        public void CheckBasedOn ()
        {
            var v = notice.Work.BasedOn [0].SameAs.First (i => i.Type == "celex").Identifier;
            Expect (v, EqualTo ("32009L0048"));
        }

        [Test]
        public void CheckBasedOnTreaty ()
        {
            var v = notice.Work.BasedOnTreaties [0].Identifier;
            Expect (v, EqualTo ("TFEU_2008"));
        }

        [Test]
        public void CheckCelex ()
        {
            var v = notice.Work.Celex [0].Value;
            Expect (v, EqualTo ("32012L0007"));
        }

        [Test]
        public void CheckCreatedByAgent ()
        {
            var v = notice.Work.CreatedByAgent [0];
            Expect (v.Identifier, EqualTo ("COM"));
            Expect (v.CompactUri, EqualTo ("corporate-body:COM"));
        }

        [Test]
        public void CheckDateDocument ()
        {
            var v = notice.Work.DateDocument [0].Value;
            Expect (v, EqualTo ("2012-03-02"));
        }

        [Test]
        public void CheckDateEndOfValidity ()
        {
            var v = notice.Work.DateEndOfValidity [0].Value;
            Expect (v, EqualTo ("9999-12-31"));
        }

        [Test]
        public void CheckDateEntryIntoForce ()
        {
            var d = notice.Work.DateEntryIntoForce [0];
            Expect (d.Value, EqualTo ("2012-03-23"));
            Expect (d.Annotation.CommentOnDate [0], StartsWith ("{DATPUB"));
            Expect (d.Annotation.DateType [0], StartsWith ("{EV"));
        }

        [Test]
        public void CheckDateLastModification ()
        {
            // DateLastModification can change at any time, so only check internal consistency
            var d = notice.Work.DateLastModification;
            Expect (d.Value, Matches (d.Day + "/"));
            Expect (d.Value, Matches ("/" + d.Month + "/"));
            Expect (d.Value, Matches ("/" +d.Year));
        }

        [Test]
        public void CheckDateTransposition ()
        {
            var d = notice.Work.DateTranspositionDirective [0];
            Expect (d.Value, EqualTo ("2013-01-20"));
            Expect (d.Year, EqualTo ("2013"));
            Expect (d.Month, EqualTo ("01"));
            Expect (d.Day, EqualTo ("20"));
            Expect (d.Annotation.CommentOnDate [0], StartsWith ("{AU+TARD"));
        }

        [Test]
        public void CheckDocumentType ()
        {
            var v = notice.Work.DocumentType [0].Value;
            Expect (v, EqualTo ("L"));
        }

        [Test]
        public void CheckDocumentYear ()
        {
            var v = notice.Work.DocumentYear [0].Value;
            Expect (v, EqualTo ("2012"));
        }

        [Test]
        public void CheckDirectoryCodes ()
        {
            var v = notice.Work.DirectoryCodes;
            Expect (v.Any (e => e.Level3.Identifier == "133099"));
            Expect (v.Any (e => e.Level3.Identifier == "152030"));
        }

        [Test]
        public void CheckEli ()
        {
            var v = notice.Work.Eli [0].Value;
            Expect (v, EqualTo ("http://data.europa.eu/eli/dir/2012/7/oj"));
        }

        [Test]
        public void CheckEurovoc ()
        {
            var v = notice.Work.Eurovoc;
            Expect (v.Any (e => e.Concept.Identifier == "1391"));
            Expect (v.Any (e => e.Concept.Identifier == "5234"));
            Expect (v.Any (e => e.Concept.Identifier == "3730"));
            Expect (v.Any (e => e.Concept.Identifier == "4036"));
            Expect (v.Any (e => e.Concept.Identifier == "192"));
            Expect (v.Any (e => e.Concept.Identifier == "3135"));
            Expect (v.Any (e => e.Concept.Identifier == "758"));
            Expect (v.Any (e => e.Concept.Identifier == "3836"));
        }

        [Test]
        public void CheckExpressions ()
        {
            var v = notice.Work.Expressions;
            Expect (v.Count, EqualTo (23));
            Expect (v, All.Not.Null);
        }

        [Test]
        public void CheckInForce ()
        {
            var v = notice.Work.IsInForce;
            Expect (v, True);
        }

        [Test]
        public void CheckInternalComment ()
        {
            var v = notice.Work.InternalComments [0].Value;
            Expect (v, EqualTo ("MAN2"));
        }

        [Test]
        public void CheckMiscellaneousInformation ()
        {
            var v = notice.Work.MiscellaneousInformation [0].Value;
            Expect (v, StartsWith ("{P/EEE"));
        }

        [Test]
        public void CheckPartOfCollection ()
        {
            var v = notice.Work.PartOfCollection;
            Expect (v.Any (e => e.Identifier == "JO"));
            Expect (v.Any (e => e.Identifier == "CELEX"));
        }

        [Test]
        public void CheckPublishedInOfficialJournal ()
        {
            var v = notice.Work.PublishedInOfficialJournal [0].SameAs [0].Identifier;
            Expect (v, EqualTo ("JOL_2012_064_R"));
            var n = notice.Work.PublishedInOfficialJournal [0].EmbeddedNotice;
            Expect (n.Work.OfficialJournalCollection [0].Identifier, EqualTo ("OJ-L"));
        }

        [Test]
        public void CheckPublishedInSpecialOfficialJournal ()
        {
            var v = notice.Work.PublishedInSpecialOfficialJournal [0].SameAs.First (i => i.Type == "oj");
            Expect (v.Identifier, EqualTo ("DD_2013_13_048_HR"));
            var n = notice.Work.PublishedInSpecialOfficialJournal [0].EmbeddedNotice;
            Expect (n.Work.SpecialOfficialJournalVolume [0].Value, EqualTo ("048"));
        }

        [Test]
        public void CheckRepertoire ()
        {
            var v = notice.Work.Repertoire [0].Value;
            Expect (v, EqualTo ("LIE"));
        }

        [Test]
        public void CheckResourceType ()
        {
            var v = notice.Work.ResourceType [0].Identifier;
            Expect (v, EqualTo ("DIR"));
        }

        [Test]
        public void CheckSector ()
        {
            var v = notice.Work.Sector.Value;
            Expect (v, EqualTo ("3"));
        }

        [Test]
        public void CheckSubjectMatter ()
        {
            var v = notice.Work.SubjectMatters;
            Expect (v.Any (e => e.Concept.Identifier == "PROT"));
            Expect (v.Any (e => e.Concept.Identifier == "MARI"));

        }

        [Test]
        public void CheckExpressionTitle ()
        {
            var v = notice.Expression.Title [0].Value;
            Expect (v, StartsWith ("Commission Directive 2012/7/EU"));
        }

        [Test]
        public void CheckExpressionLanguage ()
        {
            var v = notice.Expression.Language [0].Uri.Identifier;
            Expect (v, EqualTo ("ENG"));
        }
    }
}

