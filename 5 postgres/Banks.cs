using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_postgres
{
    public partial class Banks : Form
    {
        private readonly Users user;
        public Banks(Users user)
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
        private void Banks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.bank". При необходимости она может быть перемещена или удалена.
           // this.bankTableAdapter.Fill(this.dataSet1.bank);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();
            //txtIDBank.Enabled= false;
        }
        void GetData()
        {
            string query = "select * from scheme.bank";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO  scheme.bank (/*bankid,*/bankname) VALUES ('" /*+ txtIDBank.Text + "','"*/ + txtBankName.Text + "')";
            string query = "INSERT INTO  scheme.bank (/*bankid,*/bankname) VALUES (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtBankName.Text;
                if (txtBankName.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Такой банк уже добавлен в БД");
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string file = @"log.txt";
                    using (StreamWriter sw = new StreamWriter(file, true))
                    {
                        sw.WriteLine($"Пользователь {user.Login}  добавил новые данные в таблицу Банки: {label1.Text}: {txtBankName.Text}  в {DateTime.Now}\n");
                    }
                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                    MessageBox.Show("Банк добавлен.");
                }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM  scheme.bank WHERE bankid=  ('" + txtIDBank.Text + "')";
            string query = "DELETE FROM  scheme.bank WHERE bankid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDBank.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Банки под индексом: {txtIDBank.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Банк удален.");
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE scheme.bank SET bankname=('" + txtBankName.Text + "') WHERE bankid=('" + txtIDBank.Text + "')";
            string query = "UPDATE scheme.bank SET bankname=  (?) WHERE bankid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtBankName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDBank.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значение поля Название банка:{dataGridView1.CurrentRow.Cells[1].Value} под индексом {txtIDBank.Text} из таблицы Банки на поле: {txtBankName.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDBank.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.bank where bankid= '" + Convert.ToInt32(txtIDBank.Text) + "'";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter = new OdbcDataAdapter(query, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            txtBankName.Enabled = false;
        }

        private void Banks_MouseEnter(object sender, EventArgs e)
        {
            txtBankName.Enabled = true;
            txtIDBank.Enabled = true;
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDBank.Enabled = false;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            txtBankName.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBank.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBankName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDBank.Enabled = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            excel.SaveExcel(dataGridView1, "banks.xlsx");
        }
        private void btnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words words = new Words();
            words.SaveWord(dataGridView1, "banks.docx");
        }

        private void btnExcelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            if (dataGridView1.SelectedRows.Count > 0)
                excel.SaveExcelOne(dataGridView1, $"banks{txtIDBank.Text}.xlsx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void btnWordOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            if (dataGridView1.SelectedRows.Count > 0)
                word.SaveWordOne(dataGridView1, $"banks{txtIDBank.Text}.docx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
