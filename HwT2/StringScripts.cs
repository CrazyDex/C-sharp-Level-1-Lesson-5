using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HwT2
{
    class StringScripts
    {
        public static void NCharWords(string str, int n)
        {
            string pat = @"^[a-zA-Z][a-zA-Z]{0," + (n-1) + @"}\b";
            string[] ostr = Regex.Split(str, @"\s");
            for (int i = 0; i < ostr.Length; i++)
            {
                if (Regex.IsMatch(ostr[i], pat))
                {
                    Console.WriteLine(ostr[i]);
                }
            }
        }

        public static void DelWordsEndN(ref string str, string n)
        {
            string patIsWord = @"^[a-zA-Z][a-zA-Z]*\b";
            string patEnd = @"[" + n + @"]$";
            string[] ostr = Regex.Split(str, @"\s");
            str = "";
            for (int i = 0; i < ostr.Length; i++)
            {
                if (Regex.IsMatch(ostr[i], patIsWord) != true)
                {
                    str += " " + ostr[i];
                }
                else
                { 
                    if (Regex.IsMatch(ostr[i], patEnd) != true)
                    {
                        str += " " + ostr[i];
                    }
                }
            }
            str = str.Remove(0, 1);
        }

        public static string BiggestWord(string str)
        {
            string patIsWord = @"^[a-zA-Z][a-zA-Z]*\b";
            string[] ostr = Regex.Split(str, @"\s");
            str = "";
            for (int i = 0; i < ostr.Length; i++)
            {
                if (Regex.IsMatch(ostr[i], patIsWord)) { str = ostr[i].Length > str.Length ? ostr[i] : str; }
            }
            return str;
        }

        public static string AllBiggestWord(string str)
        {
            string temp = BiggestWord(str);
            string patIsWord = @"^[a-zA-Z][a-zA-Z]*\b";
            string[] ostr = Regex.Split(str, @"\s");
            str = "";
            for (int i = 0; i < ostr.Length; i++)
            {
                if (Regex.IsMatch(ostr[i], patIsWord)) { str += ostr[i].Length == temp.Length ? " " + ostr[i] : ""; }
            }
            str = str.Remove(0, 1);
            return str;
        }
    }
}
