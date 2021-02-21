using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void ToApply(ICrediManager crediManager,ILoggerServices loggerServices)
        {
            //Başvuran bilgilerini değerlendirme.
            crediManager.calculate();
            loggerServices.Log();
            
        }
        public void CreditPreInformation(List<ICrediManager> credis)
        {
            //Aynı veri türünde belirsizz sayıda veriyi taşıyabilecek bir yapı (List)
            //ICrediManager Türünde bir liste ver.
            foreach (var credi in credis)
            {
                credi.calculate();
            }

        }
    }
}
