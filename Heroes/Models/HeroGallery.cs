using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Models
{
    public class HeroGallery
    {
        // Hero properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Universe { get; set; }
        public bool Favorite { get; set; }

        public virtual Creator Creator { get; set; }
    }
}
