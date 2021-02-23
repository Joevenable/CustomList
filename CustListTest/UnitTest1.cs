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
        public void Test2_Add_FiveItemUnitListStartingCapacity()
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
        public void Test3_Add_Item_CountIncreasesByNineCapacity()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();


            int expected = 16;
            int actual;

            //act

            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");
            customListStrings.Add("flower");
            customListStrings.Add("bark");
            customListStrings.Add("car");
            customListStrings.Add("window");
            actual = customListStrings.Capacity;


            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4_Add_FiveItemUnitList_ItemIndex()
        {
            //arrange
            CustomList<string> customListStrings = new CustomList<string>();

            string expected = "Grape";
            string actual;

            //act
            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");
            actual = customListStrings[3];


            //assert

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test_Remove_ItemUnitListEndCount()
        //{
        //    //arrange
        //    CustomList<string> customListStrings = new CustomList<string>();

        //    int expected = 4;
        //    int actual;

        //    //act
        //    customListStrings.Add("Tree");
        //    customListStrings.Add("Bush");
        //    customListStrings.Add("Shrub");
        //    customListStrings.Add("Grape");
        //    customListStrings.Add("Leaf");
        //    customListStrings.Remove("Bush");
        //    actual = customListStrings.Count;


        //    //assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Test2_Remove_ItemUnitListEndCapacity()
        //{
        //    //arrange
        //    CustomList<string> customListStrings = new CustomList<string>();

        //    int expected = 8;
        //    int actual;

        //    //act
        //    customListStrings.Add("Tree");
        //    customListStrings.Add("Bush");
        //    customListStrings.Add("Shrub");
        //    customListStrings.Add("Grape");
        //    customListStrings.Add("Leaf");
        //    customListStrings.Remove("Bush");
        //    customListStrings.Remove("Tree");
        //    actual = customListStrings.Capacity;


        //    //assert

        //    Assert.AreEqual(expected, actual);
        //}

        

        //[TestMethod]
        //public void Test3_Remove_ItemUnitListEndCapacity()
        //{
        //    //arrange
        //    CustomList<string> customListStrings = new CustomList<string>();

        //    int expected = 8;
        //    int actual;

        //    //act
        //    customListStrings.Add("Tree");
        //    customListStrings.Add("Bush");
        //    customListStrings.Add("Shrub");
        //    customListStrings.Add("Grape");
        //    customListStrings.Add("Leaf");
        //    customListStrings.Remove("Bush");
        //    customListStrings.Remove("Tree");
        //    actual = customListStrings.Capacity;


        //    //assert

        //    Assert.AreEqual(expected, actual);
        //}
    }
}
