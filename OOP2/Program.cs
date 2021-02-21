using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //Metehan Yetkin
            Individual ındividual = new Individual();
            ındividual.CustomerNo = "12345";
            ındividual.CustomerName = "Metehan";
            ındividual.CustomerSurname = "Yetkin";
            ındividual.CustomerIndentityNo = "10101010010";

            //Kodlama.io
            Coorporate coorporate = new Coorporate();
            coorporate.CustomerId = 2;
            coorporate.CustomerNo="54321";
            coorporate.CompanyName = "Kodlama.İo";
            coorporate.TaxNo = "1234567890";


            //Gerçek-Tüzel  (birbirlerine benziyor diye aynı yerde kullanılamazlar.)
            //SOLID

            Customer customer = new Individual();//NEW Bellekteki bir referans numarasıdır
            Customer customer1 = new Coorporate();//Customer classı hem Individual classın referansını tutabiliyor
                                                  //Hem de Coorporate sınıfının referansını tutabiliyor.
            
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(ındividual);
            customerManager.Add(coorporate);
            customerManager.Add(customer);
            customerManager.Add(customer1);


                


        }
    }
}
