using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    partial class Program
    {
        static string TextWithoutPunctuation(string temp)
        {
            string pattern1 = @"[-.?!)(,:]";
            Regex Comment1 = new Regex(pattern1);
            return temp = Comment1.Replace(temp, String.Empty);
        }
        static ListWords Words(string temp)
        {
            string[] word = temp.Split(new char[] { ' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            ListWords list = new ListWords();
            for (int i = 0; i < word.Length; i++)
            { 
                list.ShapeList(word[i]);
            }
            return list;
        }

        static void Main(string[] args)
        {
           
        }

    }
}
