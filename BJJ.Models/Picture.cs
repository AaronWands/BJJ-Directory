using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJ.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PicURL { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
