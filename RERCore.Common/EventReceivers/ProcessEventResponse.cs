using System.Runtime.Serialization;
using System.Runtime.Serialization;

namespace Microsoft.SharePoint.Client.EventReceivers
{
    [DataContract(Name = "ProcessEventResponse", Namespace = "http://schemas.microsoft.com/sharepoint/remoteapp/")]
    public class ProcessEventResponse
    {
        [DataMember]
        public SPRemoteEventResult ProcessEventResult { get; set; }
    }
}
