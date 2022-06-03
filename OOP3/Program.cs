using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ihtiyac kredisi            Calculate=Hesapla
            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            

            //Arac kredisi
            CarLoanManager carLoanManager = new CarLoanManager();
            

            //Ev kredisi
            HousingLoanManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(housingLoanManager, new DataBaseLoggerService());


            List<ICrediManager> credis = new List<ICrediManager>() {consumerLoanManager,carLoanManager };
            //applicationManager.KrediOnBilgilendirmesiYap(credis);

            Console.ReadKey();
        }
    }
}
