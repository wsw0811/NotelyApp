using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;
namespace NotelyApp.Services
{
    public class NumberServices
    {
        public Number createNumber(string input)
        {
            Number number = new Number(input);
            return number;
        }
    }
}
