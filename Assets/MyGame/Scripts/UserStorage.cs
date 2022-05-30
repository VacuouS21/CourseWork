using UnityEngine;
using System.Data;

using System.IO;
using System;
using Mono.Data.Sqlite;
using System.Data;


public class UserStorage 
{
    private int id;
    private string name;
    private int easy;
    private int medium;
    private int hard;
    private int bossReady;
    private string bossMax;

    private string connectionString;
    private static string DBPath;
    //private static SqliteConnection connection;
   // private static SqliteCommand command;
    private  string fileName;
    public UserStorage( string nameIn)
    {
        name = nameIn;
        connectionString = "URI=file:" + Application.dataPath + "/DB/UserInfo.db";
        createTable();
        createUser(name);
       // createUser(name);
    }

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Easy { get => easy; set => easy = value; }
    public int Medium { get => medium; set => medium = value; }
    public int Hard { get => hard; set => hard = value; }
    public int BossReady { get => bossReady; set => bossReady = value; }
    public string BossMax { get => bossMax; set => bossMax = value; }


    private void createTable() {
        string path = Application.dataPath+ "/DB/UserInfo.db";
        this.fileName = path;
        FileInfo fileInfo = new FileInfo(path);
        if (fileInfo.Exists)
        {
            Console.WriteLine($"Имя файла: {fileInfo.Name}");
            Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
            Console.WriteLine($"Размер: {fileInfo.Length}");
            newDataBase();
        }
        else
        {
            fileInfo.Create();
            newDataBase();
        }
    }
    private bool checkUser(string myName) {
        return false;
    }
    

    private void createUser(string myName) {

         using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();
                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sql = String.Format("SELECT * FROM UserInfo WHERE name=\"{0}\"",myName);
                dbCmd.CommandText = sql;
                bool checkName = false;
                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Debug.Log(reader.GetValue(1));
                        // Взять всю инфу.
                        easy = reader.GetInt32(2);
                        medium= reader.GetInt32(3); 
                        hard= reader.GetInt32(4);
                        bossReady=reader.GetInt32(5);
                        bossMax= reader.GetString(6);
                        Debug.Log(name+" "+easy+" "+medium+" "+bossMax);
                        dbConnection.Close();
                        reader.Close();
                        return;
                    }
                    else
                    {
                        checkName = true;
                    }
                   
                }
                if (checkName)
                {
                    string sqlNew = String.Format("INSERT INTO UserInfo(name,light,medium,hight,bossLevel,mark) VALUES(\"{0}\",0,0,0,0,'Не пройден')", myName);
                    dbCmd.CommandText = sqlNew;
                    Debug.Log(sqlNew);
                    dbCmd.ExecuteScalar();
                    dbConnection.Close();

                }
            }
                
            }

       /* 
        else
        {
            //Создать нулёвого чела.
            
            string sql = String.Format("INSERT INTO UserInfo(name,light,medium,hight,bossLevel,mark) VALUES(\"{0}\",0,0,0,0,'hi')",myName);
            executeSQL(sql);
        }*/
    }

    public void newDataBase()
    {
        string sql = "CREATE TABLE IF NOT EXISTS UserInfo(" +


"id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +

"name TEXT NOT NULL," +
"light INTEGER NOT NULL, " +
"medium INTEGER NOT NULL," +
"hight INTEGER NOT NULL, " +

"bossLevel INTEGER NOT NULL," +
"mark TEXT NOT NULL" +
")";
        executeSQL(sql);
    }
    public void executeSQL(string sqlString)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
               


                dbCmd.CommandText = sqlString;
                Debug.Log(sqlString);
                dbCmd.ExecuteScalar();
                dbConnection.Close();
            }
        }
      
    }

    public void updateUser(int first,int second, int third, int four, string last) 
    {
        string sql = String.Format("UPDATE UserInfo SET light =\"{0}\",medium=\"{1}\",hight=\"{2}\", bossLevel=\"{3}\",mark=\"{4}\" WHERE name=\"{5}\";",first,second,third,four,last,name);
        executeSQL(sql);
    }

}
