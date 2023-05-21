using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._1
{
    internal class Staff:Person
    {
        private string department;
        private double salary;
        public Staff()
        {
            
        }
        public Staff(string name,int birthYear,string address,string department,double salary):base(name,birthYear,address) 
        {
            this.department = department;
            this.salary = salary;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten khoa:");
            department = Console.ReadLine();
            Console.Write("Nhap luong:");
            salary=int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Staff {base.ToString()}] - Khoa: {department}, Luong: {salary}";
        }
        public void UpdataSalary(double salary) 
        {
            this.salary=salary;
        }
    }
}
