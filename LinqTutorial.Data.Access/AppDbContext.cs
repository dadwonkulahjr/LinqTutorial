using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LinqTutorial.Data.Access
{
    public class AppDbContext
    {
        public async static void ConnectToDatabase()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                await con.OpenAsync();
                string sqlQuery = "Select [Customer Code], [Customer Last Name],[Customer First Name], [Customer Email],[Agent Code] From Customer";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                int customerCode = 0;
                string customerFirstName = string.Empty;
                string customerLastName = string.Empty;
                string customerEmail = string.Empty;
                int agentCode = 0;
                string printDetail = string.Empty;
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        customerCode = Convert.ToInt32(reader["Customer Code"]);
                        customerFirstName = reader["Customer First Name"].ToString();
                        customerLastName = reader["Customer Last Name"].ToString();
                        customerEmail = reader["Customer Email"].ToString();
                        agentCode = Convert.ToInt32(reader["Agent Code"]);

                        printDetail = PrintCustomerInfoFromTheDatabase(customerCode,
                      customerFirstName, customerLastName, customerEmail, agentCode);

                        Console.WriteLine(printDetail);
                        Console.WriteLine("-------------------------------------");
                    }
                }


            }
        }

        static string PrintCustomerInfoFromTheDatabase(
            int customerCode, string customerFirstName, string customerLastName,
            string customerEmail, int agentCode)
        {
            return string.Format($"Customer Details:\n" +
                $"Customer Code : {customerCode}\n" +
                $"Customer First Name: {customerFirstName}\n" +
                $"Customer Last Name: {customerLastName}\n" +
                $"Customer Email: {customerEmail}\n" +
                $"Customer Agent Code: {agentCode}");

        }
        static string PrintCustomerInfoFromTheDatabase(int customerCode = 0
            )
        { return null; }
    }
}
