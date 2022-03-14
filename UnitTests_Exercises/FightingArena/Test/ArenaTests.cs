namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        Arena arena;
        [SetUp]
        public void InitializeArena()
        {
            arena = new Arena();
        }

        [Test]
        public void CONSTRUCTOR_ObjIsNotNull()
        {
            Assert.IsNotNull(arena);
        }

        [Test]
        [TestCase(3), TestCase(6), TestCase(0)]
        public void COUNT_GetsHigherWhenAddingElements(int loopIterations)
        {
            int countToTest = arena.Count;
            Assert.AreEqual(0, countToTest);

            for (int i = 0; i < loopIterations; i++)
            {
                Warrior warrior = new Warrior($"#{i+1}", 50, 200);
                arena.Enroll(warrior);
            }

            countToTest = arena.Count;
            Assert.AreEqual(countToTest, arena.Count);
        }

        [Test]
        public void ENROLL_AddingObjsIsSuccessful()
        {
            Assert.IsEmpty(arena.Warriors);

            arena.Enroll(new Warrior("Test", 20, 100));

            Assert.IsNotEmpty(arena.Warriors);
        }

        [Test]
        [TestCase("John L")]
        [TestCase("Jazzboys")]
        public void ENROLL_ThrowsExceptionWhenAddingObjsWithSameName(string name)
        {
            arena.Enroll(new Warrior(name, 12, 60));

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior(name, 64, 77)));
        }

        [Test]
        [TestCase(""), TestCase("IsNull")]
        public void FIGHT_ThrowsExceptionWhenOneOfTheTwoPassedObjsDoesntExist(string name)
        {
            Warrior w1 = new Warrior("Not null", 12, 75);
            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(name, "Not null"));
        }

        [Test]
        [TestCase("John L", "Jazzboys"), TestCase("One", "Two")]
        public void FIGHT_WorksWhenBothObjsExist(string name1, string name2)
        {
            int w2_hp = 250;
            Warrior w1 = new Warrior(name1, 30, 200);
            Warrior w2 = new Warrior(name2, 10, w2_hp);
            arena.Enroll(w1);
            arena.Enroll(w2);

            arena.Fight(name1, name2);

            Assert.That(w2.HP, Is.EqualTo(w2_hp - w1.Damage));
        }
    }
}
