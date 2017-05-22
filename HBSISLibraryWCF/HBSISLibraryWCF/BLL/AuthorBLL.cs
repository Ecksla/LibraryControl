using HBSISLibraryWCF.DAL;
using HBSISLibraryWCF.Models;
using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.BLL
{
    public static class AuthorBLL
    {
        public static List<Author> FindAll()
        {
            List<Author> authorsList = new List<Author>();
            using (LibraryContext context = new LibraryContext())
            {
                List<AuthorEntity> dbAuthorsCollection = context.Authors.OrderBy(x => x.FirstName).ToList();

                authorsList = dbAuthorsCollection.Select(x => new Author(x)).ToList();
            }

            return authorsList;
        }
    }
}