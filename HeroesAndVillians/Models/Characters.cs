using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroesAndVillians.Models
{
    public class Characters
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Creator { get; set; }
        public string CreationDate { get; set; }
        public bool Fav { get; set; }
        
    }
}