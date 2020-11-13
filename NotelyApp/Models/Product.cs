using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class Product
    {
        public Product(string name, int left)
        {
            this.Name = name;
            this.NumberLeft = left;
        }
        public string Name { get; set; }
        public int NumberLeft { get; set; }
    }
}
