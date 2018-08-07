using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestEFSqLiteOnXamarin.Persistance.Entities
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }

        public string Location { get; set; }

        public int Size { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
