using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT4
{
    //Denis Evdokhin

    //задача вывести 3 учеников (и более, если есть) с худшими оценками

    class Program
    {
        static void Main(string[] args)
        {
            int count;
            while (true)
            {
                Console.Write("Введите количество учеников для набора: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count >= 10 && count <= 100) break;
                else Console.WriteLine("***Неверное количество");
            }
            List<Uchenik> nabor = new List<Uchenik>();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Ученик {i+1}: ");
                nabor.Add(new Uchenik(Console.ReadLine()));
            }
            nabor.Sort(delegate (Uchenik uch1, Uchenik uch2) { return uch1.SrOc.CompareTo(uch2.SrOc); });
            Console.Clear();
            Console.WriteLine("Худшие результаты у:");
            for (int i = 0; i < nabor.Count; i++)
            {
                if (i >= 0 && i <= 2) { Console.WriteLine( nabor[i] ); }
                else if (nabor[i].SrOc == nabor[2].SrOc) { Console.WriteLine(nabor[i]); }
            }
            Console.ReadLine();
        }
    }
}
