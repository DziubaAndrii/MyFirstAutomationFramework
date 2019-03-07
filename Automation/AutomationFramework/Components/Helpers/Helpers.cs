using System;

namespace Framework.Components.Helpers
{
    public static class Helpers
    {

        public static string CreateRandomString(string text)
        {
           return $"{text}{new Random().Next(99999)}";
        }
        public static string CreateRandomPhone()
        {
            return $"{+380}{new Random().Next(100000000, 999999999)}";
        }

    }
}
