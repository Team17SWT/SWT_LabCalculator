using NUnit.Framework;
using System;

namespace Calculator.Unit.Test
{
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_AddTwoNumbers_Is7point5()
        {
            //Arrange -- Look at SetUp

            //Act
            var result = uut.Add(5, 2.5);

            //Assert
            Assert.That(result, Is.EqualTo(7.5));
        }

        [Test]

        public void Add_AddTwoMinusNumbers_IsMinus11()
        {
            //Arrange -- Look at SetUp

            //Act

            var result = uut.Add(-5, -6);

            //Assert
            Assert.That(result, Is.EqualTo(-11));
        }

        [Test]

        public void Add_AddTwoNumbers_Is25()
        {
            //Arrange -- Look at SetUp

            //Act

            var result = uut.Add(10, 15);

            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void Subtract_SubtractTwoNumbers_Is2()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Subtract(5, 3);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Multiply_MultiplyTwoNumbers_Is56()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Multiply(7, 8);

            //Assert
            Assert.That(result, Is.EqualTo(56));
        }
        [Test]
        public void Multiply_PowerANumber_Is25()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Power(5, 2);

            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]

        public void Add_CheckAccumulator_CorrectAmount()
        {

            // Act

            uut.Add(5, 5);
            uut.Add(10, 10);

            // Assert

            Assert.That(uut.Accumulator,Is.EqualTo(20));
        }

        

        [Test]
        public void Divide_DivideTwoNumbers_Is3()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Divide(6, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            //Arrange -- Look at setup

            //act

            //Assert
            Assert.That(() => uut.Divide(7,0), Throws.TypeOf<DivideByZeroException>());

        }
    }
}