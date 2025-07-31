using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassE
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
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine($"Road No: {roadNo}");
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}\n", this.district);
        }
    }

    class Student
    {
        private int id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private AddressFormat address;

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCgpa()
        {
            return this.cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 4.0)
                this.cgpa = cgpa;
            else
                this.cgpa = -1;
        }

        public string GetBloodGroup()
        {
            return this.bloodGroup;
        }

        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }

        public AddressFormat GetAddress()
        {
            return this.address;
        }

        public void SetAddress(AddressFormat address)
        {
            this.address = address;
        }

        public Student()
        {
        }

        public Student(int id, string name, double cgpa, string bloodGroup, AddressFormat address)
        {
            this.SetId(id); //this.id = id;
            this.SetName(name);//this.name = name;
            this.SetCgpa(cgpa);//this.cgpa = cgpa;
            this.SetBloodGroup(bloodGroup);
            this.SetAddress(address);//this.bloodGroup = bloodGroup;
        }

        public string FindGradeLetter()
        {
            if (this.GetCgpa() >= 3.5 && this.GetCgpa() <= 4.0)
                return "Student Grade Letter: A+"; //Console.WriteLine("Student Grade Letter: A+");
            else if (this.GetCgpa() >= 3.0 && this.GetCgpa() <= 3.49)
                return "Student Grade Letter: A"; //Console.WriteLine("Student Grade Letter: A");
            else if (this.GetCgpa() >= 2.0 && this.GetCgpa() < 3.0)
                return "Student Grade Letter: D+"; //Console.WriteLine("Student Grade Letter: D+");
            else if (this.GetCgpa() >= 0.0 && this.GetCgpa() < 2.0)
                return "Student Grade Letter: F"; //Console.WriteLine("Student Grade Letter: F");
            else
                return "Student Grade Letter: Invalid"; //Console.WriteLine("Student Grade Letter: Invalid");
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student Id: {0}", this.GetId()); //this.id);
            Console.WriteLine("Student Name: {0}", this.GetName()); //this.name);
            Console.WriteLine("Student Cgpa: {0}", this.GetCgpa()); //this.cgpa);
            Console.WriteLine("{0}", this.FindGradeLetter());
            Console.WriteLine("Student Blood Group: {0}", this.GetBloodGroup()); //this.bloodGroup);
            this.GetAddress().PrintAddress(); //this.address.PrintAddress();
        }
    }
}
