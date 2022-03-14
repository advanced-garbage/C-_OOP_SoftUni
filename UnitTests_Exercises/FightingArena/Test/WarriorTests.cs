namespace FightingArena.Tests
{
    using NUnit.Framework;
    using FightingArena;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        Warrior warrior;
        string name;
        int dmg;
        int hp;
        const int MIN_DAMAGE = 30;

        [SetUp]
        public void initializeValues()
        {
            name = "Honda";
            dmg = 30;
            hp = 150;
            warrior = new Warrior(name, dmg, hp);
        }

        [Test]
        public void WARRIORCONSTRUCTOR_ObjShouldNotBeNull()
        {
            Assert.That(warrior, Is.Not.Null);
        }

        [Test]
        [TestCase(""), TestCase(null), TestCase(" ")]
        public void NAMEPROP_NameShouldThrowExceptionWhenArgsPassedIsNullOrWhiteSpace(string ex)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(ex, dmg, hp));
        }

        [Test]
        [TestCase(0), TestCase(-50)]
        public void DMGPROP_ShouldThrowExceptionWhenPassedValueIsZeroOrNegative(int value)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, value, hp));
        }

        [Test]
        [TestCase(-1), TestCase(-50)]
        public void HPPROP_ShouldThrowExceptionWhenPassedValueIsNegative(int value)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, dmg, value));
        }

        [Test]
        [TestCase(20), TestCase(1), TestCase(100)]
        public void ATTACK_HPgoesDownWhenAttacked(int dmg)
        {
            int fullHP = warrior.HP;
            var warriorAttacking = new Warrior("Civic", dmg, 100);

            warrior.Attack(warriorAttacking);

            Assert.That(warrior.HP, Is.EqualTo(fullHP - dmg));
        }

        [Test]
        [TestCase(41, 40), TestCase(60, 50)]
        public void ATTACK_PassedObjsHpBecomes0WhenOtherObjsDamageIsHigher(int dmg, int health)
        {
            warrior = new Warrior(name, dmg, hp);
            Warrior warriorAttacking = new Warrior("Civic", 40, health);

            warrior.Attack(warriorAttacking);

            Assert.That(warriorAttacking.HP, Is.EqualTo(0));
        }

        [Test]
        [TestCase(40), TestCase(80), TestCase(120)]
        public void ATTACK_PassedObjsHpDecreasesWhenAttacked(int health)
        {
            Warrior warriorAttacking = new Warrior("Civic", 20, health);

            warrior.Attack(warriorAttacking);

            Assert.That(warriorAttacking.HP, Is.EqualTo(health - warrior.Damage));
        }

        [Test]
        [TestCase(30), TestCase(20), TestCase(10)]
        public void ATTACK_ThrowExceptionWhenHpIsEqualOrLessThanMinAtckValueCase1(int value)
        {
            warrior = new Warrior(name, dmg, value);
            Warrior toAttack = new Warrior("Civic", 10, 100);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(toAttack));
        }

        [Test]
        [TestCase(30), TestCase(20), TestCase(10)]
        public void ATTACK_ThrowExceptionWhenHpIsEqualOrLessThanMinAtckValueCase2(int value)
        {
            warrior = new Warrior(name, dmg, hp);
            Warrior toAttack = new Warrior("Civic", 10, value);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(toAttack));
        }

        [Test]
        [TestCase(50, 60), TestCase(40, 41), TestCase(100, 150)]
        public void ATTACK_ThrowsExceptionWhenHPisLessThanWarriorsDamage(int hp, int dmg)
        {
            warrior = new Warrior(name, dmg, hp);
            Warrior warriorAttacking = new Warrior(name, dmg, hp);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(warriorAttacking));
        }
    }
}