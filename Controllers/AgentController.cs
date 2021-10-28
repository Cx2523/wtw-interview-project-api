using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using wtw_interview_project_api.Entities;
using wtw_interview_project_api.Services;

namespace wtw_interview_project_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentController : ControllerBase
    {
        private readonly ILogger<AgentController> _logger;
        private readonly IAgentService _agentService;

        public AgentController(IAgentService agentService, ILogger<AgentController> logger)
        {
            _logger = logger;
            _agentService = agentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Agent>> GetAll() => await _agentService.GetAllAsync();
    }
}
