using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike sb = new SportBike();
            sb.MaxSpeedPublic = 150;        //OnlyOneField.
        }
    }
}