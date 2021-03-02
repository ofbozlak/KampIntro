using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {// methot injection
        public void Basvuruyap(IKrediManager krediManager,List<IloggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var iloggerService in loggerServices)
            {
                iloggerService.Log();
            }
        }
        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
