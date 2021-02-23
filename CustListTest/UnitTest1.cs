using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustList;

namespace CustListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EmptyUnitListStartingCapacity()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();

            int expected = 4;
            int actual;

            //act

            actual = customListStrings.Capacity;


            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Add_Item_CountIncreasesByOne()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();

            
            int expected = 5;
            int actual;

            //act

            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");
            actual = customListStrings.Count;


            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_FiveItemUnitListStartingCapacity()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();

            int expected = 8;
            int actual;

            //act
            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");
            actual = customListStrings.Capacity;


            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_RemoveItemUnitListEndCount()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();

            int expected = 4;
            int actual;

            //act
            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");
            customListStrings.Remove("Bush");
            actual = customListStrings.Count;


            //assert

            Assert.AreEqual(expected, actual);
        }

    }
}
