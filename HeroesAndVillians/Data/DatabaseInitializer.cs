using HeroesAndVillians.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeroesAndVillians.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            IList<Characters> character = new List<Characters>();

            character.Add(new Characters()
            {
                Name = "Goku",
                Creator = "Akira Toriyama",
                CreationDate = "02/15/2015",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Batman",
                Creator = "Akira Toriyama",
                CreationDate = "02/15/2015",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Superman",
                Creator = "Akira Toriyama",
                CreationDate = "02/15/2015",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Green Goblin",
                Creator = "Akira Toriyama",
                CreationDate = "02/15/2015",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Cable",
                Creator = "Akira Toriyama",
                CreationDate = "02/15/2015",
                Fav = true
            });

            context.Character.AddRange(character);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}