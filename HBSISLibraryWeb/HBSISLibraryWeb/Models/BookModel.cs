using HBSISLibraryWeb.HBSISLibraryServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWeb.Models
{
    public class BookModel
    {
        public BookModel()
        {
            this.Authors = new List<AuthorModel>();
        }

        public BookModel(Book wcfBook)
        {
            this.ID = wcfBook.ID;
            this.Title = wcfBook.Title;
            this.ISBN = wcfBook.ISBN;
            this.Pages = wcfBook.Pages;
            this.Description = wcfBook.Description;

            this.Authors = wcfBook.Authors.Select(x => new AuthorModel(x)).ToList();
            this.Publisher = new PublisherModel(wcfBook.Publisher);
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }

        public List<AuthorModel> Authors { get; set; }
        public PublisherModel Publisher { get; set; }
    }
}