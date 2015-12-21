using fs_project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace fs_project.DAL
{
    public class NotebookInitializer : DropCreateDatabaseIfModelChanges<NotebookContext>
    {
        protected override void Seed(NotebookContext context)
        {
            var users = new List<User>
            {
                new User { UserName="John Smith", Email="abc@abc.com", CreateAt=DateTime.Now },
                new User { UserName="John Doe", Email="tr@aol.com", CreateAt=DateTime.Now },
                new User { UserName="Donald Trump", Email="trump@gmail.com", CreateAt=DateTime.Now }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var notes = new List<Note>
            {
                new Note { UserID=1, NoteName="Shopping List", NoteContent="1.Milk; 2.Bread", CreateAt=DateTime.Now },
                new Note { UserID=1, NoteName="To Do List", NoteContent="1.Fix garage door; 2.Send rent check to landlord", CreateAt=DateTime.Now },
                new Note { UserID=2, NoteName="Money notes", NoteContent="John owes me $40", CreateAt=DateTime.Now }
            };

            notes.ForEach(n => context.Notes.Add(n));
            context.SaveChanges();
        }
    }
}