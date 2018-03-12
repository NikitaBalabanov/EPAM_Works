using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_4
{
    class MyString
    {
        public char[] Str;

        public MyString (char[] str)
        {
            if (str.Length != 0)
            {
                //this.Str = str.ToCharArray;
                this.Str = str;
                //Longer = str.Length;
            }
        }
        public static MyString operator +(MyString c1, MyString c2)
        {
            char[] NewArrey = new char[c1.Str.Length+c2.Str.Length];
            NewArrey = c1.Str;
            for (int i = c1.Str.Length; i < c2.Str.Length; i++)
            {
                NewArrey[i] = c2.Str[i];
            }
            return new MyString(NewArrey);
        }
        public static MyString operator -(MyString c1, MyString c2)
        {
            char[] NewArrey = new char[c1.Str.Length + c2.Str.Length];
            NewArrey = c1.Str;
            for (int i = c1.Str.Length; i < c2.Str.Length; i++)
            {
                NewArrey[i] = c2.Str[i];
            }
            return new MyString(NewArrey);
        }
        ////(-?)|(\+?)[0-9]+(\.?[0-9]+)?
    }
}
