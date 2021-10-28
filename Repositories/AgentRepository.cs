using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using wtw_interview_project_api.Database;
using wtw_interview_project_api.Entities;

namespace wtw_interview_project_api.Repositories
{
    public interface IAgentRepository
    {
        Task<IEnumerable<Agent>> GetAllAsync();
    }
    public class AgentRepository : IAgentRepository
    {
        private readonly DatabaseConfig _databaseConfig;
        public AgentRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public async Task<IEnumerable<Agent>> GetAllAsync()
        {
            using var connection = new SqliteConnection(_databaseConfig.Name);
            return await connection.QueryAsync<Agent>("SELECT * FROM Agent");
        }
    }
}
