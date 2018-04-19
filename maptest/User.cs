using System.Collections.Generic;

namespace maptest
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        ICollection<Address> UserAddresses { get; set; }
    }
}