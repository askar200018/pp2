using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Data.SQLite;



namespace FIRST_DB

{

    class Program

    {

        static void Main(string[] args)

        {

            Database database = new Database();

            string query = "insert into students(name, surname) values(@name, @surname)";

            database.OpenConnection();

            SQLiteCommand command = new SQLiteCommand(query, database.connection);

            command.Parameters.AddWithValue("@name", "name3");

            command.Parameters.AddWithValue("@surname", "surname3");

            command.ExecuteNonQuery();

            database.CloseConnection();

            Console.ReadKey();


                // SELECT EXAMPLE

             

            //Database database = new Database();

            //string query = "select * from students where id > 1";

            //database.OpenConnection();

            //SQLiteCommand command = new SQLiteCommand(query, database.connection);

            //SQLiteDataReader result = command.ExecuteReader();



            //if (result.HasRows)

            //{

            //    while (result.Read())

            //    {

            //        Console.WriteLine("id: {2}, name: {0}, surname: {1}", result["name"], result["surname"], result["id"]);

            //    }

            //}

            //database.CloseConnection();

            Console.ReadKey();



        }

    }

}
 