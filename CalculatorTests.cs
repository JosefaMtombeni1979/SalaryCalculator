using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestPrject
{
    [TestClass]
    public class CalculatorTests
    {
        /* To get the annual salary test*/


        [TestMethod]
        public void AnnualSalaryTest()
        {

            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
