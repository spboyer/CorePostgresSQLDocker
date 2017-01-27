using Microsoft.EntityFrameworkCore;
using CorePostgresSQLDocker.Models;

namespace CorePostgresSQLDocker.Repository
{
    public class DockerCommandsDbContext : DbContext
    {
        public DbSet<DockerCommand> DockerCommands { get; set; }

        public DockerCommandsDbContext(DbContextOptions<DockerCommandsDbContext> options) : base(options) { }
    }
}