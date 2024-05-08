using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
   public class SurveyContext 
    {
        // Connection string to your SQL Server database
        private string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";

        public void CreateTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to create a table
                    string createTableQuery = @"CREATE TABLE Survey (
                                                ID INT IDENTITY(1,1) PRIMARY KEY,
                                               Name NVARCHAR(100),
                                                Email NVARCHAR(100),
                                                DateOfBirth DATE,
                                                Contact NVARCHAR(20),
                                                choice Boolean,
                                                checked Boolean

                                              )";

                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Table created successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating table: " + ex.Message);
            }
        }
    }

}

