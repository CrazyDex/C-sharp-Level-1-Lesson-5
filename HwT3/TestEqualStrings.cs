using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT3
{
    class TestEqualStrings
    {
        public static bool CMet(string str1, string str2)
        {
            List<char> l1 = str1.ToList();
            List<char> l2 = str2.ToList();
            l1.Sort();
            l2.Sort();
            return l1.SequenceEqual(l2);
        }

        public static bool MyMet(string str1, string str2)
        {
            int[] ints1 = new int[str1.Length];
            int[] ints2 = new int[str2.Length];
            int max = str1.Length > str2.Length ? str1.Length : str2.Length;
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            for (int i = 0; i < max; i++)
            {
                if (i < str1.Length) { ints1[i] = Convert.ToInt32(ch1[i]); }
                if (i < str2.Length) { ints2[i] = Convert.ToInt32(ch2[i]); }
            }
            ShellSort(ints1);
            ShellSort(ints2);
            bool b = ints1.SequenceEqual(ints2);
            return b;
        }

        static void ShellSort(int[] arr)
        {
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
    }
}
