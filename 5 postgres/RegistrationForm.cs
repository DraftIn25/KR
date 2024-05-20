using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _5_postgres
{
    public partial class RegistrationForm : Form
    {
        static public DateTime date= DateTime.Now;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
        private void Registrationbtn_Click(object sender, EventArgs e)
        {
                string query;
            string hash = Encrypt(textBox2.Text);
            if (checkBox1.Checked == true)
            {
                 query = "INSERT INTO  scheme.users (userlogin,userpassword,userrole,name,surname,date_password) VALUES ('" + textBox1.Text + "','" + hash + "','" + "admin" + "','" + textBox3.Text + "','" + textBox4.Text + "','" + date+"')";
            }
            else
            {
                 query = "INSERT INTO  scheme.users (userlogin,userpassword,userrole,name,surname,date_password) VALUES ('" + textBox1.Text + "','" + hash + "','" +"user"+"','"+ textBox3.Text + "','" + textBox4.Text + "','"+date+"')";
            }
            OdbcConnection conn = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
            OdbcCommand comm = new OdbcCommand(query, conn);
            if (textBox2.Text.Length <= 7)
            {
                MessageBox.Show("Введите пароль длины 8 и более символов");
            }
            else
            {
                conn.Open();
                string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($" Новый пользователь  зарегистрировался под  логином {textBox1.Text} в {DateTime.Now}\n");
                }
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("OK");
            }
        }
        static string Encrypt(string passwd)
        {
            string hash = "Password@2021$";
            byte[] data = UTF8Encoding.UTF8.GetBytes(passwd);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    tripleDESCryptoServiceProvider.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
                    byte[] result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query;
            string hash = Encrypt(textBox2.Text);
                 query = "UPDATE scheme.users SET userpassword=('" + Encrypt(textBox2.Text) + "')" +
                     ",date_password=('" + DateTime.Now + "')" +
                     "WHERE userlogin = ('" + textBox1.Text + "')";            
            OdbcConnection conn = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
            OdbcCommand comm = new OdbcCommand(query, conn);
            if (textBox2.Text.Length <= 7)
            {
                MessageBox.Show("Введите пароль длины 8 и более символов");
            }
            else
            {
                conn.Open();
                string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($" Пользователь   под  логином {textBox1.Text} обновил пароль в {DateTime.Now}\n");
                }
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("OK");
            }
        }
        //static string Decrypt(string passwd)
        //{
        //    string hash = "Password@2021$";
        //    byte[] data = Convert.FromBase64String(passwd);
        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //        using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        //        {
        //            tripleDESCryptoServiceProvider.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //            ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
        //            byte[] result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
        //            return UTF8Encoding.UTF8.GetString(result);
        //        }
        //    }
        //}
    }
}