using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalSize size = new DigitalSize(60000000000000000);
            DigitalSize size1 = size.AddBit(8);

            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.MB);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.TB);

            Console.WriteLine("--------------------------------");

            Console.WriteLine(size1.Bit);
            Console.WriteLine(size1.Byte);
            Console.WriteLine(size1.KB);
            Console.WriteLine(size1.MB);
            Console.WriteLine(size1.GB);
            Console.WriteLine(size1.TB);

            Console.ReadKey();
        }
    }
}
