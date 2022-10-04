using System.ComponentModel.DataAnnotations;

namespace teste_upd8.Models.Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(11)]
        public string CPF { get; set; }
        public char Gender { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(150)]
        public string City { get; set; }
        [StringLength(3)]
        public string State { get; set; }
    }
}
