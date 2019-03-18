using System;

namespace AutomationFramework.Components.Helpers
{
    public class Utils
    {
        static Random random = new Random();

        public static string CreateRandomString(string text)
        {
           return $"{text}{random.Next(99999)}";
        }
        public static string CreateRandomPhone()
        {
            return $"{+380}{random.Next(100000000, 999999999)}";
        }

        public static T GetUniqueEnumValue<T>()
        {
            var value = Enum.GetValues(typeof(T));

            return (T)value.GetValue(new Random().Next(value.Length));
        }
    }
}
