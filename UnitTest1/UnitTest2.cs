using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using _5_postgres;


namespace UnitTest1
{
    [TestClass]
    public class UnitTest2
    {
        OdbcConnection connection = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
        OdbcCommand command;
        OdbcDataAdapter adapter;
        public DataTable datatable;
        [TestMethod]
        public void TestBanks()
        {
            string query = "INSERT INTO  scheme.bank (/*bankid,*/bankname) VALUES (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?","Осом");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        [TestMethod]
        public void TestInserting()
        {
            string query = "INSERT INTO  scheme.bank (/*bankid,*/bankname) VALUES (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "Осом");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"Осон", GetData($"select bankname from scheme.bank where bankid={25}","bankname").ToString());

        }
        [TestMethod]
        public void TestSelectBanks()
        {
            string query = $"select bankname from scheme.bank where bankid={1}";
            command = new OdbcCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"Сбербанк",GetData($"select bankname from scheme.bank where bankid={1}","bankname").ToString());

        }
        [TestMethod]
        public void TestDeleteBanks()
        {
            string query = "DELETE FROM  scheme.bank WHERE bankid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", 23);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        [TestMethod]
        public void TestFalseDeleteBanks()
        {
            string query = "DELETE FROM  scheme.bank WHERE bankid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", 40);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"40", GetData($"select bankid={40} from scheme.bank","bankid").ToString());

        }
        [TestMethod]
        public void UpdateBanks()
        {
            string query = "UPDATE scheme.bank SET bankname=(?) WHERE bankid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "Ольха");
            command.Parameters.Add("?", 23);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        string  GetData(string text,string column)
        {
            string query = text;
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            datatable= new System.Data.DataTable();
           adapter.Fill(datatable);
            connection.Close();
            return datatable.Rows[0][$"{column}"].ToString();
        }
    }
}
