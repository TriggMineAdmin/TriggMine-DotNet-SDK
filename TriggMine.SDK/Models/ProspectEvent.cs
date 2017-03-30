using System;
using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{
    [DataContract]
    public class ProspectEvent
    {
        [DataMember(Name = "device_id")]
        public string DeviceId { get; set; }

        [DataMember(Name = "device_id_1")]
        public string SecondaryDeviceId { get; set; }

        [DataMember(Name = "customer_id")]
        public string Id { get; set; }

        [DataMember(Name = "customer_first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "customer_last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "customer_email")]
        public string Email { get; set; }

        [DataMember(Name = "customer_date_created")]
        public DateTime? RegistrationDate { get; set; }
    }
}
