using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HBSISLibraryWCF.Models
{
    [Table("Publisher")]
    public class PublisherEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string PublisherName { get; set; }

        public string Location { get; set; }
    }
}