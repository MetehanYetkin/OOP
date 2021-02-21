using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
            //Interfaceler de o interfaceyi implemente eden sınıfın referans numarasını tutabilir.
            //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

        {
            ICrediManager personalCreditManager = new PersonalCreditManager();
            

            ICrediManager vehicleCreditManager = new VehicleCreditManager();
            

            ICrediManager mortgageCreditManager = new MortgageCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();

            //ILoggerServices databaseLoggerServices = new DatabaseLoggerServices();
            applicationManager.ToApply(mortgageCreditManager,new DatabaseLoggerServices());//bu şekildede olur üstte oluşturup da atabilirz.

            //ILoggerServices fileLoggerServices = new FileLoggerServices();
            //Aynı anda 2 tane hesaplamak istiyor isek

            List<ICrediManager> credis = new List<ICrediManager>() {personalCreditManager,mortgageCreditManager };

            //applicationManager.CreditPreInformation(credis);


        }
    }
}
