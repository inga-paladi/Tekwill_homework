using System;
namespace Module3Task2_1
{
    public static class Helper
    {
        private static readonly Random random = new Random();
        public static string GenerateUniqueCode(string prefix)
        {
            string generatedNumber = random.Next(1, 2000).ToString("D4"); // Generates a random number between 1 and 1999 and formats it as a 4-digit number with leading zeros.
            return prefix + generatedNumber;
        }
    }
}
