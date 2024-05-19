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
    public partial class DirectoryAreas : Form
    {
        private readonly Users user;
        public DirectoryAreas(Users user)
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
                //BtnSearch.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void DirectoryAreas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDirectoryArea.directoryarea". При необходимости она может быть перемещена или удалена.
            //this.directoryareaTableAdapter.Fill(this.dataDirectoryArea.directoryarea);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();

        }
        void GetData()
        {
            string query = "select * from scheme.directoryarea";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           // string query = "INSERT INTO  scheme.directoryarea (/*bankid,*/areaname) VALUES ('" /*+ txtIDBank.Text + "','"*/ + txtAreaName.Text + "')";
            string query = "INSERT INTO  scheme.directoryarea (/*bankid,*/areaname) VALUES (?)";
            command = new OdbcCommand(query, connection); 
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtAreaName.Text;
            if (txtAreaName.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                MessageBox.Show("Такой район уже добавлен в БД");
            else
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"Пользователь {user.Login} добавил новые данные в таблицу  Спрачоник районов:{label1.Text} {txtAreaName.Text} :" +
                        $" в {DateTime.Now}\n");
                }
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Район добавлен.");
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE scheme.directoryarea SET areaname=('" + txtAreaName.Text + "') WHERE areaid=('" + txtIDArea.Text + "')";
            string query = "UPDATE scheme.directoryarea SET areaname=(?) WHERE areaid=(?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtAreaName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDArea.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значения полей под индексом {txtIDArea.Text}" +
                    $" из таблицы Справочник районов:\n  " +
                    $" Название района - {dataGridView1.CurrentRow.Cells[1].Value}   на поле: {txtAreaName.Text}\n" +
                    $"  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           // string query = "DELETE FROM  scheme.directoryarea WHERE areaid=  ('" + txtIDArea.Text + "')";
            string query = "DELETE FROM  scheme.directoryarea WHERE areaid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDArea.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Спрачоник районов под индексом: {txtIDArea.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Район удален.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDArea.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.directoryarea where areaid= '" + Convert.ToInt32(txtIDArea.Text) + "'";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter = new OdbcDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIDArea.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAreaName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDArea.Enabled = false;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            txtAreaName.Enabled = false;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            txtAreaName.Enabled = false;
        }

        private void DirectoryAreas_MouseEnter(object sender, EventArgs e)
        {
            txtAreaName.Enabled = true;
            txtIDArea.Enabled = true;
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDArea.Enabled = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            excel.SaveExcel(dataGridView1, "directoryareas.xlsx");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            word.SaveWord(dataGridView1, "directoryareas.docx");
        }

        private void btnExcelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            if (dataGridView1.SelectedRows.Count > 0)
                excel.SaveExcelOne(dataGridView1, $"directoryarea{txtIDArea.Text}.xlsx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void btnWordOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            if (dataGridView1.SelectedRows.Count > 0)
                word.SaveWordOne(dataGridView1, $"directoryarea{txtIDArea.Text}.docx");
            else MessageBox.Show("Не выбрана строка");
        }
    }
}
