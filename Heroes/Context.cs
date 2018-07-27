using Heroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());


        }




        
        public DbSet<HeroGallery> HeroGallerys { get; set; }
        public DbSet<Creator> Creators { get; set; }
    }
}
