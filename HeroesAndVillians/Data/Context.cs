using HeroesAndVillians.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace HeroesAndVillians.Data
{
    public class Context : DbContext
    {

        public Context()
        {
            Database.SetInitializer<Context>(new DatabaseInitializer());
        }
        public DbSet<Characters> Character { get; set; }
    }
}