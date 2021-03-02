using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {


            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            

            IKrediManager konutKrediManager1 = new KonutKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(konutKrediManager1,new List<IloggerService> {new SmsLoggerService(), new DatabaseLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1};
            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);

        }
    }
}
