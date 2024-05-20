using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Odbc;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Web.Security;
using System.Security.Policy;
using System.Web.UI.WebControls;
using System.IO;

namespace _5_postgres
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataU.users". При необходимости она может быть перемещена или удалена.
          //  this.usersTableAdapter1.Fill(this.dataU.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataUsers.users". При необходимости она может быть перемещена или удалена.
          //  this.usersTableAdapter.Fill(this.dataUsers.users);
            passwdBox.PasswordChar = '*';
    }
        private void button1_Click(object sender, EventArgs e)
        {
            string hash=Encrypt(passwdBox.Text);
            OdbcConnection conn = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
            OdbcDataAdapter adapter = new OdbcDataAdapter("select * from scheme.users where userlogin='" + loginBox.Text + "' and userpassword='" + hash + "'", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //if (DateTime.Now.Day - AdministratorForm.date.Day >= 7)
            //{
            //    MessageBox.Show("Время действия пароля вышло необходимо его сменить. Введите свои данные и новый пароль");
            //    RegistrationForm registrationForm=new RegistrationForm();
            //    registrationForm.ShowDialog();
                
            //}
            //else
            //{
                if (dataTable.Rows.Count == 1)
                {
                    var user = new Users(dataTable.Rows[0].ItemArray[1].ToString(), dataTable.Rows[0].ItemArray[3].ToString());
                    Tables fm = new Tables(user);
                    fm.ShowDialog();
                    loginBox.Text = null;
                    passwdBox.Text = null;
                }
                else
                {
                    MessageBox.Show("Неправильно ввели логин или пароль. Попробуйте снова!");
                }
            //}
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
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form= new RegistrationForm();  
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button2.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            if (passwdBox.PasswordChar == '*')
            {
                passwdBox.PasswordChar = '\0';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            button2.Visible = true;
            button2.Enabled = true;
            if (passwdBox.PasswordChar == '\0')
            {
                passwdBox.PasswordChar = '*';
            }
        }
    }
}
