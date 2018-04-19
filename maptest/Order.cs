using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace maptest
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Recepient Recepient { get; set; }
        public Driver Driver { get; set; }
        public Cargo Cargo { get; set; }
        public int StatusId { get; set; }
        public virtual BillingInfo BillingInfo { get; set; }
    }

    public class DbDictionary
    {
        public int Id { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
    }
}