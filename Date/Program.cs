using System;

namespace DatenTime
{
    class MyClass
        
        
        
    {
        static void Main(string[] arg)
        {
            DateTime today = new DateTime(2024, 11, 27);
            Console.WriteLine("today: {0}", today);

            TimeSpan lunchTime = new TimeSpan(12, 20, 0);
            Console.WriteLine($"time: {lunchTime}");
        }
    }
}