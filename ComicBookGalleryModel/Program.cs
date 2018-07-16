using ComicBookGalleryModel.Models;
using System;
using System.Linq;

namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook()
                {
                    SeriesTitle = "the Amazing spider man",
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today


                });
                //call the context of the save changes method to persist the added entity to the database
                context.SaveChanges();
                //retrieve a list of comic books from the context by calling to the to list method on the contexts
                var comicBooks = context.ComicBooks.ToList();
                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.SeriesTitle);

                }

                Console.ReadLine();

            }

                
        }
    }
}
