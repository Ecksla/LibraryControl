using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HBSISLibraryWCF.ServiceEntities
{
    [DataContract]
    public class Book
    {
        public Book()
        { }

        public Book(BookEntity dbBook)
        {
            this.ID = dbBook.ID;
            this.Title = dbBook.Title;
            this.ISBN = dbBook.ISBN;
            this.Pages = dbBook.Pages;
            this.Description = dbBook.Description;

            this.Authors = dbBook.Authors.Select(x => new Author(x)).ToList();
            this.Publisher = new Publisher(dbBook.Publisher);
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int PublisherID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string ISBN { get; set; }

        [DataMember]
        public int Pages { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public virtual ICollection<Author> Authors { get; set; }

        [DataMember]
        public virtual Publisher Publisher { get; set; }
    }
}