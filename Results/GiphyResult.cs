using System.Runtime.Serialization;

namespace catGifs.Results
{
    [DataContract]
    public class GiphyResult
    {
        [DataMember(Name = "data")]
        public Data Data { get; set; }

        [DataMember(Name = "meta")]
        public Meta Meta { get; set; }
    }
}