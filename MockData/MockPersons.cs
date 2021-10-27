using System.Collections.Generic;
using wtw_interview_project_api.Entities;

namespace wtw_interview_project_api.MockData
{
    public class MockPersons
    {
        public static IEnumerable<Person> MockPersonsList = new List<Person>
        {
            new Person
            {
                PersonId = 1,
                FirstName = "Dwight",
                LastName = "Shrute",
                Status = PersonStatusEnum.Active
            },
            new Person
            {
                PersonId = 2,
                FirstName = "Frodo",
                LastName = "Baggins",
                Status = PersonStatusEnum.Active
            },
            new Person
            {
                PersonId = 3,
                FirstName = "Samwise",
                LastName = "Gamgee",
                Status = PersonStatusEnum.Inactive
            },
            new Person
            {
                PersonId = 4,
                FirstName = "Ron",
                LastName = "Swanson",
                Status = PersonStatusEnum.Active
            },
            new Person
            {
                PersonId = 5,
                FirstName = "Leslie",
                LastName = "Knope",
                Status = PersonStatusEnum.Inactive
            },
            new Person
            {
                PersonId = 6,
                FirstName = "Paul",
                LastName = "Atreides",
                Status = PersonStatusEnum.Active
            },
            new Person
            {
                PersonId = 7,
                FirstName = "Jean-Luc",
                LastName = "Picard",
                Status = PersonStatusEnum.Active
            },
            new Person
            {
                PersonId = 8,
                FirstName = "James",
                LastName = "Kirk",
                Status = PersonStatusEnum.Inactive
            },
        };
    }
}
