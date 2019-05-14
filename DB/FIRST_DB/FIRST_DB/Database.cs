﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Data.SQLite;

using System.IO;



namespace FIRST_DB

{

    class Database

    {

        public SQLiteConnection connection;



        public Database()

        {

            string dbName = @"C:\Users\Аскар\Documents\pp2\DB\intranet.db";

            connection = new SQLiteConnection(@"Data Source=" + dbName);

            if (!File.Exists(dbName))

            {

                Console.WriteLine("Database created");

                SQLiteConnection.CreateFile(dbName);

            }

        }



        public void OpenConnection()

        {

            if (connection.State != System.Data.ConnectionState.Open)

                connection.Open();

        }



        public void CloseConnection()

        {

            if (connection.State != System.Data.ConnectionState.Closed)

                connection.Close();

        }

    }

}