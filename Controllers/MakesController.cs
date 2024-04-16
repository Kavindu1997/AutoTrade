using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoTrade.Controllers.Resources;
using AutoTrade.Core.Models;
using AutoTrade.Persistence;

namespace AutoTrade.Controllers
{
  public class MakesController : Controller
  {
    private readonly AutoTradeDbContext context;
    private readonly IMapper mapper;
    public MakesController(AutoTradeDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/makes")]
    public async Task<IEnumerable<MakeResource>> GetMakes()
    {
      var makes = await context.Makes.Include(m => m.Models).ToListAsync();

      return mapper.Map<List<Make>, List<MakeResource>>(makes);
    }
  }
}