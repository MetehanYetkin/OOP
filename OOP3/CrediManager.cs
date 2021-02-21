using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICrediManager//Eğerki bir sınıf bu interfaceyi içeri ise içerisindeki metotları kullanmalıdır.
        //interface içindeki metotlar hepsinde kullanılmak zorunda ve değişebilir.
        //Genelde operasyonel metotlarda interfaceler kullanılır.
    {
        public void calculate();
        public void List();
        
    }
}
