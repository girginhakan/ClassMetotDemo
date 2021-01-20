using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer kisi)
        {
            Console.Write("Tebrikler üyeliğiniz gerçekleşmiştir. Bilgilerinizi kontrol edebilirsiniz. " +"Kişinin adı : "+ kisi.CustomerName + "Kişinin soyadı: " + kisi.CustomerSurname + "Kişinin mail adresi : " + kisi.CustomerEmail + "Kişinin yorumu : " + kisi.CustomerRewiew);
        }

        public void DeleteCustomer(Customer kisi2)
        {
            Console.WriteLine("Üyeliğiniz başarılı bir şekilde silinmiştir." + kisi2.CustomerName);
        }
    }
}
