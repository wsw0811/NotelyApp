using NotelyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Services
{
    public class NumberSelectServices
    {
        public NumberSelect ChooseProduct(string input = null)
        {
            if(input.Equals("1"))
            {
                NumberSelect numberSelect = new NumberSelect("1", "sunglasses");
                return numberSelect;
            }
            else if (input.Equals("2"))
            {
                NumberSelect numberSelect= new NumberSelect("2", "hat");
                return numberSelect;
            }
            else
            {
                NumberSelect numberSelect = new NumberSelect(input, "none");
                return numberSelect;
            }
        }
    }
}
