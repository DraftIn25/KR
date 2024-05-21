using _5_postgres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.Odbc;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest3
    {
        OdbcConnection connection = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
        OdbcCommand command;
        OdbcDataAdapter adapter;
        public DataTable datatable;
        [TestMethod]
        public void DeleteUser()
        {
            string query = "DELETE FROM  scheme.users WHERE userid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", 27);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        [TestMethod]
        public void UpdateUsser()
        {
            string query = "UPDATE scheme.users SET date_password=(?) WHERE userid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "25.05.2024");
            command.Parameters.Add("?", 25);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        string GetData(string text)
        {
            string query = text;
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            datatable = new System.Data.DataTable();
            adapter.Fill(datatable);
            connection.Close();
            return datatable.Rows[0]["userid"].ToString();
        }
        [TestMethod]
        public void FalseDeleteUser()
        {
            string query = "DELETE FROM  scheme.users WHERE userid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "237");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"237", GetData($"select userid from scheme.users where userid={237}").ToString());
        }
        public void SetUser(int min, int max, bool Up, bool spec)
        {
            Users.MinLength = min;
            Users.MaxLength = max;
            Users.Upper = Up;
            Users.Symbols = spec;
        }

        [TestMethod]
        public void TestPass1()
        {
            SetUser(4, 10, false, false);
            Assert.AreEqual(true, Users.Pass("12345"));
            Assert.AreEqual(false, Users.Pass("abcde"));
        }
        [TestMethod]
        public void TestPass2()
        {
            SetUser(8, 10, true, true);
            Assert.AreEqual(true, Users.Pass("AbcD33#$822"));
        }
        [TestMethod]
        public void TestPass3()
        {
            SetUser(2, 5, true, false);
            Assert.AreEqual(true, Users.Pass("Ab3FF"));
        }
        [TestMethod]
        public void TestPass4()
        {
            SetUser(10, 20, true, true);
            Assert.AreEqual(false, Users.Pass("ABCDffdfd$%%%%%333*()#34GGytQ"));
        }
        string GetUser(string text)
        {
            string query = text;
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            datatable = new System.Data.DataTable();
            adapter.Fill(datatable);
            connection.Close();
            return datatable.Rows[0]["userpassword"].ToString();
        }
        [TestMethod]
        public void Author1()
        {
            string query = $"select userlogin=(?),userpassword=(?) from scheme.users where userid={1}";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "User1");
            command.Parameters.Add("?", "123456");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"123456", GetUser($"select userpassword from scheme.users where userid={1}").ToString());
        }
        string GetLogin(string text)
        {
            string query = text;
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            datatable = new System.Data.DataTable();
            adapter.Fill(datatable);
            connection.Close();
            return datatable.Rows[0]["userlogin"].ToString();
        }
        [TestMethod]
        public void Author2()
        {
            string query = $"select userlogin=(?),userpassword=(?) from scheme.users where userid={1}";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "User1");
            command.Parameters.Add("?", "123456");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"User1", GetLogin($"select userlogin from scheme.users where userid={1}").ToString());
        }
        [TestMethod]
        public void Author3()
        {
            string query = $"select userlogin=(?),userpassword=(?) from scheme.users where userid={1}";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", "User2");
            command.Parameters.Add("?", "123456");
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Assert.AreEqual($"User2", GetLogin($"select userlogin from scheme.users where userid={1}").ToString());
        }
    }
}
