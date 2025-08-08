using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address Information:");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }

    internal abstract class Person
    {
        private static int serialNo = 0;//P-1-S,P-2-S,P-3-E,P-4-E
        private protected string id;
        //private string name;
        //private string bloodGroup;
        private AddressFormat address;

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "P-" + value; }
        }

        internal string Name { get; private set; }

        internal string BloodGroup { get; set; }

        //internal string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //internal string BloodGroup
        //{
        //    get { return this.bloodGroup; }
        //    set { this.bloodGroup = value; }
        //}

        internal AddressFormat Address
        {
            private get { return this.address; }
            set { this.address = value; }
        }

        internal Person(string name, string bloodGroup, AddressFormat address)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.Address = address;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Blood Group: {0}", this.BloodGroup);
            this.Address.PrintAddress();
        }
    }
}
