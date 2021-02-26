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

        [TestMethod]
        public void Test_Remove_ItemUnitListEndCount()
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

        [TestMethod]
        public void Test2_Remove_ItemUnitListEndCapacity()
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
            customListStrings.Remove("Bush");
            customListStrings.Remove("Tree");
            actual = customListStrings.Capacity;


            //assert

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Test3_Remove_ItemUnitListEndCapacity()
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
            customListStrings.Remove("Bush");
            customListStrings.Remove("Tree");
            actual = customListStrings.Capacity;


            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_Test_()
        {
            CustomList<string> customListStrings = new CustomList<string>();

            customListStrings.Add("Tree");
            customListStrings.Add("Bush");
            customListStrings.Add("Shrub");
            customListStrings.Add("Grape");
            customListStrings.Add("Leaf");

            // This line is not needed because the ToString method is going to handle
            // turning each value into a string
            // string plants = new string(customListStrings[i]);

            string expected = "Tree Bush Shrub Grape Leaf";
            // Here we are calling the ToString method on the customListStrings list
            // The ToString method should then return all of the values in the list in a string format
            string actual = customListStrings.ToString();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ToString_Test2_()
        {
            CustomList<int> customListStrings = new CustomList<int>();

            customListStrings.Add(1);
            customListStrings.Add(6);
            customListStrings.Add(2);
            customListStrings.Add(3);
            customListStrings.Add(5);

           

            string expected = "1 6 2 3 5";
            
            string actual = customListStrings.ToString();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Plus_Operator()
        {
            CustomList<int> customListStrings = new CustomList<int>();
            CustomList<int> customListStrings2 = new CustomList<int>();
            customListStrings.Add(1);
            customListStrings.Add(6);
            customListStrings.Add(2);
            customListStrings.Add(3);
            customListStrings.Add(5);
            customListStrings2.Add(3);
            customListStrings2.Add(12);
            customListStrings2.Add(8);
            customListStrings2.Add(8);

            string sum = customListStrings[1].ToString() + customListStrings2[1].ToString();

            
            string expected = "612";

            string actual = sum;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test2_Plus_Operator()
        {
            CustomList<int> customListStrings = new CustomList<int>();
            CustomList<int> customListStrings2 = new CustomList<int>();
            customListStrings.Add(1);
            customListStrings.Add(6);
            customListStrings.Add(2);
            customListStrings.Add(3);
            customListStrings.Add(5);
            customListStrings2.Add(3);
            customListStrings2.Add(8);
            customListStrings2.Add(7);
            customListStrings2.Add(12);
            customListStrings.Remove(2);
            customListStrings2.Remove(8);

            string sum = customListStrings[2].ToString() + customListStrings2[2].ToString() + customListStrings[0].ToString();


            string expected = "3121";

            string actual = sum;
            Assert.AreEqual(expected, actual);

        }
    }
}


