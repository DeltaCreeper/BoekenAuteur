using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenAuteursData
{
    public static class BooksAuthors
    {
        public static SqlConnection GetConnection()
        {
            // TODO: schrijf hier de code om je connectionstring uit je app.config te lezen
            // Zorg dat je connectionstring correct is opgenomen in deze configuratiefile
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FestivalDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
