
using System;

namespace Sample.Database.Context
{
    public class UnitOfWorkContext
    {
        private WriteContext context;

        public UnitOfWorkContext(WriteContext context)
        {
            this.context = context;
        }
        public void Save() => context.SaveChanges();

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}
