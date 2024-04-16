using System;
using System.Threading.Tasks;

namespace AutoTrade.Core
{
  public interface IUnitOfWork
  {
    Task CompleteAsync();
  }
}