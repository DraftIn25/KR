using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_postgres
{
    public partial class DirectoryStreets : Form
    {
        private readonly Users user;
        public DirectoryStreets(Users user)
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
              //  BtnSearch.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void DirectoryStreets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDirectoryStreet.directorystreet". При необходимости она может быть перемещена или удалена.
          //  this.directorystreetTableAdapter.Fill(this.dataDirectoryStreet.directorystreet);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();
        }
        void GetData()
        {
            string query = "select * from scheme.directorystreet";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO  scheme.directorystreet (/*bankid,*/streetname,sign)" +
            // " VALUES ('" /*+ txtIDBank.Text + "','"*/ + txtStreetName.Text + "','"+txtSign.Text+"')";
            string query = "INSERT INTO  scheme.directorystreet (/*bankid,*/streetname,sign)" +
           " VALUES (?,?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtStreetName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSign.Text;
            if (txtStreetName.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString()||txtSign.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString())
                MessageBox.Show("Такой значение уже добавлено в БД");
            else
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"Пользователь {user.Login} добавил новые данные в таблицу  Справочник улиц:\n{label1.Text} - {txtStreetName.Text}" +
                        $"\n{label5.Text} - {txtSign.Text}" +
                        $" в {DateTime.Now}\n");
                }
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Улица добавлена.");
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE scheme.directorystreet SET streetname=('" + txtStreetName.Text + "'),sign=" +
            //    "('" + txtSign.Text + "') WHERE streetid=('" + txtIDStreet.Text + "')";
            string query = "UPDATE scheme.directorystreet SET streetname=(?),sign=" +
               "(?) WHERE streetid=(?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtStreetName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSign.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDStreet.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значения полей под индексом {txtIDStreet.Text}" +
                    $" из таблицы Справочник улиц:\n  " +
                    $" Название улицы - {dataGridView1.CurrentRow.Cells[1].Value}   на поле: {txtStreetName.Text}\n" +
                    $" Признак - {dataGridView1.CurrentRow.Cells[2].Value}   на поле: {txtSign.Text}\n" +
                    $"  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
         //   string query = "DELETE FROM  scheme.directorystreet WHERE streetid=  ('" + txtIDStreet.Text + "')";
            string query = "DELETE FROM  scheme.directorystreet WHERE streetid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDStreet.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Спрачоник улиц под индексом: {txtIDStreet.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Улица удалена.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDStreet.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.directorystreet where streetid= '" + Convert.ToInt32(txtIDStreet.Text) + "'";
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
            txtIDStreet.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtStreetName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSign.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDStreet.Enabled = false;
          //  txtIDStreet.Text = null;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            txtStreetName.Enabled = false;
            txtSign.Enabled = false;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            txtStreetName.Enabled = false;
            txtSign.Enabled = false;
        }

        private void DirectoryStreets_MouseEnter(object sender, EventArgs e)
        {
            txtIDStreet.Enabled = true;
            txtStreetName.Enabled = true;
            txtSign.Enabled = true;
            //txtIDStreet.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDStreet.Enabled = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            excel.SaveExcel(dataGridView1, "directorystreet.xlsx");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            word.SaveWord(dataGridView1, "directorystreet.docx");
        }

        private void btnExcelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            if (dataGridView1.SelectedRows.Count > 0)
                excel.SaveExcelOne(dataGridView1, $"directorystreet{txtIDStreet.Text}.xlsx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void btnWordOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            if (dataGridView1.SelectedRows.Count > 0)
                word.SaveWordOne(dataGridView1, $"directorystreet{txtIDStreet.Text}.docx");
            else MessageBox.Show("Не выбрана строка");
        }
    }
}
