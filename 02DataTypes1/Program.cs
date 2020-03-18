using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DataTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SByte is used for signed byte type range -128 to +127
            sbyte sb = -128;
            Console.WriteLine("Sbyte b = " + sb);
            Console.WriteLine("Minimum value for sbyte is : " + sbyte.MinValue);
            Console.WriteLine("Maximum value for sbyte is : " + sbyte.MaxValue);

            // byte stores only positive numbers its range 0 to 255
            byte b = 255;
            Console.WriteLine("Sbyte b = " + b); // Demo
            Console.WriteLine("Minimum value for byte is : " + byte.MinValue);
            Console.WriteLine("Maximum value for byte is : " + byte.MaxValue);

            short srt = 5000;
            Console.WriteLine("short srt = " + srt);
            Console.WriteLine("Minimum value for short is : " + short.MinValue);
            Console.WriteLine("Maximum value for short is : " + short.MaxValue);

            ushort usrt = 50000;
            Console.WriteLine("ushort usrt = " + usrt);
            Console.WriteLine("Minimum value for ushort is : " + ushort.MinValue);
            Console.WriteLine("Maximum value for ushort is : " + ushort.MaxValue);

            int i = 200;
            Console.WriteLine("int i = " + i);
            Console.WriteLine("Minimum value for int is : " + int.MinValue);
            Console.WriteLine("Maximum value for int is : " + int.MaxValue);

            uint ui = 20000000;
            Console.WriteLine("UInt32 ui = " + ui);
            Console.WriteLine("Minimum value for uint is : " + uint.MinValue);
            Console.WriteLine("Maximum value for uint is : " + uint.MaxValue);

            long l = 2000000000;
            Console.WriteLine("long l = " + l);
            Console.WriteLine("Minimum value for long is : " + long.MinValue);
            Console.WriteLine("Maximum value for long is : " + long.MaxValue);

            ulong ul = 200000000000000;
            Console.WriteLine("long l = " + ul);
            Console.WriteLine("Minimum value for ulong is : " + ulong.MinValue);
            Console.WriteLine("Maximum value for ulong is : " + ulong.MaxValue);

            decimal d = 2000m;
            Console.WriteLine("decimal d = " + d + "m");
            Console.WriteLine("Minimum value for decimal is : " + decimal.MinValue);
            Console.WriteLine("Maximum value for decimal is : " + decimal.MaxValue);

            float f = 10.24f;
            Console.WriteLine("float f = " + f);
            Console.WriteLine("Minimum value for float is : " + float.MinValue);
            Console.WriteLine("Maximum value for float is : " + float.MaxValue);

            double dbl = 100000232.240002;
            Console.WriteLine("double dbl = " + dbl);
            Console.WriteLine("Minimum value for double is : " + double.MinValue);
            Console.WriteLine("Maximum value for double is : " + double.MaxValue);

            char c = 'd';
            Console.WriteLine("char c = " + c);
            Console.WriteLine("Minimum value for char is : " + (int)char.MinValue);
            Console.WriteLine("Maximum value for char is : " + (int)char.MaxValue);

            bool bl = true;
            Console.WriteLine("bool bl = " + bl);

            Console.WriteLine("bool type takes 1 bit");
            Console.WriteLine("byte type takes 1 byte");
            Console.WriteLine("sbyte type takes 1 byte");
            Console.WriteLine("short type takes 2 bytes");
            Console.WriteLine("ushort type takes 2 bytes");
            Console.WriteLine("int type takes 4 bytes");
            Console.WriteLine("uint type takes 4 bytes");
            Console.WriteLine("long type takes 8 bytes");
            Console.WriteLine("ulong type takes 8 bytes");
            Console.WriteLine("decimal type takes 12 bytes");
            Console.WriteLine("float type takes 4 bytes");
            Console.WriteLine("double type takes 8 bytes");
            Console.WriteLine("char type takes 2 bytes");
            // struct, enum
        }
    }
}
