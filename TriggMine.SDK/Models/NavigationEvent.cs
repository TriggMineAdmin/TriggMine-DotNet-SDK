using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{
    [DataContract]
    public class NavigationEvent
    {
        [DataMember(Name = "user_agent")]
        public string UserAgent { get; set; }

        [DataMember(Name = "products")]
        public ProductEvent[] Products { get; set; }

        [DataMember(Name = "customer")]
        public ProspectEvent Customer { get; set; }
    }
}
