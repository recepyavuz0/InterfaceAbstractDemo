using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            
            // Hatalı Kullanıcı Bilgileri Yollandı.
            baseCustomerManager.Save(new Customer() { DateOfBirth = new DateTime(1986,8,19),FirstName="Ali",LastName="Cab",Id=1, NationalityId="11111111111"}); ;
            
        }
    }
}
