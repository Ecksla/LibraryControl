using HBSISLibraryWeb.HBSISLibraryServiceReference;
using HBSISLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HBSISLibraryWeb.Util;

namespace HBSISLibraryWeb.BLL
{
    public class AuthorBLL
    {
        public static List<AuthorModel> ListAll()
        {
            List<AuthorModel> result = new List<AuthorModel>();

            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                result = client.FindAllAuthors().Select(x => new AuthorModel(x)).ToList();
            }

            return result;
        }
    }
}