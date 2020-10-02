using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_Values_ToList()
        {
            //Arrange
            CustomList<int> addList = new CustomList<int>();
            int value = 12;
            int expected = 12;
            int actual;

            //Act
            addList.Add(value);
            actual = addList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_Count_OfList()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int valueOne = 12;
            int valueTwo = 13;
            int valueThree = 1;
            int expected = 3;
            int actual;


            //Act
            newList.Add(valueOne);
            newList.Add(valueTwo);
            newList.Add(valueThree);
            actual = newList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_Capacity_OfList()
        {
            //Arrange
            CustomList<int> addList = new CustomList<int>();
            int value = 10;
            int value2 = 5;
            int value3 = 3;
            int expected = 4;
            int actual;


            //Act
            addList.Add(value);
            addList.Add(value2);
            addList.Add(value3);
            actual = addList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Increase_Capacity_OfList()
        {
            //Arrange
            CustomList<int> addList = new CustomList<int>();
            int value = 10;
            int value2 = 5;
            int value3 = 3;
            int value4 = 7;
            int value5 = 9;
            int expected = 8;
            int actual;



            //Act
            addList.Add(value);
            addList.Add(value2);
            addList.Add(value3);
            addList.Add(value4);
            addList.Add(value5);
            actual = addList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Values_FromList()
        {
            CustomList<int> addList = new CustomList<int>();
            int value = 12;
            int valueTwo = 13;
            int valueThree = 14;
            int expected = 13;
            int actual;

            //Act
            addList.Add(value);
            addList.Add(valueTwo);
            addList.Add(valueThree);
            addList.Remove(value);
            actual = addList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_CountOfList_WithRemove()
        {
            CustomList<int> newList = new CustomList<int>();
            int valueOne = 12;
            int valueTwo = 13;
            int valueThree = 14;
            int expected = 1;
            int actual;


            //Act
            newList.Add(valueOne);
            newList.Add(valueTwo);
            newList.Add(valueThree);
            newList.Remove(valueOne);
            newList.Remove(valueTwo);

            actual = newList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_CapacityOfList_WithRemove()
        {
            //Arrange
            CustomList<int> addList = new CustomList<int>();
            int value = 12;
            int valueTwo = 13;
            int valueThree = 14;
            int expected = 4;
            int actual;


            //Act
            addList.Add(value);
            addList.Add(valueTwo);
            addList.Add(valueThree);
            addList.Remove(value);
            addList.Remove(valueTwo);
            actual = addList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        
    }
}
