using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager   //Başvuru Yöneticisi
    {
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini degerlendirme yapilir


            crediManager.Calculate();
            loggerService.LoggerService();
        }
        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Calculate();
            }
        }

    }
}
