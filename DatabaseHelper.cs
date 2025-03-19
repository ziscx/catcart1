using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace catcart
{
    public class DatabaseHelper
    {
        private const string ConnectionString = "server=localhost;port=3306;database=catcart_db;user=root;password=k1181250620;";

        public async Task<List<Cat>> GetCatsAsync()
        {
            var cats = new List<Cat>();

            try
            {
                using var connection = new MySqlConnection(ConnectionString);
                await connection.OpenAsync();

                string query = "SELECT ID, Name, Breed, Price FROM Cats";
                using var cmd = new MySqlCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    cats.Add(new Cat
                    {
                        ID = reader.GetInt32("ID"),  // ✅ FIXED: Ensure ID is fetched as INT
                        Name = reader.GetString("Name"),  // ✅ FIXED: Name is fetched as STRING
                        Breed = reader.GetString("Breed"),  // ✅ FIXED: Breed is fetched as STRING
                        Price = reader.GetDecimal("Price")  // ✅ FIXED: Price is fetched as DECIMAL
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return cats;
        }
    }

    public class Cat
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Breed { get; set; }
        public decimal Price { get; set; }
    }
}
