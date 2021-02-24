using System;
using Xunit;

namespace joshford_project0
{
    public class Project0_Unit_Tests
    {
        [Fact]
        public void Employee_IDValidationTest_EmployeeIDValid()
        {
            // Arrange
            EmployeeC employee = new EmployeeC(1, 1);
            EmployeeValidate validation = new EmployeeValidate();

            // Act
            int employeeActualID = 1;
            EmployeeValidate validationActualID = new EmployeeValidate();

            // Assert
            Assert.Equal(validation.ValidateID(employee.EmployeeID), validationActualID.ValidateID(employeeActualID));
        }

        [Fact]
        public void testTemplate()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate1()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate2()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate3()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate4()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate5()
        {
            // Arrange


            // Act


            // Assert


        }

        [Fact]
        public void testTemplate6()
        {
            // Arrange


            // Act


            // Assert


        }
    }
}
