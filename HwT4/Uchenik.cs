using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HwT4
{
    class Uchenik
    {
        private string fam, name;
        private int oc1, oc2, oc3;
        private double srOc;

        public string Fam { get => fam; set => fam = value; }
        public string Name { get => name; set => name = value; }
        public int Oc1
        {
            get => oc1;
            set
            {
                oc1 = value;
                RSrOc();
            }
        }
        public int Oc2
        {
            get => oc2;
            set
            {
                oc2 = value;
                RSrOc();
            }
        }
        public int Oc3
        {
            get => oc3;
            set
            {
                oc3 = value;
                RSrOc();
            }
        }
        public double SrOc { get => srOc; }

        public void RSrOc() { srOc = (Oc1 + Oc2 + Oc3) / 3.0; }

        public Uchenik(string str)
        {
            while (true)
            {
                string[] ostr = Regex.Split(str, @"\s");
                if (ostr.Length == 5 && Regex.IsMatch(ostr[0], @"^[a-zA-Z][a-zA-Z]{0,19}\b") && Regex.IsMatch(ostr[1], @"^[a-zA-Z][a-zA-Z]{0,14}\b") && Regex.IsMatch(ostr[2], @"^[1-5]$") && Regex.IsMatch(ostr[3], @"^[1-5]$") && Regex.IsMatch(ostr[4], @"^[1-5]$"))
                {
                    Fam = ostr[0];
                    Name = ostr[1];
                    Oc1 = Convert.ToInt32(ostr[2]);
                    Oc2 = Convert.ToInt32(ostr[3]);
                    Oc3 = Convert.ToInt32(ostr[4]);
                    RSrOc();
                    break;
                }
                else
                {
                    Console.WriteLine("***Данные введены неверно, попробуйте еще раз");
                    str = Console.ReadLine();
                }
            }
        }

        public override string ToString()
        {
            return $"{Fam} {Name}";//. Оценки: {Oc1} {Oc2} {Oc3}";
        }
    }
}
