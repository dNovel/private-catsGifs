using System.Threading.Tasks;
using catGifs.Models;

namespace catGifs.Services
{
    public interface IImgService
    {
        Task<Image> GetRandomImage();

        Task<Image> GetRandomImage(string[] tags);
    }
}