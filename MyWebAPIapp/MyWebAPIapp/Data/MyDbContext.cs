using Microsoft.EntityFrameworkCore;

namespace MyWebAPIapp.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<HangHoa> hangHoas { get; set; }
        #endregion
    }
}
