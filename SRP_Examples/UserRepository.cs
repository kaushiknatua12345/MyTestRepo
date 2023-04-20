using System;
using System.Data.SqlClient;

namespace SRP_Examples
{
    class UserRepository
    {
        public void Insert(....)
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 

        }
    }
}
