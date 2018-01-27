using System.Runtime.Serialization;

namespace catGifs.Results
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "image_original_url")]
        public string ImageOriginalUrl { get; set; }

        [DataMember(Name = "image_url")]
        public string ImageUrl { get; set; }

        [DataMember(Name = "image_mp4_url")]
        public string ImageMp4Url { get; set; }

        [DataMember(Name = "image_frames")]
        public string ImageFrames { get; set; }

        [DataMember(Name = "image_width")]
        public string ImageWidth { get; set; }

        [DataMember(Name = "image_height")]
        public string ImageHeight { get; set; }

        [DataMember(Name = "fixed_height_downsampled_url")]
        public string FixedHeightDownsampledUrl { get; set; }

        [DataMember(Name = "fixed_height_downsampled_width")]
        public string FixedHeightDownsampledWidth { get; set; }

        [DataMember(Name = "fixed_height_downsampled_height")]
        public string FixedHeightDownsampledHeight { get; set; }

        [DataMember(Name = "fixed_width_downsampled_url")]
        public string FixedWidthDownsampledUrl { get; set; }

        [DataMember(Name = "fixed_width_downsampled_width")]
        public string FixedWidthDownsampledWidth { get; set; }

        [DataMember(Name = "fixed_width_downsampled_height")]
        public string FixedWidthDownsampledHeight { get; set; }

        [DataMember(Name = "fixed_height_small_url")]
        public string FixedHeightSmallUrl { get; set; }

        [DataMember(Name = "fixed_height_small_still_url")]
        public string FixedHeightSmallStillUrl { get; set; }

        [DataMember(Name = "fixed_height_small_width")]
        public string FixedHeightSmallWidth { get; set; }

        [DataMember(Name = "fixed_height_small_height")]
        public string FixedHeightSmallHeight { get; set; }

        [DataMember(Name = "fixed_width_small_url")]
        public string FixedWidthSmallUrl { get; set; }

        [DataMember(Name = "fixed_width_small_still_url")]
        public string FixedWidthSmallStillUrl { get; set; }

        [DataMember(Name = "fixed_width_small_width")]
        public string FixedWidthSmallWidth { get; set; }

        [DataMember(Name = "fixed_width_small_height")]
        public string FixedWidthSmallHeight { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "caption")]
        public string Caption { get; set; }
    }
}