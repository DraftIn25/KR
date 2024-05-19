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
using System.IO;
using Excel= Microsoft.Office.Interop.Excel;
using Word=Microsoft.Office.Interop.Word;
using System.Globalization;

namespace _5_postgres
{
    public partial class Renters : Form
    {
        private readonly Users user;
        public Renters(Users user)
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
        private void Renters_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataRenters.renters". При необходимости она может быть перемещена или удалена.
            //this.rentersTableAdapter.Fill(this.dataRenters.renters);
            labelRole.Text = $"Логин:{user.Login} роль:{user.Role}";
            IsAdmin();

        }
        void GetData()
        {
            string query = "select * from scheme.renters";
            adapter = new OdbcDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //     string query = "INSERT INTO  scheme.renters (rentertype,surname,name,patronymic,rentercompany,renterinn," +
            //         "chiefsurname,chiefname,chiefpatronymic,phone,streetid,housenumber,apartment,areaid,bankid)" +
            //" VALUES ('"+ checkBoxType.Checked + "','" + txtSurname.Text + "','" + txtname.Text + "','" + txtPatronymic.Text + "','" + txtRenterCompany.Text +
            // "','" + txtRenterINN.Text + "','" + txtChiefSurname.Text + "','" + txtChiefName.Text + "','" + txtChiefPatronymic.Text + "','" + txtPhone.Text +
            //  "','" + txtStreetID.Text + "','" + txtHouseNumber.Text + "','" + txtApartment.Text + "','" + txtAreaID.Text +
            //   "','" + txtBankID.Text + "')";
            string query = "INSERT INTO  scheme.renters (rentertype,surname,name,patronymic,rentercompany,renterinn," +
                   "chiefsurname,chiefname,chiefpatronymic,phone,streetid,housenumber,apartment,areaid,bankid)" +
          " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = checkBoxType.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSurname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtPatronymic.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterCompany.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterINN.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefSurname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefPatronymic.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtPhone.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtStreetID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtHouseNumber.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtApartment.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtAreaID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtBankID.Text;
            //if (   txtSurname.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString()
            //    || txtname.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString()
            //    || txtPatronymic.Text == dataGridView1.CurrentRow.Cells[4].Value.ToString()
            //    || txtRenterCompany.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString()
            //    || txtRenterINN.Text == dataGridView1.CurrentRow.Cells[6].Value.ToString()
            //    || txtChiefSurname.Text == dataGridView1.CurrentRow.Cells[7].Value.ToString()
            //    || txtChiefName.Text == dataGridView1.CurrentRow.Cells[8].Value.ToString()
            //    || txtChiefPatronymic.Text == dataGridView1.CurrentRow.Cells[9].Value.ToString()
            //    || txtPhone.Text == dataGridView1.CurrentRow.Cells[10].Value.ToString()
            //    )
            //    MessageBox.Show("Такой значение уже добавлено в БД");
            //else
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string file = @"log.txt";
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"Пользователь {user.Login} добавил новые данные в таблицу  Арендаторы" +
                        $":\n" +
                        $"{label1.Text} - {checkBoxType.Text}" +
                        $"\n{label6.Text} - {txtSurname.Text}" +
                        $"\n{label5.Text} - {txtname.Text}" +
                        $"\n{label8.Text} - {txtPatronymic.Text}" +
                        $"\n{label9.Text} - {txtRenterCompany.Text}" +
                        $"\n{label7.Text} - {txtRenterINN.Text}" +
                        $"\n{label11.Text} - {txtPhone.Text}" +
                        $"\n{label10.Text} - {txtChiefSurname.Text}" +
                        $"\n{label12.Text} - {txtChiefName.Text}" +
                        $"\n{label13.Text} - {txtChiefPatronymic.Text}" +
                        $"\n{label14.Text} - {txtStreetID.Text}" +
                        $"\n{label16.Text} - {txtHouseNumber.Text}" +
                        $"\n{label15.Text} - {txtApartment.Text}" +
                        $"\n{label17.Text} - {txtAreaID.Text}" +
                        $"\n{label18.Text} - {txtBankID.Text}" +
                        $" в {DateTime.Now}\n");
                }
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Арендатор добавлен.");
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE scheme.renters SET rentertype=('" + checkBoxType.Checked + "'),surname=('" + txtSurname.Text + "')" +
            //    ",name=('" + txtname.Text + "'),patronymic=('" + txtPatronymic.Text + "'),rentercompany=('" + txtRenterCompany.Text + "')" +
            //    ",renterinn=('" + txtRenterINN.Text + "'),chiefsurname=('" + txtChiefSurname.Text + "'),chiefname=('" + txtChiefName.Text + "')" +
            //    ",chiefpatronymic=('" + txtChiefPatronymic.Text + "'),phone=('" + txtPhone.Text + "'),streetid=('" + txtStreetID.Text + "')" +
            //    ",housenumber=('" + txtHouseNumber.Text + "'),apartment=('" + txtApartment.Text + "'),areaid=('" + txtAreaID.Text + "')" +
            //    ",bankid=('" + txtBankID.Text + "') WHERE renterid=('" + txtIDRenter.Text + "')";
            string query = "UPDATE scheme.renters SET rentertype=(?),surname=(?)" +
              ",name=(?),patronymic=(?),rentercompany=(?)" +
              ",renterinn=(?),chiefsurname=(?),chiefname=(?)" +
              ",chiefpatronymic=(?),phone=(?),streetid=(?)" +
              ",housenumber=(?),apartment=(?),areaid=(?)" +
              ",bankid=(?) WHERE renterid=(?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = checkBoxType.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtSurname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtPatronymic.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterCompany.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtRenterINN.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefSurname.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefName.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtChiefPatronymic.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtPhone.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtStreetID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtHouseNumber.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtApartment.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtAreaID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtBankID.Text;
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDRenter.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  изменил значения полей под индексом {txtIDRenter.Text}" +
                    $" из таблицы Арендаторы:\n  " +
                    $" Тип - {dataGridView1.CurrentRow.Cells[1].Value}   на поле: {checkBoxType.Text}\n" +
                    $" Фамилия - {dataGridView1.CurrentRow.Cells[2].Value}   на поле: {txtSurname.Text}\n" +
                    $" Имя - {dataGridView1.CurrentRow.Cells[3].Value}   на поле: {txtname.Text}\n" +
                    $" Отчество - {dataGridView1.CurrentRow.Cells[4].Value}   на поле: {txtPatronymic.Text}\n" +
                    $" Компания (Фирма) - {dataGridView1.CurrentRow.Cells[5].Value}   на поле: {txtRenterCompany.Text}\n" +
                    $" ИНН - {dataGridView1.CurrentRow.Cells[6].Value}   на поле: {txtRenterINN.Text}\n" +
                    $" Телефон - {dataGridView1.CurrentRow.Cells[7].Value}   на поле: {txtPhone.Text}\n" +
                    $" Фамилия директора - {dataGridView1.CurrentRow.Cells[8].Value}   на поле: {txtChiefSurname.Text}\n" +
                    $" Имя директора - {dataGridView1.CurrentRow.Cells[9].Value}   на поле: {txtChiefName.Text}\n" +
                    $" Отчество директора - {dataGridView1.CurrentRow.Cells[10].Value}   на поле: {txtChiefPatronymic.Text}\n" +
                    $" ID улицы - {dataGridView1.CurrentRow.Cells[11].Value}   на поле: {txtStreetID.Text}\n" +
                    $" Номер дома - {dataGridView1.CurrentRow.Cells[12].Value}   на поле: {txtHouseNumber.Text}\n" +
                    $" Квартира - {dataGridView1.CurrentRow.Cells[13].Value}   на поле: {txtApartment.Text}\n" +
                    $" ID района - {dataGridView1.CurrentRow.Cells[14].Value}   на поле: {txtAreaID.Text}\n" +
                    $" ID банка - {dataGridView1.CurrentRow.Cells[15].Value}   на поле: {txtBankID.Text}\n" +
                    $"  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM  scheme.renters WHERE renterid=  ('" + txtIDRenter.Text + "')";
            string query = "DELETE FROM  scheme.renters WHERE renterid=  (?)";
            command = new OdbcCommand(query, connection);
            command.Parameters.Add("?", OdbcType.NVarChar).Value = txtIDRenter.Text;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login}  удалил поле из таблицы Арендаторы под индексом: {txtIDRenter.Text}  в {DateTime.Now}\n");
            }
            command.ExecuteNonQuery();
            connection.Close();
            GetData();
            MessageBox.Show("Арендатор удален.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDRenter.Text == "")
                GetData();
            else
            {
                string query = "select * from scheme.renters where renterid= '" + Convert.ToInt32(txtIDRenter.Text) + "'";
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
            txtIDRenter.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            checkBoxType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPatronymic.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenterCompany.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRenterINN.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtChiefSurname.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtChiefName.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtChiefPatronymic.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtStreetID.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtHouseNumber.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtApartment.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtAreaID.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtBankID.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            if(checkBoxType.Text=="1")
            {
                checkBoxType.Checked= true;
                txtRenterCompany.Enabled = false;
                txtChiefSurname.Enabled = false;
                txtChiefName.Enabled = false;
                txtChiefPatronymic.Enabled = false;
                txtRenterCompany.Text = null;
                txtChiefSurname.Text = null;
                txtChiefName.Text = null;
                txtChiefPatronymic.Text = null;
                txtname.Enabled = true;
                txtSurname.Enabled = true;
                txtPatronymic.Enabled = true;
            }
            if (checkBoxType.Text == "0")
            {
                checkBoxType.Checked = false;
                txtRenterCompany.Enabled = true;
                txtChiefSurname.Enabled = true;
                txtChiefName.Enabled = true;
                txtChiefPatronymic.Enabled = true;
                txtname.Enabled = false;
                txtSurname.Enabled = false;
                txtPatronymic.Enabled = false;
                txtname.Text = null;
                txtSurname.Text = null;
                txtPatronymic.Text = null;
            }
        }

        private void checkBoxType_Click(object sender, EventArgs e)
        {
            if (checkBoxType.Checked == false)
            {
                txtRenterCompany.Enabled = true;
                txtChiefSurname.Enabled = true;
                txtChiefName.Enabled = true;
                txtChiefPatronymic.Enabled = true;
                txtname.Enabled = false;
                txtSurname.Enabled = false;
                txtPatronymic.Enabled = false;
                txtname.Text = null;
                txtSurname.Text=null;
                txtPatronymic.Text=null;
                checkBoxType.Text = "0";
            }
            else
            {
                txtRenterCompany.Enabled = false;
                txtChiefSurname.Enabled = false;
                txtChiefName.Enabled = false;
                txtChiefPatronymic.Enabled = false;
                txtRenterCompany.Text = null;
                txtChiefSurname.Text = null;
                txtChiefName.Text = null;
                txtChiefPatronymic.Text = null;
                txtname.Enabled = true;
                txtSurname.Enabled = true;
                txtPatronymic.Enabled = true;
                checkBoxType.Text = "1";
            }
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            txtIDRenter.Enabled= false;
           // txtIDRenter.Text= null;
        }

        private void BtnChange_MouseEnter(object sender, EventArgs e)
        {
            txtIDRenter.Enabled = false;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
                checkBoxType.Enabled = false;
                txtSurname.Enabled = false;
                txtname.Enabled = false;
                txtPatronymic.Enabled = false;
                txtRenterCompany.Enabled = false;
                txtRenterINN.Enabled = false;
                txtChiefSurname.Enabled = false;
                txtChiefName.Enabled = false;
                txtChiefPatronymic.Enabled = false;
                txtPhone.Enabled = false;
                txtStreetID.Enabled = false;
                txtHouseNumber.Enabled = false;
                txtApartment.Enabled = false;
                txtAreaID.Enabled = false;
                txtBankID.Enabled = false;
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            checkBoxType.Enabled = false;
            txtSurname.Enabled = false;
            txtname.Enabled = false;
            txtPatronymic.Enabled = false;
            txtRenterCompany.Enabled = false;
            txtRenterINN.Enabled = false;
            txtChiefSurname.Enabled = false;
            txtChiefName.Enabled = false;
            txtChiefPatronymic.Enabled = false;
            txtPhone.Enabled = false;
            txtStreetID.Enabled = false;
            txtHouseNumber.Enabled = false;
            txtApartment.Enabled = false;
            txtAreaID.Enabled = false;
            txtBankID.Enabled = false;
        }

        private void Renters_MouseEnter(object sender, EventArgs e)
        {
            txtIDRenter.Enabled = true;
            checkBoxType.Enabled = true;
           // txtSurname.Enabled = true;
           // txtname.Enabled = true;
           // txtPatronymic.Enabled = true;
           // txtRenterCompany.Enabled = true;
            txtRenterINN.Enabled = true;
           // txtChiefSurname.Enabled = true;
           // txtChiefName.Enabled = true;
           // txtChiefPatronymic.Enabled = true;
            txtPhone.Enabled = true;
            txtStreetID.Enabled = true;
            txtHouseNumber.Enabled = true;
            txtApartment.Enabled = true;
            txtAreaID.Enabled = true;
            txtBankID.Enabled = true;
          //  txtIDRenter.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            excel.SaveExcel(dataGridView1, "renters.xlsx");
        }
        private void btnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            word.SaveWord(dataGridView1,"renters.docx");
        }

        private void btnExcelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exceles excel = new Exceles();
            if (dataGridView1.SelectedRows.Count > 0)
                excel.SaveExcelOne(dataGridView1, $"renters{txtIDRenter.Text}.xlsx");
            else MessageBox.Show("Не выбрана строка");
        }

        private void btnWordOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Words word = new Words();
            if (dataGridView1.SelectedRows.Count > 0)
                word.SaveWordOne(dataGridView1, $"renters{txtIDRenter.Text}.docx");
            else MessageBox.Show("Не выбрана строка");
        }
    }
}
