using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;

string connectionString = "Data Source=students.db;Version=3;";
using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    // тут ви можете виконувати SQL-запити і працювати з базою даних
    string query;
    query = "UPDATE Students SET StudentId=@id, StudentName=@name WHERE StudentId=23";
    using (SQLiteCommand command = new SQLiteCommand(query, connection))
    {
        command.Parameters.AddWithValue("@id", 24);
        command.Parameters.AddWithValue("@name", "Максим Стаднійчук");
        command.ExecuteNonQuery();
    } 
    /*
    query = "DELETE FROM Students WHERE id=@id";
    using (SQLiteCommand command = new SQLiteCommand(query, connection))
    {
    command.Parameters.AddWithValue("@id", 1);
    command.ExecuteNonQuery();
    }
    */
    connection.Close();
}
