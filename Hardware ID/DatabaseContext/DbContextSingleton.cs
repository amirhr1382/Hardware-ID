using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.DatabaseContext
{
    public static class DbContextSingleton
    {
        private static readonly Lazy<HdDbContext> _dbContextInstance = new Lazy<HdDbContext>(() =>  new HdDbContext());
        public static HdDbContext GetInstance()
        {
            return _dbContextInstance.Value;
        }
    }
}
