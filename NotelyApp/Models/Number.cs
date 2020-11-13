using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class Number
    {
        public Number(string input)
        {
            this.Value = input;          
        }
        public string Value { get; set; }
    }
}
