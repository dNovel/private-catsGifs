using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using catGifs.Models;
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

            this.httpClient.DefaultRequestHeaders.Accept.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.httpClient.DefaultRequestHeaders.Add("api_key", this.GiphyConfig.GetSection("apiKey").Value);
        }

        public async Task<Image> GetRandomImage()
        {
            try
            {
                string endPoint = "/v1/gifs/random";
                string url = this.GiphyHost + endPoint;

                // TODO: go on here, create result classes first
                HttpResponseMessage response = await this.httpClient.GetAsync(url);
                var respStr = await response.Content.ReadAsStringAsync();

                return new Image();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return new Image();
        }

        public async Task<Image> GetRandomImage(string[] tags)
        {
            throw new System.NotImplementedException();
        }
    }
}