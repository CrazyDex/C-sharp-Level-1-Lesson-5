using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT2
{
    //Denis Evdokhin

    //2. Разработать методы для решения следующих задач.Дано сообщение:
    //а) Вывести только те слова сообщения, которые содержат не более чем n букв;
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
    //в) Найти самое длинное слово сообщения;
    //г) Найти все самые длинные слова сообщения.

    class Program
    {
        static void Main(string[] args)
        {
            string str = "fghlsad2313 2asdlna jdk dhh d 3d d3 gh3k sadmk vnal wejip";
            StringScripts.NCharWords(str, 4);

            Console.WriteLine();

            Console.WriteLine(str);
            StringScripts.DelWordsEndN(ref str, "h");
            Console.WriteLine(str);

            Console.WriteLine();

            Console.WriteLine(StringScripts.BiggestWord(str));

            Console.WriteLine();

            Console.WriteLine(StringScripts.AllBiggestWord(str));

            Console.ReadLine();



        }
    }
}
