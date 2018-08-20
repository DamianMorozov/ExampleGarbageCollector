using System;
using System.Collections.ObjectModel;

namespace ExampleGarbageCollector
{
    internal class Program
    {
        private static void Main()
        {
            const uint collectionCount = 4;

            // Create objects and release them to fill up memory with unused objects.
            var somes = new Collection<ClassSome>();
            for (int item = 0; item < collectionCount; item++)
            {
                somes.Add(new ClassSome());
                Console.WriteLine(@"somes.Add(new ClassSome());");
            }
            Console.WriteLine();

            // Determine the maximum number of generations the system GC currently supports.
            Console.WriteLine($@"The highest generation is {GC.MaxGeneration}");
            Console.WriteLine($@"GC.GetTotalMemory(false): {GC.GetTotalMemory(false)}");
            Console.WriteLine();

            GC.Collect();
            Console.WriteLine($@"GC.Collect();");
            Console.WriteLine($@"GC.GetTotalMemory(false): {GC.GetTotalMemory(false)}");
            Console.WriteLine();

            Console.Read();
        }
    }
}
