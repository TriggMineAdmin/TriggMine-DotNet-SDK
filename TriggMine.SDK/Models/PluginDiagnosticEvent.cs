using System;
using System.Runtime.Serialization;

namespace TriggMine.SDK.Models
{
    [DataContract]
    public class PluginDiagnosticEvent
    {
        [DataMember(Name = "DateCreated")]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "DiagnosticType")]
        public string DiagnosticType { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }
    }
}
