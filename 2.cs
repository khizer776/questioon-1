using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
             var result = new marks();
            result.Subject_1 = 42;
            result.Subject_2 = 50;
            result.Subject_3 = 51;
            result.Sum();
            result.Average();
        }
    }
}
