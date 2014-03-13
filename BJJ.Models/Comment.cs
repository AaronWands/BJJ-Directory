using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJ.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
