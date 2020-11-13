using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class NumberSelect
    {
        public NumberSelect(string input, string name)
        {
            this.Input = input;
            this.Name = name;
        }
        public string Input { get; set; }
        public string Name { get; set; }
    }
}
