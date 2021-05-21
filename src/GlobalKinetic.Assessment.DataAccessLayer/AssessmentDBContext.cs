using System;
using GlobalKinetic.Assessment.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace GlobalKinetic.Assessment.DataAccessLayer
{
  public class AssessmentDBContext : DbContext
  {
    public AssessmentDBContext(DbContextOptions<AssessmentDBContext> options)
      : base(options)
    {

    }

    public DbSet<CoinModel> Coins { get; set; }
  }
}
