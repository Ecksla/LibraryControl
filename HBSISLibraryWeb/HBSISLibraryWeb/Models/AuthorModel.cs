using HBSISLibraryWeb.HBSISLibraryServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWeb.Models
{
    public class AuthorModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AuthorModel()
        {
        }

        public AuthorModel(Author wcfAuthor)
        {
            this.ID = wcfAuthor.ID;
            this.FirstName = wcfAuthor.FirstName;
            this.LastName = wcfAuthor.LastName;
        }
    }
}