using System;
using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{
    [DataContract]
    public class OrderEvent
    {
        [DataMember(Name = "order_id")]
        public string OrderId { get; set; }

        [DataMember(Name = "price_total")]
        public double PriceTotal { get; set; }

        [DataMember(Name = "qty_total")]
        public int QtyTotal { get; set; }

        [DataMember(Name = "products")]
        public ProductEvent[] Products { get; set; }

        [DataMember(Name = "status")]
        public string OrderStatus { get; set; }

        [DataMember(Name = "customer")]
        public ProspectEvent Customer { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime? DateCreated { get; set; }
    }
}
