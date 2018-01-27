namespace catGifs.Models
{
    public class Image
    {
        public string ImageUrl { get; set; }

        public string DownsampledUrl { get; set; }

        public string Type { get; set; }

        public string Caption { get; set; }

        public Image()
        {
        }
    }
}