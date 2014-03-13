using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJ.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Heading { get; set; }
        public string Url { get; set; }

        public bool Active { get; set; }
                
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
