using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    class UnitOfWork
    {
        public DbContext Context { get; private set; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
            Debug.WriteLine("unit of work create!");
        }
        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            //Debug.WriteLine("Context dispose!");
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}
