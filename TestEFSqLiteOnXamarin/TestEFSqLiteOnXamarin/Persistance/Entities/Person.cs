using System.ComponentModel.DataAnnotations;

namespace TestEFSqLiteOnXamarin.Persistance.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public uint Age { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
