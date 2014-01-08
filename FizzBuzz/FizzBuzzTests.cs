using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //[Test]
        //public void TranslateOne()
        //{
        //    string result = Translator.Translate(1);
        //    Assert.That(result, Is.EqualTo("1"));
        //}

        //[Test]
        //public void TranslateTwo()
        //{
        //    string result = Translator.Translate(2);
        //    Assert.That(result, Is.EqualTo("2"));
        //}

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(23, "Fizz")]
        [TestCase(31, "Fizz")]
        [TestCase(51, "FizzBuzz")]
        [TestCase(52, "Buzz")]
        public void Translate(int input, string expected)
        {
            string result = Translator.Translate(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}