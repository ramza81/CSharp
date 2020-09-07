using System;

namespace DotNet.Ch06_NumberDataType.Sub02_SignedInteger
{
    class SignedInteger
    {
        static void Main(string[] args)
        {
            sbyte sb = 127;
            short st = 32767;
            int i = Int32.MaxValue;
            long l = Int64.MaxValue;

            System.Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);
        }
    }
}