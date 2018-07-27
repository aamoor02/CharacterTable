using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HeroGallery> Heros { get; set; }
    }
}
