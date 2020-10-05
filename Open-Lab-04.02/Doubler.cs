using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string r = "";
            for (int i = 0; i < original.Length; i++)
            {
                r = r + original[i] + original[i];
            }
            return r;
        }
    }
}
