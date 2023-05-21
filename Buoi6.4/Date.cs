using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._4
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        public Date(int day, int month, int year)
        {
            if (day<1||day>31) Console.WriteLine("Ngay phai bat dau tu 1 den 31");
            else 
            if (month < 1 || month > 12) Console.WriteLine("Thang phai bat dau tu 1 den 12");
            else
            if (year < 1900 || year > 9999) Console.WriteLine("Nam phai nam trong doan [1900,9999]");
            else
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }
        public int getDay()
        { 
            return day; 
        }
        public int getMonth() 
        { 
            return month; 
        }
        public int getYear() 
        { 
            return year; 
        }
        public void setDay(int day)
        {
            if (day >= 1 || day <= 31)
            {
                this.day = day;
            }
            else
            {
                Console.WriteLine("Ngay phai bat dau tu 1 den 31");
            }
        }
        public void setMonth(int month)
        {
            if (month >= 1 || month <= 12)
            {
                this.month = month;
            }
            else
            {
                Console.WriteLine("Thang phai bat dau tu 1 den 12");
            }
        }
        public void setYear(int year)
        {
            if (year >= 1900 || year <= 9999)
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("Nam phai nam trong doan [1900,9999]");
            }
        }
        public void setDate(int day, int month, int year)
        {
            Date d = new Date(day, month, year);
            this.day=d.day;
            this.month=d.month;
            this.year=d.year;
        }
        public string toString()
        {
            return $"dd//mm/yyyy:{day}/{month}/{year}";
        }
    }
}
