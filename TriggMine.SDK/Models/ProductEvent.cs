using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{
    [DataContract]
    public class ProductEvent
    {
        [DataMember(Name = "product_id")]
        public string ProductId { get; set; }

        [DataMember(Name = "product_name")]
        public string ProductName { get; set; }

        [DataMember(Name = "product_desc")]
        public string ProductDescription { get; set; }

        [DataMember(Name = "product_sku")]
        public string ProductSku { get; set; }

        [DataMember(Name = "product_image")]
        public string ProductImage { get; set; }

        [DataMember(Name = "product_url")]
        public string ProductUrl { get; set; }

        [DataMember(Name = "product_qty")]
        public int ProductQty { get; set; }

        [DataMember(Name = "product_categories")]
        public string[] ProductCategories { get; set; }

        [DataMember(Name = "product_price")]
        public double ProductPrice { get; set; }

        [DataMember(Name = "product_total_val")]
        public string ProductTotalVal { get; set; }
    }
}
