using System;
using NUnit.Framework;

namespace AxeTests
{
    [TestFixture]
    public class TestsAxe
    {

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void CreateAxeAndDummy()
        {
            this.axe = new Axe(10, 10);
            this.dummy = new Dummy(10, 10);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            this.axe.Attack(this.dummy);
            int expectedResult = 9;

            Assert.That(this.axe.DurabilityPoints, Is.EqualTo(expectedResult), "Axe Durability doesn't change ater attack.");
        }

        [Test]
        public void TestingAttackWithBrokenAxe()
        {
            Assert.That(() => new Axe(10, -10).Attack(this.dummy), Throws.Exception.With.Message.EqualTo("Axe is broken."));
        }

    }

   
}
