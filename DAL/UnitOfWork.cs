using DAL.Repo;
using DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private UniversityContext context;
        private GenericRepository<Groups> groupsRepo;
        private GenericRepository<Students> studentsRepo;
        private GenericRepository<Subjects> subjectsRepo;
        
        public UnitOfWork()
        {
            context = new UniversityContext();

        }

        public GenericRepository<Groups> GroupRepository
        {
            get
            {
                if (groupsRepo == null) groupsRepo = new GenericRepository<Groups>(context);
                return groupsRepo;
            }            
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
