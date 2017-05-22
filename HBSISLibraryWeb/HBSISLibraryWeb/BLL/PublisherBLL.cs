using HBSISLibraryWeb.HBSISLibraryServiceReference;
using HBSISLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HBSISLibraryWeb.Util;

namespace HBSISLibraryWeb.BLL
{
    public class PublisherBLL
    {
        public static List<PublisherModel> ListAll()
        {
            List<PublisherModel> result = new List<PublisherModel>();

            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                result = client.FindAllPublishers().Select(x => new PublisherModel(x)).ToList();
            }

            return result;
        }
    }
}