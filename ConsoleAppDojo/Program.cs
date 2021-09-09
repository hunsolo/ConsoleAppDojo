

namespace ConsoleAppDojo
{
    using System;
    using System.Buffers;

    class Program
    {
        static void Main(string[] args)
        {
            var d = new System.Buffers.ArrayBufferWriter<int>();
            const int z = 16;
            double y = 10 + 3;
            var x = z * y;
            Console.WriteLine("Hello: " + x.ToString());

        }
    }
}
