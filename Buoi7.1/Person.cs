using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._1
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private string address;
        public Person() { }
        public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.address = address;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ho ten:");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh:");
            birthYear=int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi:");
            address=Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Today.Year - birthYear;
        }
        public virtual string ToString()
        {
            return $"Person [Ho Ten:{name}, Namsinh:{birthYear}, Diachi:{address}], Tuoi:{GetAge()}";
        }
    }
}
