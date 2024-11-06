using Assessment3.Operation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gouri\\Documents\\QuestDb.mdf;Integrated Security=True;Connect Timeout=30;";
            string createQuery = @"CREATE TABLE Notes (
                                   ID INT PRIMARY KEY IDENTITY(1,1),
                                   Title VARCHAR(100),
                                   Content TEXT,
                                   CreatedAt DATETIME DEFAULT GETDATE(),
                                   UpdatedAt DATETIME DEFAULT GETDATE()
                                   );";
            using (var connection = new SqlConnection(connstr))
            {
                connection.Open();
                try
                {
                    Console.WriteLine("Connection established");

                    using (var command = new SqlCommand(createQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Notes table created");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                connection.Close();
            } */


            var operation = new Operations();

            while (true)
            {
                Console.WriteLine("Enter your option");
                Console.WriteLine("1.Create a note \n 2.List all note \n 3.Update a note \n 4.Delete a note");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        operation.CreateNote();
                        break;
                    case "2":
                        operation.ViewNotes(); 
                        break;
                    case "3":
                        operation.UpdateNote();
                        break;
                    case "4":
                        operation.DeleteNote();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
        }
    }
}
