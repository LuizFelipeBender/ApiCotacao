using ApiCotacao.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCotacao.ProductAPI.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options): base(options) {}
        public DbSet<CoinModel>? CoinModels {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoinModel>().ToTable("Coin_Entities");
        }

    }
}