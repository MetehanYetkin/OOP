using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inheritance Cooporate
    //Inheritance ile customerste de olan özellikler coorporatede de de de varmış gibi kabul edilir.

    class Coorporate:Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
