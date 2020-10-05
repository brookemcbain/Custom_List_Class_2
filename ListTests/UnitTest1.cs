using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Runtime.CompilerServices;

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
            int expected = 12; 
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
        [TestMethod]
        public void Turn_List_IntoString()
        {
            CustomList<int> newList = new CustomList<int>();
            int value = 12;
            string expected = "12"; 
            string actual;

            newList.Add(value);

            actual = value.ToString();    

            Assert.AreEqual(expected, actual); 
        }
        
        [TestMethod]
        public void Turn_MultipleValues_ToString()
        {
            CustomList<int> newList = new CustomList<int>();
            int value = 12;
            int value2 = 3;
            int value3 = 8;
            string expected = "12" + "3" + "8";
            string actual; 
            string actualOne;
            string actualTwo;
            string actualThree; 

            newList.Add(value);
            newList.Add(value2);
            newList.Add(value3);

            actualOne = value.ToString();
            actualTwo = value2.ToString();
            actualThree = value3.ToString();

            actual = actualOne + actualTwo + actualThree;

            Assert.AreEqual(expected, actual); 

        }
        [TestMethod]
        public void Add_TwoList_Together()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int expected = 1 + 2 + 3 + 4;
            int actual;

            listOne.Add(valueOne);
            listOne.Add(valueTwo);
            listTwo.Add(valueThree);
            listTwo.Add(valueFour);

            actual = listOne + listTwo; 


        }
    }
}
