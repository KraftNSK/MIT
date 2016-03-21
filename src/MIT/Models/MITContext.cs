using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace MIT.Models
{
    public class MITContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<FileObject> FileObjects { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<MethodFeed> MethodFeeds { get; set; }
        public DbSet<Organization> Organizations{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
