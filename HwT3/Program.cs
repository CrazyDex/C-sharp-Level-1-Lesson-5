using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT3
{
    //Denis Evdokhin

    //3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать.
    //а) с использованием методов C#
    //б) * разработав собственный алгоритм
    //Например: badc являются перестановкой abcd

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "fghlsad2313 2asdlna jdk dhh d 3d d3 gh3k sadmk vnal wejip";
            string str2 = "fglsad2313 2asdlna jdk dhh d 3d d3 gh3k sadmk vnal wejip";
            string str3 = "fghls3 2 d3 gh3k saasdlna jdad231h d 3ddk dhmk vnal wejip";

            Console.WriteLine(Convert.ToString(TestEqualStrings.CMet(str1, str2)));
            Console.WriteLine(Convert.ToString(TestEqualStrings.CMet(str1, str3)));

            Console.WriteLine();

            Console.WriteLine(Convert.ToString(TestEqualStrings.MyMet(str1, str2)));
            Console.WriteLine(Convert.ToString(TestEqualStrings.MyMet(str1, str3)));

            Console.ReadLine();



        }
    }
}
