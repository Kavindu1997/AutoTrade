using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoTrade.Controllers.Resources;
using AutoTrade.Core.Models;
using AutoTrade.Persistence;

namespace AutoTrade.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly AutoTradeDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(AutoTradeDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();

      return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
    }
  }
}