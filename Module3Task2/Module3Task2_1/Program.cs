using System;

using Module3Task2_1;

class Program
{
    static void Main()
    {
        string prefix = "1"; 
        
        for (int i = 0; i < 5; i++)
        {
            string uniqueCode = Helper.GenerateUniqueCode(prefix);
            Console.WriteLine("Generated unique code: " + uniqueCode);
        }

    }
}