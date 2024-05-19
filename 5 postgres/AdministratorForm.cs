using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_postgres
{
    public partial class AdministratorForm : Form
    {
        private readonly Users user;
        public AdministratorForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            GetData();
        }
        OdbcConnection connection = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
        OdbcCommand command;
        OdbcDataAdapter adapter;
        private void IsAdmin()
        {
            if (user.Role == "user")
            {
                BtnAdd.Enabled = false;
                BtnChange.Enabled = false;
                BtnSearch.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataUsers.users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.dataUsers.users);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();
        }

        void GetData()
        {
            string query = "select * from scheme.users";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string hash = Encrypt(txtUserPassword.Text);
            if (txtUserRole.Text == "user" || txtUserRole.Text == "admin")
            {
                string query = "INSERT INTO  scheme.users (userlogin,userpassword,userrole,name,surname) VALUES('" + txtUserLogin.Text
         + "', '" + hash + "', '" + txtUserRole.Text + "', '"
         + txtName.Text + "','" + txtSurname.Text + "')";
                command = new OdbcCommand(query, connection);
                if (txtUserLogin.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                    MessageBox.Show("Такой пользователь уже добавлен в БД");
                else
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                    MessageBox.Show("Пользователь добавлен.");
                }
            }
            else
            {
                MessageBox.Show("Такой роли нет! ВВедите роль user или admin!");
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (txtUserRole.Text == "user" || txtUserRole.Text == "admin")
            {
                string query = "UPDATE scheme.users SET userlogin=('" + txtUserLogin.Text + "'),userpassword=('" + txtUserPassword.Text + "')" +
         ",userrole=('" + txtUserRole.Text + "'),name=('" + txtName.Text + "'),surname=('" + txtSurname.Text + "')  " +
         "WHERE userid = ('" + txtIDUser.Text + "')";
                command = new OdbcCommand(query, connection);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
            }
            else
            {
                MessageBox.Show("Такой роли нет! Введите роль user или admin!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM  scheme.users WHERE userid=  ('" + txtIDUser.Text + "')";
            command = new OdbcCommand(query, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Пользователь удален.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDUser.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.users where userid= '" + Convert.ToInt32(txtIDUser.Text) + "'";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter = new OdbcDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIDUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUserLogin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUserPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUserRole.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDUser.Enabled = false;
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDUser.Enabled = false;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = false;
            txtUserPassword.Enabled = false;
            txtUserRole.Enabled = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = false;
            txtUserPassword.Enabled = false;
            txtUserRole.Enabled = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
        }

        private void AdministratorForm_MouseEnter(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = true;
            txtUserPassword.Enabled = true;
            txtUserRole.Enabled = true;
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtIDUser.Enabled = true;
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
    }
}
