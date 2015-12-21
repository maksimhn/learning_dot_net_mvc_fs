using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fs_project.Models
{
    public class Note
    {
        public int UserID { get; set; }
        public int NoteID { get; set; }
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual User User { get; set; }
    }
}