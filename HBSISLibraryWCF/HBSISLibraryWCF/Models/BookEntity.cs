using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.Models
{
    [Table("Book")]
    public class BookEntity
    {
        public int ID { get; set; }
        public int PublisherID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AuthorEntity> Authors { get; set; }
        public virtual PublisherEntity Publisher { get; set; }
    }
}