using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarLoanManager : ICrediManager          //Araç kredisi yöneticisi
    {
        public void BisiYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Tasit kredisi odeme plani hesaplandi");
        }
    }
}
