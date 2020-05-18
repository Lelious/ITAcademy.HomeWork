using System;
using System.Collections;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            sbyte valSbyte1 = 1;
            list.Add(valSbyte1);
            System.SByte valSbyte2 = 6;
            list.Add(valSbyte2);

            short valShort1 = 9;
            list.Add(valShort1);
            System.Int16 valShort2 = 13;
            list.Add(valShort2);

            int valInt1 = 0;
            list.Add(valInt1);
            System.Int32 valInt2 = 0;
            list.Add(valInt2);

            long valLong1 = 30;
            list.Add(valLong1);
            System.Int64 valLong2 = 28;
            list.Add(valLong2);

            byte valByte1 = 3;
            list.Add(valByte1);
            System.Byte valByte2 = 14;
            list.Add(valByte2);

            ushort valUshort1 = 16;
            list.Add(valUshort1);
            System.UInt16 valUshort2 = 22;
            list.Add(valUshort2);

            char valChar1 = 'A';
            list.Add(valChar1);
            System.Char valChar2 = 'B';
            list.Add(valChar2);

            uint valUint1 = 10;
            list.Add(valUint1);
            System.UInt32 valUint2 = 19;
            list.Add(valUint2);

            ulong valUlong1 = 21;
            list.Add(valUlong1);
            System.UInt64 valUlong2 = 64;
            list.Add(valUlong2);

            float valFloat1 = 0.4F;
            list.Add(valFloat1);
            System.Single valFloat2 = 0.7F;
            list.Add(valFloat2);

            double valDouble1 = 2.4;
            list.Add(valDouble1);
            System.Double valDouble2 = 3.9;
            list.Add(valDouble2);

            decimal valDecimal1 = 3.8948564M;
            list.Add(valDecimal1);
            System.Decimal valDecimal2 = 3.89485540544M;
            list.Add(valDecimal2);

            foreach (var item in list)
            {
                Console.WriteLine(item.GetType());
            }
        }

        
    }
}
