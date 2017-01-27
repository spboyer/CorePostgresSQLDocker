using System.Collections.Generic;
using System.Threading.Tasks;

using CorePostgresSQLDocker.Models;

namespace CorePostgresSQLDocker.Repository
{
    public interface IDockerCommandsRepository
    {     
        Task<List<DockerCommand>> GetDockerCommandsAsync();
        
        Task InsertDockerCommandAsync(DockerCommand command);
    }
}