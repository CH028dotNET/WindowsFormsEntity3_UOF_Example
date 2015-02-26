using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;


namespace DAL
{
    public class UniversityContext: DbContext
    {
        public UniversityContext () : base("MainConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;    
        }

        public DbSet<Groups> Groups { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<GroupToSubject> GroupToSubject { get; set; }

    }
}
