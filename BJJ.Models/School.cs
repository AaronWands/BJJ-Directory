using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJ.Models
{
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Website { get; set; }
                
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Event> Events { get; set; }
        public virtual List<Article> Articles { get; set; }
        public virtual List<Video> Videos { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
