using Heroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an instance of the context class
            using (var context = new Context())
            {
                var akira = new Creator
                {
                    Name = "Akira Toriyama"
                };
                context.Creators.Add(akira);

                context.HeroGallerys.Add(new HeroGallery()
                {
                    Name = "Goku",
                    Creator = akira,
                    CreationDate = new DateTime(1984, 12, 3),
                    Universe = "Anime",
                    Favorite = true



                });
                //persist data to the entity
                context.SaveChanges();

                //retrieve a list of hereos from the context
                var hero = context.HeroGallerys.ToList();


            }
              

        }
    }
}
