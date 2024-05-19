using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Npgsql;

namespace _5_postgres
{
    public partial class Halls : Form
    {
        private readonly Users user;
        public Halls(Users user)
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
               // BtnSearch.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void Halls_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHalls.halls". При необходимости она может быть перемещена или удалена.
           // this.hallsTableAdapter.Fill(this.dataHalls.halls);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();

        }
        void GetData()
        {
            string query = "select * from scheme.halls";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO  scheme.halls (square,size,floor,phonehall,decoration,renterid)" + " VALUES " +
            //    "('" + txtSquare.Text + "','" + txtSize.Text + "','" + txtFloor.Text + "','" 
            //    + ckbPhoneHall.Checked + "','" + comboDecoration.Text +"','" + txtRenterID.Text + "')";
            string query = "INSERT INTO  scheme.halls (square,size,floor,phonehall,decoration,renterid) VALUES (?,?,?,?,?,?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSquare.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSize.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtFloor.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = ckbPhoneHall.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = comboDecoration.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterID.Text;
            if (connection.State == ConnectionState.Closed)
                    connection.Open();
                   string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"Пользователь {user.Login} добавил новые данные в таблицу  Помещения" +
                        $":\n" +
                        $"{label10.Text} - {txtSquare.Text}" +
                        $"\n{label12.Text} - {txtSize.Text}" +
                        $"\n{label13.Text} - {txtFloor.Text}" +
                        $"\n{label14.Text} - {ckbPhoneHall.Text}" +
                        $"\n{label9.Text} - {comboDecoration.Text}" +
                        $"\n{label16.Text} - {txtRenterID.Text}" +
                        $" в {DateTime.Now}\n");
                }
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Помещение добавлено.");           
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
          //  string query = "UPDATE scheme.halls SET square=('" + txtSquare.Text + "'),size=('" + txtSize.Text + "')" +
          //",floor=('" + txtFloor.Text + "'),phonehall=('" + ckbPhoneHall.Checked + "'),decoration=('" + comboDecoration.Text + "')" +
          //",renterid=('" + txtRenterID.Text + "') WHERE hallid=('" + txtIDHall.Text + "')";
            string query = "UPDATE scheme.halls SET square=(?),size=(?)" +
        ",floor=(?),phonehall=(?),decoration=(?)" +
        ",renterid=(?) WHERE hallid=(?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSquare.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSize.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtFloor.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = ckbPhoneHall.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = comboDecoration.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDHall.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значения полей под индексом {txtIDHall.Text}" +
                    $" из таблицы Помещения:\n  " +
                    $" Площадь - {dataGridView1.CurrentRow.Cells[1].Value}   на поле: {txtSquare.Text}\n" +
                    $" Размеры - {dataGridView1.CurrentRow.Cells[2].Value}   на поле: {txtSize.Text}\n" +
                    $" Этаж - {dataGridView1.CurrentRow.Cells[3].Value}   на поле: {txtFloor.Text}\n" +
                    $" Домашний телефон - {dataGridView1.CurrentRow.Cells[4].Value}   на поле: {ckbPhoneHall.Text}\n" +
                    $" Отделка - {dataGridView1.CurrentRow.Cells[5].Value}   на поле: {comboDecoration.Text}\n" +
                    $" ID арендатора - {dataGridView1.CurrentRow.Cells[6].Value}   на поле: {txtRenterID.Text}\n" +
                    $"  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM  scheme.halls WHERE hallid=  ('" + txtIDHall.Text + "')";
            string query = "DELETE FROM  scheme.halls WHERE hallid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDHall.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Помещения под индексом: {txtIDHall.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Помещение удалено.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDHall.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.halls where hallid= '" + Convert.ToInt32(txtIDHall.Text) + "'";
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
            txtIDHall.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSquare.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSize.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFloor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ckbPhoneHall.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboDecoration.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRenterID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (ckbPhoneHall.Text == "0")
                ckbPhoneHall.Checked = false;
            else
                ckbPhoneHall.Checked = true;
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDHall.Enabled = false;
           // txtIDHall.Text = null;
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDHall.Enabled = false;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            txtSquare.Enabled = false;
            txtSize.Enabled = false;
            txtFloor.Enabled = false;
            ckbPhoneHall.Enabled = false;
            comboDecoration.Enabled = false;
            txtRenterID.Enabled = false;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            txtSquare.Enabled = false;
            txtSize.Enabled = false;
            txtFloor.Enabled = false;
            ckbPhoneHall.Enabled = false;
            comboDecoration.Enabled = false;
            txtRenterID.Enabled = false;
        }

        private void Halls_MouseEnter(object sender, EventArgs e)
        {
            txtSquare.Enabled = true;
            txtSize.Enabled = true;
            txtFloor.Enabled = true;
            ckbPhoneHall.Enabled = true;
            comboDecoration.Enabled = true;
            txtRenterID.Enabled = true;
            txtIDHall.Enabled = true;
          //  txtIDHall.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ckbPhoneHall_Click(object sender, EventArgs e)
        {
            if (ckbPhoneHall.Checked == false)
                ckbPhoneHall.Text = "0";
            else
                ckbPhoneHall.Text = "1";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            excel.SaveExcel(dataGridView1, "halls.xlsx");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            word.SaveWord(dataGridView1, "halls.docx");
        }

        private void btnExcelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            if (dataGridView1.SelectedRows.Count > 0)
                excel.SaveExcelOne(dataGridView1, $"halls{txtIDHall.Text}.xlsx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void btnWordOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            if (dataGridView1.SelectedRows.Count > 0)
                word.SaveWordOne(dataGridView1, $"halls{txtIDHall.Text}.docx");
            else MessageBox.Show("Не выбрана строка");
        }
    }
}
