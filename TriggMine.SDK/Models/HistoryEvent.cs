using System;
using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{

    [DataContract]
    public class HistoryEvents
    {
        [DataMember(Name = "orders")]
        public HistoryEvent[] HistoryOrders { get; set; }
    }

    [DataContract]
    public class HistoryEvent
    {
        [DataMember(Name = "customer")]
        public CustomerEvent Prospect { get; set; }

        [DataMember(Name = "order_id")]
        public string OrderId { get; set; }

        [DataMember(Name = "date_created")]
        public string DateCreated { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "price_total")]
        public double PriceTotal { get; set; }

        [DataMember(Name = "qty_total")]
        public int QtyTotal { get; set; }

        [DataMember(Name = "products")]
        public ProductEvent[] Products { get; set; }
    }

    [DataContract]
    public class CustomerEvent
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "customer_first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "customer_last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "customer_email")]
        public string Email { get; set; }

        [DataMember(Name = "customer_date_created")]
        public DateTime? RegistrationDate { get; set; }

        [DataMember(Name = "customer_last_login_date")]
        public DateTime? LastLoginDate { get; set; }
    }
}
