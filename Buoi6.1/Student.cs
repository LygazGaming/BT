using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._1
{
    internal class Student
    {
        private string studentID;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;
        public Student() { }
        public Student(string studentID, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentID = studentID;
            this.name = name;
            if (birthYear >= 1900 && birthYear <= DateTime.Today.Year)
                this.birthYear = birthYear;
            else this.birthYear = 1900;
            this.gender = gender;
            this.stdClass = stdClass;
        }
        public string GetStudentID()
        {
            return studentID;
        }
        public void SetStudentID(string newID)
        {
            this.studentID = newID;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            this.name = newName;
        }
        public int GetBirthYear()
        {
            return birthYear;
        }
        public void SetBirthYear(int newbirthYear)
        {
            if (birthYear >= 1900 && birthYear <= DateTime.Today.Year)
                this.birthYear = newbirthYear;
            else this.birthYear = 1900;
        }
        public bool GetGender()
        {
            return gender;
        }
        public void SetGender(bool newGender)
        {
            this.gender = newGender;
        }
        public string GetStdClass()
        {
            return stdClass;
        }
        public void SetStdClass(string newStdClass)
        {
            this.stdClass = newStdClass;
        }
        public void Input()
        {
            Console.Write("Nhap MSSV:");
            studentID = Console.ReadLine();
            Console.Write("Nhap ten:");
            name = Console.ReadLine();
            do
            {
                Console.Write("Nhap nam sinh:");
                birthYear = int.Parse(Console.ReadLine());
            } while (birthYear < 1900 || birthYear > DateTime.Today.Year);
            Console.Write("Gioi tinh(True/False):");
            gender = bool.Parse(Console.ReadLine());
            Console.Write("Nhap lop:");
            stdClass = Console.ReadLine();
        }
        public int GetAge()
        {
            return (DateTime.Now.Year) - birthYear;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Studen ID: {studentID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Birth Year: {birthYear}");
            string gt = "Nu";
            if (GetGender()) gt = "Nam";
            Console.WriteLine($"Gender: {gt}");
            Console.WriteLine($"Class: {stdClass}");
            Console.WriteLine($"Tuoi hien tai cua ban la:{GetAge()} tuoi");
        }
    }
}
