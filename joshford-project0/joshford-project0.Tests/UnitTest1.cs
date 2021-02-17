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
        public void testTemplate()
        {
            // Arrange


            // Act


            // Assert


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
        public void testTemplate()
        {
            // Arrange


            // Act


            // Assert


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
        public void testTemplate()
        {
            // Arrange


            // Act


            // Assert


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
    }
}
