using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] pList = new Person[4];

            //pList[0] = new Student("Bruce", "B+", new AddressFormat(12, 3, 3632, "Khulna"), 3.24);
            //pList[1] = new Student("Clerk", "AB+", new AddressFormat(81, 131, 8765, "Bogura"), 3.12);
            //pList[2] = new Employee("Diana", "O+", new AddressFormat(44, 46, 3390, "Cumilla"), 11200);
            //pList[3] = new Employee("Arthur", "O+", new AddressFormat(36, 190, 1298, "Sylhet"), 10000);

            //foreach (Person p in pList)
            //{
            //    p.PrintInfo();
            //    Console.WriteLine();
            //}

            //XYZOrganization q = new XYZOrganization();
            XYZOrganization.AddPerson(new Student("Bruce", "B+", new AddressFormat(12, 3, 3632, "Khulna"), 3.24));
            XYZOrganization.AddPerson(new Student("Clerk", "AB+", new AddressFormat(81, 131, 8765, "Bogura"), 3.12));
            XYZOrganization.AddPerson(new Employee("Diana", "O+", new AddressFormat(44, 46, 3390, "Cumilla"), 11200));
            XYZOrganization.AddPerson(new Employee("Arthur", "O+", new AddressFormat(36, 190, 1298, "Sylhet"), 10000));
            //XYZOrganization.ShowAll();
            //XYZOrganization.SearchById("P-30-E");
            XYZOrganization.DeletePerson("P-3-E");

            ///p3.PrintPersonInfo();


            //Parent p1 = new Parent();
            ////Parent p2 = new Parent(10);
            ////Parent p3 = new Parent("Hello");
            //Child c1 = new Child();
            ////Child c2 = new Child(12);
            //Parent p;// = new Parent();
            //Parent pp = new Child();
            //Parent ppp = new GrandChild();

            //Console.WriteLine();
            //p1.M1();
            //c1.M1();
            //p1.M2();
            //c1.M2();
            //Console.WriteLine();
            ////pp.M1();
            //pp.M2();
            //pp.M3();
            //ppp.M2();
        }
    }
}
