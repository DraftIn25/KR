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
    public partial class Contracts : Form
    {
        private readonly Users user;
        public Contracts(Users user)
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
        private void Contracts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataContracts.contracts". При необходимости она может быть перемещена или удалена.
          //  this.contractsTableAdapter.Fill(this.dataContracts.contracts);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();
        }
        void GetData()
        {
            string query = "select * from scheme.contracts";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO  scheme.contracts (valid,datestart,datestop,period,value,tax,renterid)" + " VALUES " +
           "(?,?,?,?,?,?,?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = ckbValid.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = dtmStart.Value;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = dtmStop.Value;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = comboPeriod.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtValue.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtTax.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDRenter.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login} добавил новые данные в таблицу  Договоры:{label10.Text} {ckbValid.Text} :" +
                    $"{label12.Text} {dtmStart.Text} : {label13.Text} {dtmStop.Text} :  {label14.Text}  {comboPeriod.Text} :  {label9.Text}  {txtValue.Text} :" +
                    $"{label16.Text}  {txtTax.Text}  :  {label1.Text}  {txtIDRenter.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close(); 
            GetData();
            MessageBox.Show("Договор добавлен.");

        }

            private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
            {
                txtIDContract.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ckbValid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtmStart.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtmStop.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboPeriod.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtValue.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTax.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtIDRenter.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                if (ckbValid.Text == "0")
                    ckbValid.Checked = false;
                else
                    ckbValid.Checked = true;

            }

            private void BtnChange_Click(object sender, EventArgs e)
            {
            //   string query = "UPDATE scheme.contracts SET valid=('" + ckbValid.Checked + "'),datestart=('" + dtmStart.Value + "')" +
            //",datestop=('" + dtmStop.Value + "'),period=('" + comboPeriod.Text + "'),value=('" + txtValue.Text + "')" +
            //",tax=('" + txtTax.Text + "'),renterid=('" + txtIDRenter.Text + "') WHERE contractid=('" + txtIDContract.Text + "')";
            string query = "UPDATE scheme.contracts SET valid=(?),datestart=(?)" +
        ",datestop=(?),period=(?),value=(?)" +
        ",tax=(?),renterid=(?) WHERE contractid=(?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = ckbValid.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = dtmStart.Value;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = dtmStop.Value;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = comboPeriod.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtValue.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtTax.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDRenter.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDContract.Text;
            if (connection.State == ConnectionState.Closed)
                    connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значения полей под индексом {txtIDContract.Text}" +
                    $" из таблицы Договоры:\n  " +
                    $" Действителен/Недействителен - {dataGridView1.CurrentRow.Cells[1].Value}   на поле: {ckbValid.Text}\n" +
                    $" Дата начала договора - {dataGridView1.CurrentRow.Cells[2].Value}   на поле: {dtmStart.Text}\n" +
                    $" Дата окончания договора- {dataGridView1.CurrentRow.Cells[3].Value}   на поле: {dtmStop.Text}\n" +
                    $" Периодичность оплаты - {dataGridView1.CurrentRow.Cells[4].Value}   на поле: {comboPeriod.Text}\n" +
                    $" Сумма - {dataGridView1.CurrentRow.Cells[5].Value}   на поле: {txtValue.Text}\n" +
                    $" Штраф - {dataGridView1.CurrentRow.Cells[6].Value}   на поле: {txtTax.Text}\n" +
                    $" ID арендатора - {dataGridView1.CurrentRow.Cells[7].Value}   на поле: {txtIDRenter.Text}\n" +
                    $"  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
                connection.Close();
                GetData();
            }

            private void BtnDelete_Click(object sender, EventArgs e)
            {
               // string query = "DELETE FROM  scheme.contracts WHERE contractid=  ('" + txtIDContract.Text + "')";
                string query = "DELETE FROM  scheme.contracts WHERE contractid=  (?)";
                command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDContract.Text;
            if (connection.State == ConnectionState.Closed)
                    connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Договоры под индексом: {txtIDContract.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Договор удален.");
            }

            private void BtnSearch_Click(object sender, EventArgs e)
            {
                if (txtIDContract.Text == "")
                    GetData();
                else
                {
                    string query = "select * from scheme.contracts where contractid= '" + Convert.ToInt32(txtIDContract.Text) + "'";
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    adapter = new OdbcDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
            }

            private void BtnAdd_MouseEnter(object sender, EventArgs e)
            {
                //txtIDContract.Text = null;
                txtIDContract.Enabled = false;
            }

            private void BtnChange_MouseEnter(object sender, EventArgs e)
            {
                txtIDContract.Enabled = false;
            }

            private void BtnDelete_MouseEnter(object sender, EventArgs e)
            {
                txtIDRenter.Enabled = false;
                ckbValid.Enabled = false;
                dtmStart.Enabled = false;
                dtmStop.Enabled = false;
                comboPeriod.Enabled = false;
                txtValue.Enabled = false;
                txtTax.Enabled = false;
            }

            private void BtnSearch_MouseEnter(object sender, EventArgs e)
            {
                txtIDRenter.Enabled = false;
                ckbValid.Enabled = false;
                dtmStart.Enabled = false;
                dtmStop.Enabled = false;
                comboPeriod.Enabled = false;
                txtValue.Enabled = false;
                txtTax.Enabled = false;
            }

            private void Contracts_MouseEnter(object sender, EventArgs e)
            {
                txtIDRenter.Enabled = true;
                ckbValid.Enabled = true;
                dtmStart.Enabled = true;
                dtmStop.Enabled = true;
                comboPeriod.Enabled = true;
                txtValue.Enabled = true;
                txtTax.Enabled = true;
                txtIDContract.Enabled = true;
               // txtIDContract.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            private void ckbValid_Click(object sender, EventArgs e)
            {
                if (ckbValid.Checked == false)
                    ckbValid.Text = "0";
                else
                    ckbValid.Text = "1";
            }

            private void btnExcel_Click(object sender, EventArgs e)
            {
                this.Hide();
                Exceles excel = new Exceles();
                excel.SaveExcel(dataGridView1, "contracts.xlsx");
            }

            private void btnWord_Click(object sender, EventArgs e)
            {
                this.Hide();
                Words word = new Words();
                word.SaveWord(dataGridView1, "contracts.docx");
            }

            private void btnExcelOne_Click(object sender, EventArgs e)
            {
                this.Hide();
                Exceles excel = new Exceles();
                if (dataGridView1.SelectedRows.Count > 0)
                    excel.SaveExcelOne(dataGridView1, $"contracts{txtIDContract.Text}.xlsx");
                else MessageBox.Show("Не выбрана строка");
            }

            private void btnWordOne_Click(object sender, EventArgs e)
            {
                this.Hide();
                Words word = new Words();
                if (dataGridView1.SelectedRows.Count > 0)
                    word.SaveWordOne(dataGridView1, $"contracts{txtIDContract.Text}.docx");
                else MessageBox.Show("Не выбрана строка");
            }
    }
 }
