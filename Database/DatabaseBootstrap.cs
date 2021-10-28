using Dapper;
using Microsoft.Data.Sqlite;
using wtw_interview_project_api.Database;

namespace wtw_INTerview_project_api.Database
{
    public interface IDatabaseBootstrap
    {
        void Setup();
    }
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection(databaseConfig.Name);

            connection.Open();

            connection.Execute($@"DROP TABLE AgentLicense");
            connection.Execute($@"DROP TABLE Agent");
            connection.Execute($@"DROP TABLE License");

            connection.Execute($@"
                CREATE TABLE Agent (
                    AgentId INT NOT NULL PRIMARY KEY,
                    FirstName VARCHAR(255) NOT NULL,
                    LastName VARCHAR(255) NOT NULL,
                    Status INT NOT NULL
                )");

            connection.Execute($@"
                CREATE TABLE License (
                    LicenseId INT NOT NULL PRIMARY KEY,
                    LicenseName VARCHAR(255) NOT NULL,
                    IsRequired BIT NOT NULL
                )");

            connection.Execute($@"
                CREATE TABLE AgentLicense (
                    AgentId INT NOT NULL,
                    LicenseId INT NOT NULL,
                    FOREIGN KEY (AgentId)
                        REFERENCES Agent (AgentId),
                    FOREIGN KEY (LicenseId)
                        REFERENCES License (LicenseId),
                    CONSTRAINT [UC_AgentLicense_AgentId_LicenseId] UNIQUE
                    (
                        AgentId, LicenseId
                    )
                )");

            connection.Execute($@"
                INSERT INTO Agent (AgentId, Firstname, LastName, Status)
                VALUES
                    (1, 'Dwight', 'Shrute', 1),
                    (2, 'Frodo', 'Baggins', 1),
                    (3, 'Samwise', 'Gamgee', 3),
                    (4, 'Ron', 'Swanson', 2),
                    (5, 'Leslie', 'Knope', 3),
                    (6, 'Paul', 'Atreides', 2),
                    (7, 'Jean-Luc', 'Picard', 2),
                    (8, 'James', 'Kirk', 1)
                ");

            connection.Execute($@"
                INSERT INTO License (LicenseId,LicenseName, IsRequired)
                VALUES
                    (1, 'Medicare', 1),
                    (2, 'Healthcare', 1),
                    (3, 'Pet Insurance', 0),
                    (4, 'Fire Insurance', 0)
                ");

            connection.Execute($@"
                INSERT INTO AgentLicense (AgentId, LicenseId)
                VALUES
                    (1, 1),
                    (1, 2),
                    (1, 3),
                    (1, 4),
                    (2, 1),
                    (2, 2),
                    (3, 1),
                    (3, 3),
                    (4, 1),
                    (4, 3),
                    (5, 4),
                    (6, 1),
                    (6, 3),
                    (6, 4),
                    (7, 2),
                    (7, 3),
                    (7, 4),
                    (8, 1),
                    (8, 2)
                ");
        }
    }
}
