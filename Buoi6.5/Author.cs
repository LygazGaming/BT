using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._5
{
    internal class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public Author(string name, string email, char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"Author[name={Name},email={Email},gender={Gender}]";
        }
    }
}
