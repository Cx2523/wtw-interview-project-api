namespace wtw_interview_project_api.Entities
{
    public enum AgentStatusEnum
    {
        Active = 1,
        InProgress = 2,
        Inactive = 3
    }
    public class Agent
    {
        public int AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AgentStatusEnum Status { get; set; }
    }
}
