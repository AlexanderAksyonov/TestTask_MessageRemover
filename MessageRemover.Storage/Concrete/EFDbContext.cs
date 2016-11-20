using System.Data.Entity;
using MessageRemover.Storage.Entities;
using System.Collections.Generic;

namespace MessageRemover.Storage.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}
