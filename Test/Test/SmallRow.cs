using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class SmallRow : Rows
    {
        public SmallRow(string str) : base(str)
        {

        }

        public override int Len()
        {
            return base.Len();
        }

        public override string ToString()
        {
            return Str;
        }

        public override void Sort()
        {
            char[] temp = new char[Str.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = Str[i];
            }

            char t;
            for (int i = 0; i < Str.Length; i++)
            {
                for (int j = i + 1; j < Str.Length; j++)
                {
                    if (temp[i] < temp[j])
                    {
                        t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
                Console.Write(temp[i]);
            }
            Console.WriteLine();
            Str = new string(temp);
        }
    }
}
