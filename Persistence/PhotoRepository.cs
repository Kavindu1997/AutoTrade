using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoTrade.Core;
using AutoTrade.Core.Models;

namespace AutoTrade.Persistence
{
  public class PhotoRepository : IPhotoRepository
  {
    private readonly AutoTradeDbContext context;
    public PhotoRepository(AutoTradeDbContext context)
    {
      this.context = context;
    }
    public async Task<IEnumerable<Photo>> GetPhotos(int vehicleId)
    {
      return await context.Photos
        .Where(p => p.VehicleId == vehicleId)
        .ToListAsync();
    }
  }
}