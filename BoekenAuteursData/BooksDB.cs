using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenAuteursData
{
    public static class BooksDB
    {
        public static List<Book> GetBoekenByTitle(string term)
        {
            List<Book> boekenLijst = new List<Book>();

            //TODO: Schrijf hier de nodig code om de boeken uit je database 
            // op te halen waarvan de doorgegeven term in de titel van het boek voorkomt.

            SqlDataReader reader = null;
            SqlConnection connection = BooksAuthors.GetConnection();
            string selectStatement =
                "SELECT b.ISBN as ISBN, b.Titel as Titel, b.AuthorID as AuthorID, b.Pages as Pages, b.Genre as Genre, b.Content as Content, a.LastName as LastName, a.FirstName as FirstName " +
                "FROM Books AS b " +
                "INNER JOIN Authors as a ON a.AuthorID = b.AuthorID " +
                "WHERE b.Titel LIKE '%"+term+"%' ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //selectCommand.Parameters.AddWithValue("@Term", term);
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.ISBN = reader["ISBN"].ToString();
                    book.Titel = reader["Titel"].ToString();
                    book.AuthorID = (int)reader["AuthorID"];
                    book.Pages = (int)reader["Pages"];
                    book.Genre = reader["Genre"].ToString();
                    book.Content = reader["Content"].ToString();
                    book.Auteur = reader["LastName"].ToString();
                    book.Auteur = reader["FirstName"].ToString() + " " + book.Auteur;
                    boekenLijst.Add(book);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return boekenLijst;
        }  
    }
}
