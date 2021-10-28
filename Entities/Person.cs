namespace wtw_interview_project_api.Entities
{
    public enum AgentStatusEnum
    {
        Inactive = 0,
        Active = 1
    }
    public class Agent
    {
        public int AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AgentStatusEnum Status { get; set; }
    }
}
