namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        Database db = null;
        [SetUp]
        public void InitializeDatabase()
        {
            db = new Database();
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)] 
        [TestCase(16)]
        public void COUNT_check(int count)
        {
            for (int i = 0; i < count; i++)
            {
                db.Add(new Person((1 + i) * 2, $"Obj{i + 1}"));
            }

            Assert.AreEqual(count, db.Count);
        }

        [Test]
        public void CONSTRUCTOR_ShouldInitializeCollection()
        {
            Assert.That(db, Is.Not.Null);
        }

        [Test]
        [TestCase(17)]
        public void CONSTRUCTOR_ShouldThrowExceptionWhenItReachesMaxCount(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == 16)
                {
                    Assert.Throws<InvalidOperationException>(() => db.Add(new Person(1111, "haha")));
                } else {
                    db.Add(new Person(i + 1, $"Obj{i + 1}"));
                }
            }
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(16)]
        public void ADD_ShouldWorkWhenBelowMaxCapacity(int count)
        {
            for (int i = 0; i < count; i++)
            {
                db.Add(new Person(i + 1, $"PersonObj{i}"));
            }

            Assert.AreEqual(count, db.Count);
        }

        [Test]
        public void ADD_CountIncrementsWhenAddingAPerson()
        {
            db = new Database(new Person(12412, "Gosh"));
            int ogCount = db.Count; // 1
            db.Add(new Person(53232, "hsoG"));
            Assert.IsTrue(db.Count == ogCount + 1);
        }

        [Test]
        [TestCase(149322, "John")]
        [TestCase(555, "FiveFiveFive")]
        [TestCase(1512121, "Jenny")]
        public void ADD_ThrowsExceptionWhenAddingObjsWithSameUsernames(long id, string name)
        {
            Person p1 = new Person(id, name);
            Person p2 = new Person(251, name);

            var ex = Assert.Throws<InvalidOperationException>(() => new Database(p1, p2));
            Assert.AreEqual(ex.Message, "There is already user with this username!");
        }

        [Test]
        [TestCase(149322, "John")]
        [TestCase(555, "FiveFiveFive")]
        [TestCase(1512121, "Jenny")]
        public void ADD_ThrowsExceptionWhenAddingObjsWithSameID(long id, string name)
        {
            Person p1 = new Person(id, name);
            Person p2 = new Person(id, "Always Unique");

            var ex = Assert.Throws<InvalidOperationException>(() => new Database(p1, p2));
            Assert.AreEqual(ex.Message, "There is already user with this Id!");
        }

        [Test]
        [TestCase(17)]
        [TestCase(20)]
        [TestCase(32)]
        public void ADDRANGE_ThrowsExceptionWhenCapacityIsGreaterThan16(int count)
        {
            var people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                long id = i + 1 + i * 3;
                string userName = $"Name {i + 1}";
                people.Add(new Person(id, userName));
            }

            Assert.Throws<ArgumentException>(() => new Database(people.ToArray()));
        }

        [Test]
        public void REMOVE_ThrowsExceptionWhenCollectionIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        [TestCase(121, "person1", 12516, "person2")]
        public void REMOVE_CountDropsWhenAnItemIsRemoved(long id1, string name1, long id2, string name2)
        {
            var p1 = new Person(id1, name1);
            var p2 = new Person(id2, name2);
            var db = new Database(p1, p2);
            int ogCount = db.Count;

            db.Remove();

            Assert.IsTrue(db.Count == ogCount - 1);
        }

        [Test]
        [TestCase("Steve-O")]
        [TestCase("Okay fuck this")]
        public void FINDBYUSERNAME_ShouldWorkWhenPassedArgsExists(string name)
        {
            Person personToTest = new Person(982387, name);
            db.Add(personToTest);

            Assert.AreEqual(db.FindByUsername(name), personToTest);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void FINDBYUSERNAME_ThrowsExceptionWhenArgsIsNullOrEmpty(string exception)
        {
            var person = new Person(12512, "Steve");
            db = new Database(person);

            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(exception));
        }

        [Test]
        [TestCase("Nowhere to be found")]
        [TestCase("Simply isn't here")]
        [TestCase("Long gone")]
        public void FINDBYUSERNAME_ThrowsExceptionWhenSpecifiedArgsDoesntExist(string name)
        {
            var p1 = new Person(152512, "George");
            var p2 = new Person(1512, "Steve");
            db = new Database(p1, p2);

            Assert.Throws<InvalidOperationException>(() => db.FindByUsername(name));
        }

        [Test]
        [TestCase("George")]
        [TestCase("STEVE")]
        public void FINDBYUSERNAME_ThrowsExceptionSinceMethodIsCaseSensetive(string name)
        {
            var p1 = new Person(12, name);
            db = new Database(p1);

            Assert.Throws<InvalidOperationException>(() => db.FindByUsername(name.ToLower()));
        }

        [Test]
        [TestCase(38883838)]
        [TestCase(10101010)]
        [TestCase(2010)]
        public void FINDBYID_ShouldWorkWhenPassedArgsExists(long id)
        {
            var person = new Person(id, "Name");
            db.Add(person);

            Assert.AreEqual(db.FindById(id), person);
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-1251)]
        public void FINDBYID_ThrowsExceptionIfIdIsNegative(long negativeNum)
        {
            var person = new Person(121, "ppp");
            db = new Database(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(negativeNum));
        }

        [Test]
        [TestCase(121)]
        [TestCase(12124)]
        [TestCase(9649)]
        public void FINDBYID_ThrowsExceptionWithNonexistentFID(long falseID)
        {
            var person = new Person(falseID, "Petyo");
            var db = new Database(person);

            Assert.Throws<InvalidOperationException>(() => db.FindById(falseID + 1));
        }
    }
}