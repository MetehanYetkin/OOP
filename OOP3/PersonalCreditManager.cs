using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalCreditManager : ICrediManager
    {
        public void calculate()
        {
            Console.WriteLine("Personal loan payment plan prepared");

        }

        public void List()
        {
            throw new NotImplementedException();
        }
    }
}
