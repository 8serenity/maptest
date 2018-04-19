using System.ComponentModel.DataAnnotations.Schema;

namespace maptest
{
    public class BillingInfo
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ChargingRateId { get; set; }
        public double TotalSum { get; set; }
    }
}