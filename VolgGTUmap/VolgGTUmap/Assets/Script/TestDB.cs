using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class TestDB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string conn = "URI=file:" + Application.dataPath + "/Plugins/VolgGTUunity.db";
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);      //IDbConnection dbcon = new SqliteConnection(conn);
        dbconn.Open();

        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM Faculty";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int ID_faculty = reader.GetInt32(0);
            string Name = reader.GetString(1);
            string Dean = reader.GetString(2);
            //string FullName = reader.GetString(3);
            //string Link = reader.GetString(4);
            //string Deanery = reader.GetString(5);

            Debug.Log("val: " + ID_faculty + " Наименование:" + Name + " Декан:" + Dean); // + " FullName:" + FullName + " Link:" + Link + " Deanery:" + Deanery);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
