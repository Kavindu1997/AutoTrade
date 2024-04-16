using System.Threading.Tasks;
using AutoTrade.Core;

namespace AutoTrade.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly AutoTradeDbContext context;

    public UnitOfWork(AutoTradeDbContext context)
    {
      this.context = context;
    }

    public async Task CompleteAsync()
    {
      await context.SaveChangesAsync();
    }
  }
}