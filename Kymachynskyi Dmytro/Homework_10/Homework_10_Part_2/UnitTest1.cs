using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework_4;

namespace PersonUnitTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Person_WOParams_Undefined_01d01d1900()
        {
            //Arrange
            string name = "Undefined";
            DateTime birthYear = Convert.ToDateTime("01.01.1900");
            Person expected = new Person(name, birthYear);

            //Actual
            Person actual = new Person();
            
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.BirthYear, actual.BirthYear);
        }
        [TestMethod]
        public void Age_John02d03d1987_25()
        {
            //Arrange
            string name = "John";
            DateTime birthYear = Convert.ToDateTime("02.03.1987");
            int expected = 35;

            //Actual
            Person testPerson = new Person(name, birthYear);
            int actual = testPerson.Age(testPerson);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChangeName_John05d06d2016_Very_Young()
        {
            //Arrange
            string name = "John";
            DateTime birthYear = Convert.ToDateTime("05.06.2016");
            string expected = "Very young";

            //Actual
            Person testPerson = new Person(name, birthYear);
            testPerson.ChangeName(testPerson);
            string actual = testPerson.Name;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_James07d09d2002_stringNameAge()
        {
            //Arrange
            string expected = "Person name: James age: 20";
            string name = "James";
            DateTime birthYear = Convert.ToDateTime("07.12.2002");

            //Actual
            Person testPerson = new Person(name, birthYear);
            string actual = testPerson.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EqualOperator_JohnCompareJohn_true()
        {
            //Arrange
            bool expected = true;
            string name1 = "John";
            string name2 = "John";
            DateTime birthYear1 = Convert.ToDateTime("07.09.2002");
            DateTime birthYear2 = Convert.ToDateTime("09.10.1978");

            //Actual
            Person testPerson1 = new Person(name1, birthYear1);
            Person testPerson2 = new Person(name2, birthYear2);
            bool actual = testPerson1 == testPerson2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void NotEqualOperator_JohnCompareJames_true()
        {
            //Arrange
            bool expected = true;
            string name1 = "John";
            string name2 = "James";
            DateTime birthYear1 = Convert.ToDateTime("07.09.2002");
            DateTime birthYear2 = Convert.ToDateTime("09.10.1978");

            //Actual
            Person testPerson1 = new Person(name1, birthYear1);
            Person testPerson2 = new Person(name2, birthYear2);
            bool actual = testPerson1 != testPerson2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}