using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fs_project.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}