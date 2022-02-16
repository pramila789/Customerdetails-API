using Microsoft.EntityFrameworkCore;

namespace CustomerDetails.Model
{
    public class EFDbhandle:DbContext
    {
        public string conn = "Server=DESKTOP-L113TN3;Database=EFCORE_Customer;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder OptionB)
        {
            OptionB.UseSqlServer(conn);
        }
        public DbSet<User> Users { get; set; }


    }
}
