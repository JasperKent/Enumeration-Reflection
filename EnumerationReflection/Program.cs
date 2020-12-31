using System;

namespace EnumerationReflection
{
    class Program
    {
        static void Main()
        {
            foreach (var c in Callsigns.All)
            {
                Console.WriteLine(c);
            }
        }
    }
}
