using System;

namespace Constuctors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,FirstName=  " Arzu",LastName="Alkan",City="Ankara"};//parametresiz(default) ctor kullanımı
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");//parametreli ctor kullanımı
            //ikisini aynı anda kullanmak için parametereli ve parametresiz olarak 2 tane ctor olmalı
            Console.WriteLine(customer.FirstName);
        }
        
        class Customer 
        {
            public Customer()
            {
                
            }
            public Customer(int id,string firstName,string lastName,string city)//default constuctors,NEWLENDİĞİNDE ÇALIŞIR
            {
                Id = id;
                FirstName=firstName;
                LastName=lastName;
                City=city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        }
    }
}
