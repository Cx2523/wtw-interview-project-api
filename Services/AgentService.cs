using System.Collections.Generic;
using System.Threading.Tasks;
using wtw_interview_project_api.Entities;
using wtw_interview_project_api.Repositories;

namespace wtw_interview_project_api.Services
{
    public interface IAgentService
    {
        Task<IEnumerable<Agent>> GetAllAsync();
    }
    public class AgentService : IAgentService
    {
        private readonly IAgentRepository _agentRepository;
        public AgentService(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        public async Task<IEnumerable<Agent>> GetAllAsync() => await _agentRepository.GetAllAsync();
    }
}
