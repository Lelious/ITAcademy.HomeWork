using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. Явное преобразование типа.

            long Value = 10;
            long longValue = (uint)Value;
            ushort uValue = (ushort)longValue;
            byte byteValue = (byte)uValue;

            //b. Неявное преобразование типа.

            byte byteValue2 = 4;
            ushort uValue2 = byteValue2;
            uint uIntValue = uValue2;
            ulong uLongValue = uIntValue;

            //с. Операция упаковки(Boxing).

            int val = 5;
            object obj = val;
            dynamic d = 1;
            IComparable<int> iComp = 1;

            //d. Операция распаковки(Unboxing).

            int valIcomp = (int)iComp;
            int valUnboxed = (int)obj;
            int valDyn = (int)d;

            // Упаковка int типа и распаковка в ushort тип.

            int vIn = 1;
            object obj1 = vIn;
            ushort vOut = Convert.ToUInt16(obj1);

            // Упаковка bool типа и распаковка в byte тип.

            bool vIn2 = true;
            object obj2 = vIn2;
            byte vOut2 = Convert.ToByte(obj2);

            // Упаковка char типа и распаковка в int тип.

            char vIn3 = '0';
            object obj3 = vIn3;
            int vOut3 = Convert.ToInt32(obj3);



        }
    }
}
