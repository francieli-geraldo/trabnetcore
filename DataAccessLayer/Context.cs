using System;

namespace DataAccessLayer
{
    public partial class Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public Context(Microsoft.EntityFrameworkCore.DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}
