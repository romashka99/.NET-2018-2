using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        class MyString
        {
            private char[] mystring;
            public char[] mString
            {
                get
                {
                    return mystring;
                }
                set
                {
                    if (value[0] == '\0')
                    {
                        throw new Exception("Строка не может быть пустой");
                    }
                    else
                    {
                        for (uint i = 0; i < value.Length; i++)
                            mystring[i] = value[i];
                    }
                }
            }
            private int Length;
            MyString(char[] str)
            {
                mString = str;
                Length = str.Length;
            }

            public static MyString operator + (MyString str1, MyString str2)
            {
                for (uint i = 0; i < str2.Length; i++, str1.Length++)
                {
                    str1.mystring[str1.Length + 1] = str2.mystring[i];
                }
                return str1;
            }

            public static bool operator == (MyString str1, MyString str2)
            {
                if (str1.Length == str2.Length)
                {
                    for (uint i = 0; i < str2.Length; i++)
                    {
                        if (str1.mystring[i] != str2.mystring[i]) return false;
                    }
                    return true;
                }
                else return false;
            }

            public static bool operator != (MyString str1, MyString str2)
            {
                if (str1.Length != str2.Length)
                {
                    for (uint i = 0; i < str2.Length; i++)
                    {
                        if (str1.mystring[i] != str2.mystring[i]) return true;
                    }
                    return false;
                }
                else return true;
            }


            public static MyString operator - (MyString str1, MyString str2)
            {
                string st1 = new string(str1.mString);
                string st2 = new string(str2.mString);
                string pattern = @st2;
                Regex str = new Regex(pattern);
                st1 = str.Replace(st1, String.Empty);
                char[] s = st1.ToCharArray();
                str1.mystring = s;
                return str1;
            }
            public string ToString(MyString mstr)
            {
                string str = String.Empty;
                for (uint i = 0; i < mstr.Length; i++)
                {
                    str = str + mstr.mystring[i];
                }
                return str;
            }


        }
        static void Main(string[] args)
        {
        }
    }
}
