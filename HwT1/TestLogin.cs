using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    class TestLogin
    {
        static string login = string.Empty;
        static bool incorrect = true;

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
                char[] chars = login.ToCharArray();

                if (login.Length >= 2 && login.Length <= 10 && char.IsDigit(chars[0]) == false)
                {
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (char.IsLetterOrDigit(chars[i]) == false || chars[i] == (char)32)
                        {
                            Incorrect();
                            break;
                        }
                        incorrect = false;
                    }
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
