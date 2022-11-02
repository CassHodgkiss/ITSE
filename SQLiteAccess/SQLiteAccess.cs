using System;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
using System.Transactions;

namespace SQLiteDataAccess
{
    public class SQLiteAccess // Some Code From https://www.youtube.com/watch?v=ayp3tHEkRc0 AND https://www.youtube.com/watch?v=eKkh5Xm0OlU
    {
        //Execute SQL commands with parameters, no return types
        public static void Write(string sql, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            cnn.Execute(sql, param);
        }

        //Execute SQL commands with peramters, return type of List<T> such that T inherites ModelBase, this will hold all the returned data
        public static List<T> Read<T>(string sql, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            var output = cnn.Query<T>(sql, param);
            return output.ToList();
        }

        public static int WriteReturnPk(string sql, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            sql += @"; Select last_insert_rowid()";
            int id = cnn.QuerySingle<int>(sql, param);
            return id;
        }

        // Loads Multiple Tables into one Model, using a mapping
        // T => Full Model | U => Model to be put into T
        public static List<T> Read<T, U>(string sql, Func<T, U, T> map, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            var people = cnn.Query(sql, map, param);
            return people.ToList();
        }

        public static List<T> Read<T, U, V>(string sql, Func<T, U, V, T> map, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            var people = cnn.Query(sql, map, param);
            return people.ToList();
        }

        public static List<T> Read<T, U, V, X>(string sql, Func<T, U, V, X, T> map, object param)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConfigString());
            var people = cnn.Query(sql, map, param);
            return people.ToList();
        }

        //Loads the Filepath to the SQL Database from the App.config file
        static string LoadConfigString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
