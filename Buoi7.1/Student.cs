using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buoi7._1
{
    internal class Student : Person
    {
        private string program;
        private int year;
        public Student() { }
        public Student(string name,int birthYear,string address,string program,int year):base(name,birthYear,address)
        {
            this.program = program;
            this.year = year;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap nganh hoc:");
            program = Console.ReadLine();
            Console.Write("Nhap khoa hoc:");
            year=int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Student ["+base.ToString() + $"Nganh hoc: {program}, Khoa hoc: {year}]";
        }
        public void ChangeProgram(string program)
        {
            this.program=program;
        }
        
    }
}
