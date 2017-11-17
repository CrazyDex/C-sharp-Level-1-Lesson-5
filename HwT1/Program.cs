using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    //Denis Evdokhin

    //1. Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры,
    //и при этом цифра не может быть первой.
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.

    class Program
    {
        static void Main(string[] args)
        {
            //string login = TestLogin.Start(); // тест через стринги-чары
            string login = TestLoginReg.Start(); // тест регуляркой
            Console.Clear();
            Console.WriteLine($"Login correct.\nLogin:{login}");
            Console.ReadLine();
        }
    }
}
