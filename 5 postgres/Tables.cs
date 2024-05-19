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
    public partial class Tables : Form
    {
        private readonly Users user;
        public Tables( Users user)
        {
            InitializeComponent();
            this.user = user;
        }
        OdbcConnection connection = new OdbcConnection("Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;password=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1");
        OdbcCommand command;
        OdbcDataAdapter adapter;
        private void IsAdmin()
        {
            if (user.Role == "user")
            {
                btnUsers.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LabelRole.Text = $"Логин:{user.Login} Роль:{user.Role}";
            string file = @"log.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Пользователь {user.Login} с ролью {user.Role} вошел в БД в {DateTime.Now}\n");
            }
            IsAdmin();
        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            Banks bank = new Banks(user);
            bank.Show();
        }

        private void BtnDirectoryArea_Click(object sender, EventArgs e)
        {
            DirectoryAreas directoryAreas = new DirectoryAreas( user);
            directoryAreas.Show();
        }

        private void BtnDirectoryStreet_Click(object sender, EventArgs e)
        {
            DirectoryStreets directoryStreets = new DirectoryStreets(user);
            directoryStreets.Show();
        }

        private void BtnRenters_Click(object sender, EventArgs e)
        {
            Renters renters = new Renters(user);
            renters.Show();
        }

        private void BtnHalls_Click(object sender, EventArgs e)
        {
            Halls halls=new Halls(user);
            halls.Show();
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts(user);
            contracts.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdministratorForm adm=new AdministratorForm(user); 
            adm.Show();
        }
    }
}
