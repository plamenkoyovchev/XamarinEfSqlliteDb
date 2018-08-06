using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestEFSqLiteOnXamarin.Persistance.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public int No { get; set; }
    }
}
