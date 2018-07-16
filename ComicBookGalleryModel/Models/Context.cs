using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ComicBookGalleryModel.Models
{
    public   class Context : DbContext
    {
        public Context() : base("ComicBookGallery")
        {


        }
        public DbSet<ComicBook> ComicBooks { get; set; }



    }
}
