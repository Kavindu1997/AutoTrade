using System.Collections.Generic;
using System.Threading.Tasks;
using AutoTrade.Core.Models;

namespace AutoTrade.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}