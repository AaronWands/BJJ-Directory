using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJ.Models
{
    public class Video
    {
        public int VideoId { get; set; }
        public string VidURL { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
