using System.Collections.Generic;
using wtw_interview_project_api.Entities;

namespace wtw_interview_project_api.MockData
{
    public class MockLicenses
    {
        public static IEnumerable<License> MockLicensesList = new List<License>
        {
            new License
            {
                LicenseId = 1,
                LicenseName = "Medicare",
                IsRequired = true
            },
            new License
            {
                LicenseId = 2,
                LicenseName = "Healthcare",
                IsRequired = true
            },
            new License
            {
                LicenseId = 3,
                LicenseName = "Pet Insurance",
                IsRequired = false
            },
            new License
            {
                LicenseId = 4,
                LicenseName = "Fire Insurance",
                IsRequired = false
            },
        };
    }
}
