using System.ComponentModel.DataAnnotations.Schema;

namespace maptest
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressInfo { get; set; }
        public string Telephone { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}