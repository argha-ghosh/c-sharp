using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    internal static class XYZOrganization
    {
        private static Person[] personList = new Person[1000];
        private static int count = 0;

        internal static void AddPerson(Person p)
        {
            personList[count] = p;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while(index < count)
            {
                if(personList[index] != null)
                    personList[index].PrintInfo();
                index++;
            }
        }

        internal static bool SearchById(string key, out int info)
        {
            bool found = false;
            int index = 0;
            while (index < count)
            {
                if(personList[index].Id == key)
                {
                    found = true;
                    Console.WriteLine("Data Found Hurrah!!!!!");
                    personList[index].PrintInfo();
                    //break;
                    info = index;
                    return found;
                }
                index++;
            }

            if(!found)
                Console.WriteLine("ALAS!!!! Data Not Found");
            info = -1;
            return found;
        }

        internal static void DeletePerson(string key)
        {
            int indexToDelete;
            bool decision = SearchById(key, out indexToDelete);
            if(decision)
            {
                personList[indexToDelete] = null;
                Console.WriteLine("Well data has been deleted from the list\n");
                ShowAll();
            }
        }
    }
}
