using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 数据库文件的具体路径，有的是.sqlite/.db
        // string path = "data source =" + Application.streamingAssetsPath + "/" + "first.db";
        string path = "data source =D:/db/first.db";
        Debug.Log(path);

        SQLite sql = new SQLite(path);

        SqliteDataReader reader1 = sql.InsertData("student", new string[] { "name", "score" }, new object[] { "'Sivan'", 99 });
        // 读取到的信息使用之后需要关闭
        reader1.Close();

        SqliteDataReader reader2 = sql.DeleteData("student", new string[] { "name = 'LONG'" });
        reader2.Close();




        sql.CloseDataBase();
    }

    
}