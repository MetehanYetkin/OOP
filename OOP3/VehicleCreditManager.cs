using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICrediManager
    {
        public void calculate()
        {
            Console.WriteLine("Vehicle loan payment plan prepared");
        }

        public void List()
        {
            throw new NotImplementedException();
        }
    }
}
