using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.tipos
{
    public class Inteiros
    {
        public void Executar()
        {
            byte idade = 18;
            Console.WriteLine("Byte");
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            short numeroShort = 256;
            Console.WriteLine("Short");
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            int numeroInteiro = 1234;
            Console.WriteLine("Inteiro");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            long numeroLong = 1234;
            Console.WriteLine("Long");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
        }
    }
}