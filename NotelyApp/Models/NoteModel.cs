﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class NoteModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter the subject")]
        public string Subject { get; set; }
        public string Detail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
