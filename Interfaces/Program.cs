using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //İnterfaceler newlnemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager=new CustomerManager();
            

            IPersonManager employeeManager=new EmployeesManager();
            ProjectManager projectManager=new ProjectManager();
            projectManager.Add(new InternManager());
           
            

        }

        //class PersonManager
        //{
        //    //implemented operation(Tamamlanmış operasyon)
        //    public void Add()
        //    {
        //        Console.WriteLine("EKLENDİ");
        //    }
        //}
        //class CustomerManager:PersonManager
        //{

        //}
        interface IPersonManager//dışardan erişilebilir olmalı o yüzden default olarak public
        {
            //unimplemented operation(Tamamlanmamış operasyon)
            void Add();
            void Update();
        }

        //classlarda inherit interfacelerde implements(:) denir
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                //müşteri ekleme kodları
                Console.WriteLine("Müşteri eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi");

            }
        }
        class EmployeesManager : IPersonManager
        {
            public void Add()
            {
                //personel eklme kodları
                Console.WriteLine("Personel eklendi");
            }

            public void Update()
            {
                Console.WriteLine("personel güncellendi");

            }
        }
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("STAJYER");
            }

            public void Update()
            {
                Console.WriteLine("STAJYER");
                
            }
        }
        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            { 
                personManager.Add();
            }
        }
    }
}
