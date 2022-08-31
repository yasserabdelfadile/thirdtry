using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Data;

namespace WebApplication5.Models
{
    public class news_dbcontext :DbContext
    {
        public news_dbcontext(DbContextOptions<news_dbcontext> options)
            : base(options)
        {
        }
        public DbSet<news> news { get; set; }
        public DbSet<catogry>catogries { get; set; }
        public DbSet<team_mmber>team_Mmbers { get; set; }
        public DbSet<contact_us> contact_us { get; set; }
    }
}
