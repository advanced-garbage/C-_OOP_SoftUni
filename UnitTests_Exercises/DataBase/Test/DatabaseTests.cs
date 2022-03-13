namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        [TestCase(3)]
        [TestCase(15)]
        [TestCase(0)]
        public void AddShouldWorkWithLessThan16Elements(int count)
        {
            Database db = new Database();

            for (int i = 0; i < count; i++)
            {
                db.Add(i);
            }

            Assert.AreEqual(count, db.Count);
        }

        [Test]
        public void AddShouldThrowExceptionWhenCountIsBiggerThan16()
        {
            Database db = new Database();

            for (int i = 0; i < 16; i++)
            {
                db.Add(i + i * 2);
            }

            var ex = Assert.Throws<InvalidOperationException>(() => db.Add(5));
            // "Array's capacity must be exactly 16 integers!"
            Assert.AreEqual(ex.Message, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        [TestCase(1, 15)]
        public void ConstructorShouldAddItemsWhenTheyHaventReachedCapacity(int start, int end)
        {
            int[] elements = Enumerable.Range(start, end).ToArray();

            var db = new Database(elements);

            Assert.IsTrue(db.Count == 15);
        }

        [Test]
        public void CountDropsWhenAnItemIsRemoved()
        {
            var db = new Database(1, 2, 3); // db.Count == 3

            db.Remove();

            Assert.IsTrue(db.Count == 2);
        }

        [Test]
        public void RemoveMethodThrowsExceptionWhenCollectionIsEmpty()
        {
            var db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void FetchReturnsAnExactCopy()
        {
            int[] elements = Enumerable.Range(1, 10).ToArray();
            Database db = new Database(elements);

            int[] copyArr = new int[db.Count];
            copyArr = db.Fetch();

            Assert.AreEqual(elements, copyArr);
        }

    }
}
