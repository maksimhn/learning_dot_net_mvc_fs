using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fs_project.Models
{
    public class Note
    {
        public int UserID { get; set; }
        public int NoteID { get; set; }
        [Required, MinLength(5)]
        public string NoteName { get; set; }
        [Required, MinLength(5)]
        public string NoteContent { get; set; }
        public Nullable<DateTime> CreateAt { get; set; }

        public virtual User User { get; set; }
    }
}