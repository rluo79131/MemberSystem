using System.Data.Entity;

namespace MS.Web.DAL
{
    public class MsContext : DbContext
    {
        public DbSet<Members> Members { get; set; }

        public MsContext() : base("name=MsDB") 
        { 
        }
    }
}