using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoTrade.Core.Models;

namespace AutoTrade.Core
{
    public interface IPhotoService
    {
        Task<Photo> UploadPhoto(Vehicle vehicle, IFormFile file, string uploadsFolderPath);
    }
}