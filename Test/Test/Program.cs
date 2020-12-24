using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "dcab";
            string str_b = "HGJVBNVSG";
            string str_s = "kjksjdckwejkw";


            Rows row = new Rows(str);
            Console.WriteLine(row);
            Console.WriteLine(row.Len());
            row.Sort();
            Console.WriteLine();

            BigRow row_b = new BigRow(str_b);
            Console.WriteLine(row_b);
            Console.WriteLine(row_b.Len());
            row_b.Sort();
            Console.WriteLine();

            SmallRow row_s = new SmallRow(str_s);
            Console.WriteLine(row_s);
            Console.WriteLine(row_s.Len());
            row_s.Sort();
            Console.WriteLine();
        }
    }
}
