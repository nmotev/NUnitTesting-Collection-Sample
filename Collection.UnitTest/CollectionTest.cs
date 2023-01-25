

namespace Collection.UnitTest
{
    public class CollectionTests
    {
        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arrange and Act
            var coll = new Collection<int>();
            //Assert
            Assert.AreEqual(coll.ToString(), "[]");

            Assert.AreEqual(coll.Count, 0);
            Assert.AreEqual(coll.Capacity, 16);
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            //Arrange and Act
            var coll = new Collection<int>(5);

            var actual = coll.ToString();
            var expected = "[5]";

            //Assert
            Assert.AreEqual(expected, actual);
         }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            //Arrange and Act
            var coll = new Collection<int>(5, 6);
            //Assert
            Assert.AreEqual(coll.ToString(), "[5, 6]");

        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            //Arrange and Act
            var coll = new Collection<int>(5, 6);
            //Assert
            Assert.AreEqual(coll.Count, 2, "Check for count");
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));

        }
        [Test]
        public void Test_Collection_Add()
        {
            //Arrange
            var coll = new Collection<string>("Ivan", "Peter");
            //Act
            coll.Add("Gosho");
            //Assert
            Assert.AreEqual(coll.ToString(), "[Ivan, Peter, Gosho]");

        }
        [Test]
        public void Test_Collection_GetByIndex()
        {
            //Arrange and Act
            var coll = new Collection<int>(5, 6, 7);
            var item = coll[1];
            //Assert
            Assert.That(item.ToString, Is.EqualTo("6"));

        }
        [Test]
        public void Test_Collection_SetByIndex()
        {
            //Arrange and Act
            var coll = new Collection<int>(5, 6, 7);
            coll[1] = 666;
            //Assert
            Assert.That(coll.ToString, Is.EqualTo("[5, 666, 7]"));

        }
    }
}