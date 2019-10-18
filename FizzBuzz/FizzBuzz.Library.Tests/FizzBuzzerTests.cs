using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2, 4, 7, 8)]int input)
        {
            //Act
            string Output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual(input.ToString(), Output);
        }
        [Test]
        public void Buzzer_WhenDiv3_ReturnFizz([Values(3, 6, 9)] int input)
        {
            //Act
            string Output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", Output);
        }
        [Test]
        public void Buzzer_When5_ReturnBuzz([Values(5, 10)] int input)
        {
            //Act
            string Output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", Output);
        }
        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnFizzBuzz([Values(15)] int input)
        {
            //Act
            string Output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("FizzBuzz", Output);
        }
    }
}
