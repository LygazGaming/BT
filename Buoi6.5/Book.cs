using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._5
{
    internal class Book
    {
            public string Name { get; set; }
            public Author Author { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }

            public Book(string name, Author author, double price, int qty)
            {
                Name = name;
                Author = author;
                Price = price;
                Qty = qty;
            }

            public override string ToString()
            {
                return $"Book[name={Name},author={Author},price={Price},Qty={Qty}]";
            }
     }
}
