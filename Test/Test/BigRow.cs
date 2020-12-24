using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class BigRow : Rows
    {
        public BigRow(string str): base(str)
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
            base.Sort();
        }
    }
}
