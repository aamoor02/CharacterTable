using HeroesAndVillians.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeroesAndVillians.Data
{
    //The database will drop the previous database and create a new one if there are changes to the model
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            //create a list to populate with characters
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
                Creator = "Bob Kane and Bill Finger",
                CreationDate = "07/23/1939",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Superman",
                Creator = "Jerry Siegel and Joe Shuster",
                CreationDate = "04/18/1938",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Green Goblin",
                Creator = "Stan Lee",
                CreationDate = "07/15/1964",
                Fav = true
            });

            character.Add(new Characters()
            {
                Name = "Cable",
                Creator = "Akira Toriyama",
                CreationDate = "01/11/1986",
                Fav = true
            });

            context.Character.AddRange(character);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}