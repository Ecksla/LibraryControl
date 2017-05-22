using HBSISLibraryWCF.DAL;
using HBSISLibraryWCF.Models;
using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.BLL
{
    public static class PublisherBLL
    {
        public static List<Publisher> FindAll()
        {
            List<Publisher> publisherList = new List<Publisher>();
            using (LibraryContext context = new LibraryContext())
            {
                List<PublisherEntity> dbPublishersCollection = context.Publishers.OrderBy(x => x.PublisherName).ToList();

                publisherList = dbPublishersCollection.Select(x => new Publisher(x)).ToList();
            }

            return publisherList;
        }
    }
}