using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Translator
    {

        public static IList<Func<int, string, string>> Rules = new List<Func<int, string, string>>
            {
                Fizzy,
                Buzzy,
                Other
            };

        public static string Translate(int i)
        {
            var returnString = string.Empty;
            foreach (var rule in Rules)
            {
                returnString = rule(i, returnString);
            }

            return returnString;
        }

        private static bool ShouldBuzz(int i)
        {
            return i%5 == 0 || i.ToString().Contains("5");
        }

        private static bool ShouldFizz(int i)
        {
            return i%3 == 0 || i.ToString().Contains("3");
        }

        #region Rules
        
        private static string Fizzy(int i, string returnString)
        {
            return returnString + (ShouldFizz(i) ? "Fizz" : string.Empty);
        }

        private static string Buzzy(int i, string returnString)
        {
            return returnString + (ShouldBuzz(i) ? "Buzz" : string.Empty);
        }

        private static string Other(int i, string returnString)
        {
            return string.IsNullOrEmpty(returnString) ? i.ToString() : returnString;
        }
        
        #endregion
    }
}
