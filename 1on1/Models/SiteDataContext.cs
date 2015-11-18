using System.Data.Entity;

namespace _1on1.Models
{
    public class SiteDataContext : DbContext
    {
        public SiteDataContext() : base("DefaultConnection") { }

        public DbSet<Notification> Notifications { get; set; }
    }
}