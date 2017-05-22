using HBSISLibraryWeb.HBSISLibraryServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWeb.Models
{
    public class PublisherModel
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public string Location { get; set; }

        public PublisherModel()
        {
        }

        public PublisherModel(Publisher wcfPublisher)
        {
            this.ID = wcfPublisher.ID;
            this.PublisherName = wcfPublisher.PublisherName;
            this.Location = wcfPublisher.Location;
        }
    }
}