using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using catGifs.Models;
using catGifs.Results;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace catGifs.Services
{
    public class GiphyService : IImgService
    {
        IConfiguration Configuration { get; set; }

        IConfigurationSection GiphyConfig { get; set; }

        string GiphyHost { get; set; }

        HttpClient httpClient { get; set; }

        public GiphyService(IConfiguration configuration, HttpClient httpClient)
        {

            this.Configuration = configuration;
            this.httpClient = httpClient;


            this.GiphyConfig = this.Configuration.GetSection("appSettings").GetSection("giphy");
            this.GiphyHost = this.GiphyConfig.GetSection("host").Value;

            this.httpClient.DefaultRequestHeaders.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var apiKey = this.GiphyConfig.GetSection("apiKey").Value;
            this.httpClient.DefaultRequestHeaders.Add("api_key", apiKey);
        }

        public async Task<Image> GetRandomImage()
        {
            try
            {
                string endPoint = "/v1/gifs/random";
                string url = this.GiphyHost + endPoint;

                // TODO: go on here, create result classes first
                GiphyResult result = new GiphyResult();
                HttpResponseMessage response = await httpClient.GetAsync(url);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    GiphyResult giphyResult = JsonConvert.DeserializeObject<GiphyResult>(responseContent);

                    Image resImg = new Image();
                    resImg.Type = giphyResult.Data.type;
                    resImg.ImageUrl = giphyResult.Data.ImageUrl;
                    resImg.DownsampledUrl = giphyResult.Data.FixedHeightDownsampledUrl;
                    resImg.Caption = giphyResult.Data.Caption;

                    return resImg;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Image();
        }

        public async Task<Image> GetRandomImage(string tags)
        {
            try
            {
                string endPoint = "/v1/gifs/random";
                string url = this.GiphyHost + endPoint;

                // Build the parameters
                Dictionary<string, string> uriParams = new Dictionary<string, string>();
                if (tags != null)
                {
                    uriParams.Add("tag", tags);
                }
                var uri = QueryHelpers.AddQueryString(url, uriParams);

                // TODO: go on here, create result classes first
                GiphyResult result = new GiphyResult();
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    GiphyResult giphyResult = JsonConvert.DeserializeObject<GiphyResult>(responseContent);

                    Image resImg = new Image();
                    resImg.Type = giphyResult.Data.type;
                    resImg.ImageUrl = giphyResult.Data.ImageUrl;
                    resImg.DownsampledUrl = giphyResult.Data.FixedHeightDownsampledUrl;
                    resImg.Caption = giphyResult.Data.Caption;

                    return resImg;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Image();
        }
    }
}