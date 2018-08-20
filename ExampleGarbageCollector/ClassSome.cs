using System;

namespace ExampleGarbageCollector
{
    internal class ClassSome
    {
        public ClassSome()
        {
            MakeSomeGarbage();
        }

        // Create objects and release them to fill up memory with unused objects.
        private void MakeSomeGarbage()
        {
            for (var i = 0; i < 1000; i++)
            {
                var vt = new Version();
            }
        }
    }
}
