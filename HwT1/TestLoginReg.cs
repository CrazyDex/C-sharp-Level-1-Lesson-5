using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HwT1
{
    class TestLoginReg
    {
        static string login = string.Empty;
        static bool incorrect = true;
        static Regex testReg = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");

        static void Incorrect()
        {
            incorrect = true;
            Console.Clear();
            Console.WriteLine("Введен некорректный логин, убедитесь что он:\n" +
                "-состоит из цифр и букв;\n" +
                "-начинается с буквы;\n" +
                "-длиной от 2 до 10 символов.\n");
        }

        public static string Start()
        {
            while (incorrect)
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                if (testReg.IsMatch(login))
                {
                    incorrect = false;
                }
                else
                {
                    Incorrect();
                }
            }
            return login;
        }
    }
}
