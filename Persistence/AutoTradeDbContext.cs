using Microsoft.EntityFrameworkCore;
using AutoTrade.Core.Models;

namespace AutoTrade.Persistence
{
  public class AutoTradeDbContext : DbContext
  {
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Make> Makes { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Photo> Photos { get; set; }

    public AutoTradeDbContext(DbContextOptions<AutoTradeDbContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
        new { vf.VehicleId, vf.FeatureId });
    }
  }
}