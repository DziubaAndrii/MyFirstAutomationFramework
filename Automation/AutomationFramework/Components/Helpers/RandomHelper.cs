using System;
using System.Linq;

namespace Framework.Components.Helpers
{
    public static class RandomHelper
    {
        private static Random random = new Random();
        private const string Numbers = "0123456789";
        private const string Alphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string AlphaNumeric = Numbers + Alphabetic;

        public static string CreateRandomString(string text)
        {
           return $"{text}{random.Next(99999)}";
        }
        public static string CreateRandomPhone()
        {
            return $"{+380}{random.Next(100000000, 999999999)}";
        }

        public static string CreateRandomAlphaNumeric(int length)
        {
                return new string(Enumerable.Repeat(AlphaNumeric, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            
        }

        public static string CreateRandomAlphabetic(int length)
        {
            return new string(Enumerable.Repeat(Alphabetic, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
