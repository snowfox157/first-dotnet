using Microsoft.EntityFrameworkCore;
using DotnetFirst.Models;

namespace DotnetFirst.Data
{
    public class AppDbContext : DbContext
    {
        // 宣告資料表對應的 DbSet
        public DbSet<User> User { get; set; }

        // 建構子注入 DbContext 選項
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        // // 可選：進階設定資料表結構
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     // 範例：設定欄位屬性
        //     modelBuilder.Entity<User>(entity =>
        //     {
        //         entity.ToTable("users");
        //         entity.HasKey(e => e.Id);
        //         entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
        //         entity.Property(e => e.Phone).HasMaxLength(20);
        //         entity.Property(e => e.CreateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
        //         entity.Property(e => e.UpdateTime).HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");
        //     });
        // }
    }
}
