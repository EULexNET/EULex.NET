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
    public class Procedure2014_218Test
    {
        Notice notice;

        [OneTimeSetUp]
        protected async Task SetUp ()
        {
            notice = await TestUtils.GetSingleNotice ("LP_INTER_CODE_YEAR = 2014 AND LP_INTER_CODE_NUM = 218", Language.en);
        }

        [Test]
        public void HasWork ()
        {
            Assert.That (notice.Dossier, Is.Not.Null);
        }

        [Test]
        public void CheckLegalBasis ()
        {
            var v = notice.Dossier.BasedOn [0];
            Assert.That (v.SameAs.Any (e => e.Uri.Identifier == "12012E091"));
        }

        [Test]
        public void CheckInitiatedByPreparatoryAct ()
        {
            var v = notice.Dossier.InitiatedByPreparatoryAct [0];
            Assert.That (v.SameAs.Any (e => e.Uri.Identifier == "52014PC0476"));
            Assert.That (v.EmbeddedNotice.Work.Eurovoc.Any (e => e.Concept.Identifier == "4047"));
            Assert.That (v.EmbeddedNotice.Expression.Title.Value, Does.StartWith ("Proposal for a DIRECTIVE"));
        }

        [Test]
        public void CheckReferenceNumber ()
        {
            var v = notice.Dossier.ReferenceNumber.Value;
            Assert.That (v, Is.EqualTo ("476"));
        }

        [Test]
        public void CheckReferenceType ()
        {
            var v = notice.Dossier.ReferenceType.Value;
            Assert.That (v, Is.EqualTo ("COM"));
        }

        [Test]
        public void CheckReferenceYear ()
        {
            var v = notice.Dossier.ReferenceYear.Value;
            Assert.That (v, Is.EqualTo ("2014"));
        }

        [Test]
        public void CheckProducesWorks ()
        {
            var v = notice.Dossier.ProducesWorks [0].SameAs;
            Assert.That (v.Any (e => e.Identifier == "32015L0413"));
        }

        [Test]
        public void CheckProcedureReference ()
        {
            var v = notice.Dossier.ProcedureReference.Value;
            Assert.That (v, Is.EqualTo ("2014/0218/COD"));
        }
    }
}

