using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace catGifs.Results
{
    [DataContract]
    public class GiphyGif
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "bitly_gif_url")]
        public string BitlyGifUrl { get; set; }

        [DataMember(Name = "bitly_url")]
        public string BitlyUrl { get; set; }

        [DataMember(Name = "embed_url")]
        public string EmbedUrl { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "rating")]
        public string Rating { get; set; }

        [DataMember(Name = "content_url")]
        public string ContentUrl { get; set; }

        [DataMember(Name = "user")]
        public string User { get; set; }

        [DataMember(Name = "source_tld")]
        public string SourceTld { get; set; }

        [DataMember(Name = "source_post_url")]
        public string SourcePostUrl { get; set; }

        [DataMember(Name = "update_date_time")]
        public string UpdateDateTime { get; set; }

        [DataMember(Name = "create_date_time")]
        public string CreateDateTime { get; set; }

        [DataMember(Name = "import_date_time")]
        public string ImportDateTime { get; set; }

        [DataMember(Name = "trending_date_time")]
        public string TrendingDateTime { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}