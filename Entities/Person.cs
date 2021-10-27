namespace wtw_interview_project_api.Entities
{
    public enum PersonStatusEnum
    {
        Inactive = 0,
        Active = 1
    }
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonStatusEnum Status { get; set; }
    }
}
