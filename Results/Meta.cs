using System.Runtime.Serialization;

namespace catGifs.Results
{
    [DataContract]
    public class Meta
    {
        [DataMember(Name = "msg")]
        public string Message { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "response_id")]
        public string ResponseId { get; set; }
    }
}