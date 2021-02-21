using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICrediManager
    {
        public void calculate()
        {
            Console.WriteLine("Mortgage loan payment plan prepared");

        }

        public void List()
        {
            throw new NotImplementedException();
        }
    }
}
