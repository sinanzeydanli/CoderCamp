using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value types: int, decimal, float, double, bool
            int value1 = 10;
            int value2 = 30;
            value1 = value2;
            value2 = 65;
            //value1 equals to 30

            //Reference types: array, class, interface
            int[] values1 = new int[] { 10, 20, 30 };
            int[] values2 = new int[] { 100, 200, 300 };
            values1 = values2;
            values2[0] = 999;
            //values1[0] equals to 999

            //stack & heap concepts
            // Value types work on stack concept, while reference types work on heap

        }
    }
}
