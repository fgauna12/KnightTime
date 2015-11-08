using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using Mono.Data.Sqlite;
using Environment = System.Environment;

namespace GoodKnight.Backend
{
    public class DataBaseAccess
    {
        public static readonly string DatabaseFileName = "KnightTime.db3";
        public static string DatabaseFilePath { get; private set; }
        public DataBaseAccess()
        {

        }

        public static SqliteConnection GetConnection()
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db = Path.Combine(documents, DatabaseFileName);
            bool exists = File.Exists(db);
            if (!exists)
                SqliteConnection.CreateFile(db);
            DataBaseAccess.DatabaseFilePath = db;
            var conn = new SqliteConnection("Data Source=" + db);
            if (!exists)
            {
                var commands = new[] {
                "CREATE TABLE People (PersonID INTEGER NOT NULL, FirstName ntext, LastName ntext)",
                "INSERT INTO People (PersonID, FirstName, LastName) VALUES (1, 'First', 'Last')",
                "INSERT INTO People (PersonID, FirstName, LastName) VALUES (2, 'Dewey', 'Cheatem')",
                "INSERT INTO People (PersonID, FirstName, LastName) VALUES (3, 'And', 'How')",
            };
                foreach (var cmd in commands)
                    using (var c = conn.CreateCommand())
                    {
                        c.CommandText = cmd;
                        c.CommandType = CommandType.Text;
                        conn.Open();
                        c.ExecuteNonQuery();
                        conn.Close();
                    }
            }
            return conn;
        }

        public static void Write(SqliteDataReader reader, int index)
        {
            Console.Error.Write("({0} '{1}')",
                    reader.GetName(index),
                    reader[index]);
        }
    }
}