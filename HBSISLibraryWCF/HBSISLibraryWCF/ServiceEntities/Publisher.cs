using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HBSISLibraryWCF.ServiceEntities
{
    [DataContract]
    public class Publisher
    {
        public Publisher()
        {
        }

        public Publisher(PublisherEntity dbPublisher)
        {
            this.ID = dbPublisher.ID;
            this.PublisherName = dbPublisher.PublisherName;
            this.Location = dbPublisher.Location;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string PublisherName { get; set; }

        [DataMember]
        public string Location { get; set; }
    }
}