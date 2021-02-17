using System;
using Xunit;

namespace joshford_project0
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(123456)]
        [InlineData(654321)]
        public void Customer_ConstructorTest_CustomerCreated(int value)
        {
            // Arrange
            Customer expected = new Customer(custID: value);

            // Act
            Customer actual = new Customer(custID: 123456);
            Console.WriteLine(actual.CustID);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate1()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate2()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate3()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate4()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate5()
        {
            // Arrange


            // Act


            // Assert


        }

        /// <summary>
        /// 
        /// </summary>
        public void testTemplate6()
        {
            // Arrange


            // Act


            // Assert


        }
    }
}
