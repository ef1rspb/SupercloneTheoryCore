using System;
using NUnit.Framework;

namespace SupercloneTheoryCore.Tests
{
    [TestFixture]
    public class MultioperationTests
    {
        public MultioperationTests()
        {
        }

        [Test]
        public void MultioperationConstructorTest()
        {
            var multioperationUnary = new MultioperationUnary(10);

            Assert.AreEqual(10, multioperationUnary.DecimalRepresentation);
        }
    }
}
