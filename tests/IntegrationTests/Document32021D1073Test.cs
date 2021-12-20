//
// Copyright 2021 Bertrand Lorentz
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
    public class Document32021D1073Test
    {
        Notice notice;

        [OneTimeSetUp]
        protected async Task SetUp ()
        {
            notice = await TestUtils.GetSingleNotice ("DN = 32021D1073", Language.en);
        }

        [Test]
        public void HasWork ()
        {
            Assert.That (notice.Work, Is.Not.Null);
        }

        [Test]
        public void CheckCelex ()
        {
            var v = notice.Work.Celex [0].Value;
            Assert.That (v, Is.EqualTo ("32021D1073"));
        }

        [Test]
        public void CheckWorkTitle ()
        {
            var v = notice.Work.Title [0].Value;
            Assert.That (v, Does.StartWith ("COMMISSION IMPLEMENTING DECISION"));
        }
    }
}
