

namespace Tests_Dummy
{
    [TestFixture]
    public class DummyTests
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
        public void DummyLosesHealthIfAttacked()
        {
            this.dummy.TakeAttack(axe.AttackPoints);
            int expectedResult = 0;

            Assert.That(this.dummy.Health, Is.EqualTo(expectedResult), "Dummy Health doesn't change ater take attack.");
        }

        [Test]
        public void DeadDummyThrowsAnExceptionIfAttacked()
        {
            this.dummy = CreateDeadDummy();
            Assert.That(() => dummy.TakeAttack(axe.DurabilityPoints),Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            this.dummy = CreateDeadDummy();

            int expectedXP = 10;
            Assert.That(this.dummy.GiveExperience(),Is.EqualTo(expectedXP),$"Dummy is dead then it can give XP.");
        }

        [Test]
        public void AliveDummyCanNotGiveXP()
        {
            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }

        private Dummy CreateDeadDummy()
            => new Dummy(-1, 10);
    }
}