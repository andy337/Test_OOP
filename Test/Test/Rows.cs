using System;

namespace Test
{
    class Rows
    {
        private string str;

        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        public Rows(string str)
        {
            this.str = str;
        }

        public virtual int Len()
        {
            return str.Length;
        }

        public override string ToString()
        {
            return str;
        }

        public virtual void Sort()
        {
            char[] temp = new char[str.Length];
            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = str[i];
            }

            char t;
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i + 1; j < str.Length; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
                Console.Write(temp[i]);
            }
            str = new string(temp);
            Console.WriteLine();
        }
    }
}
