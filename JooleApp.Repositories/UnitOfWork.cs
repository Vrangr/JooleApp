using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleApp.Repositories.Repository;

namespace JooleApp.Repositories
{
    public class UnitOfWork : IDisposable
    {
        DbContext Context;
        // all model repo interfaces

        public UnitOfWork(DbContext context)
        {
            this.Context = context;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
