using System.Collections.Generic;
using wtw_interview_project_api.Entities;

namespace wtw_interview_project_api.MockData
{
    public class MockPersons
    {
        public static IEnumerable<Agent> MockPersonsList = new List<Agent>
        {
            new Agent
            {
                AgentId = 1,
                FirstName = "Dwight",
                LastName = "Shrute",
                Status = AgentStatusEnum.Active
            },
            new Agent
            {
                AgentId = 2,
                FirstName = "Frodo",
                LastName = "Baggins",
                Status = AgentStatusEnum.Active
            },
            new Agent
            {
                AgentId = 3,
                FirstName = "Samwise",
                LastName = "Gamgee",
                Status = AgentStatusEnum.Inactive
            },
            new Agent
            {
                AgentId = 4,
                FirstName = "Ron",
                LastName = "Swanson",
                Status = AgentStatusEnum.Active
            },
            new Agent
            {
                AgentId = 5,
                FirstName = "Leslie",
                LastName = "Knope",
                Status = AgentStatusEnum.Inactive
            },
            new Agent
            {
                AgentId = 6,
                FirstName = "Paul",
                LastName = "Atreides",
                Status = AgentStatusEnum.Active
            },
            new Agent
            {
                AgentId = 7,
                FirstName = "Jean-Luc",
                LastName = "Picard",
                Status = AgentStatusEnum.Active
            },
            new Agent
            {
                AgentId = 8,
                FirstName = "James",
                LastName = "Kirk",
                Status = AgentStatusEnum.Inactive
            },
        };
    }
}
