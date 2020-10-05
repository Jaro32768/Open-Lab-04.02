using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            int length = original.Length;
            string r = "";
            for (int i = 0; i < length; i++)
            {
                r = r + original[i] + original[i];
            }
            return r;
        }
    }
}
