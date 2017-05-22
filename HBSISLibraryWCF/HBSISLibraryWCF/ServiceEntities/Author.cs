using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HBSISLibraryWCF.ServiceEntities
{
    [DataContract]
    public class Author
    {
        public Author()
        {
        }

        public Author(AuthorEntity dbAuthor)
        {
            this.ID = dbAuthor.ID;
            this.FirstName = dbAuthor.FirstName;
            this.LastName = dbAuthor.LastName;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public virtual ICollection<Book> Books { get; set; }
    }
}