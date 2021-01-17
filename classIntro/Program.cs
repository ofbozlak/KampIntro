using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 12;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 1000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi+ " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " ---> " +  kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
