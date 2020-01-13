using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarWebService.Models
{
    public class CalendrierInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<CalendrierContext>
    {
        protected override void Seed(CalendrierContext context)
        {
            var students = new List<Note>
            {
                new Note(){Date = DateTime.Now, Message = "Message d'intialisation"}
            };


            context.SaveChanges();
        }
    }
}