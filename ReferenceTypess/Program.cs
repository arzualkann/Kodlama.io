using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;//değer tipler stackte oluşur
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı1: " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };//arrayler,classlar,interfaceler referans tiptir.
            //int[] sayilar2 = new int[] { 10, 20, 30 };//heapte adres tututulur.
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar 1'in 0. elemanı" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Arzu";
            customer.CreditNumber = "5841232";
            // Console.WriteLine(((Customer)person3).CreditNumber);//boxing
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }
        //base class :Person
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer : Person
        {
            public string CreditNumber { get; set; }

        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
