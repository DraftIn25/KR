namespace _5_postgres
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataUsers = new _5_postgres.DataUsers();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new _5_postgres.DataUsersTableAdapters.usersTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserRole = new System.Windows.Forms.TextBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new _5_postgres.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataU = new _5_postgres.DataU();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new _5_postgres.DataUTableAdapters.usersTableAdapter();
            this.useridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userroleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmDatePassword = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(48, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Таблица: Пользователи";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(729, 65);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(57, 20);
            this.labelRole.TabIndex = 35;
            this.labelRole.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(377, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 52);
            this.label3.TabIndex = 34;
            this.label3.Text = "Для подсказки наведите \r\nуказатель мыши на кнопки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Purple;
            this.BtnSearch.Location = new System.Drawing.Point(868, 148);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(149, 55);
            this.BtnSearch.TabIndex = 33;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.BtnSearch.MouseEnter += new System.EventHandler(this.BtnSearch_MouseEnter);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.DarkGray;
            this.BtnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.ForeColor = System.Drawing.Color.Navy;
            this.BtnChange.Location = new System.Drawing.Point(551, 146);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(128, 55);
            this.BtnChange.TabIndex = 32;
            this.BtnChange.Text = "Обновить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            this.BtnChange.MouseEnter += new System.EventHandler(this.BtnChange_MouseEnter);
            // 
            // txtIDUser
            // 
            this.txtIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDUser.Location = new System.Drawing.Point(214, 195);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(100, 22);
            this.txtIDUser.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 60);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID пользователя\r\n(используется для \r\nПоиска и Удаления)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Логин";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserLogin.Location = new System.Drawing.Point(214, 236);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(100, 22);
            this.txtUserLogin.TabIndex = 28;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(702, 147);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 56);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.BtnDelete.MouseEnter += new System.EventHandler(this.BtnDelete_MouseEnter);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Lime;
            this.BtnAdd.Location = new System.Drawing.Point(382, 145);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 56);
            this.BtnAdd.TabIndex = 26;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataUsers;
            // 
            // dataUsers
            // 
            this.dataUsers.DataSetName = "DataUsers";
            this.dataUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Фамилия";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(214, 377);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 40;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserPassword.Location = new System.Drawing.Point(214, 289);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 22);
            this.txtUserPassword.TabIndex = 41;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(214, 428);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 42;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Роль";
            // 
            // txtUserRole
            // 
            this.txtUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserRole.Location = new System.Drawing.Point(214, 331);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(100, 22);
            this.txtUserRole.TabIndex = 44;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.dataUsers;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.dataUsers;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn1,
            this.userloginDataGridViewTextBoxColumn1,
            this.userpasswordDataGridViewTextBoxColumn1,
            this.userroleDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.datepasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(366, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // dataU
            // 
            this.dataU.DataSetName = "DataU";
            this.dataU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "users";
            this.usersBindingSource3.DataSource = this.dataU;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // useridDataGridViewTextBoxColumn1
            // 
            this.useridDataGridViewTextBoxColumn1.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn1.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn1.Name = "useridDataGridViewTextBoxColumn1";
            // 
            // userloginDataGridViewTextBoxColumn1
            // 
            this.userloginDataGridViewTextBoxColumn1.DataPropertyName = "userlogin";
            this.userloginDataGridViewTextBoxColumn1.HeaderText = "userlogin";
            this.userloginDataGridViewTextBoxColumn1.Name = "userloginDataGridViewTextBoxColumn1";
            // 
            // userpasswordDataGridViewTextBoxColumn1
            // 
            this.userpasswordDataGridViewTextBoxColumn1.DataPropertyName = "userpassword";
            this.userpasswordDataGridViewTextBoxColumn1.HeaderText = "userpassword";
            this.userpasswordDataGridViewTextBoxColumn1.Name = "userpasswordDataGridViewTextBoxColumn1";
            // 
            // userroleDataGridViewTextBoxColumn1
            // 
            this.userroleDataGridViewTextBoxColumn1.DataPropertyName = "userrole";
            this.userroleDataGridViewTextBoxColumn1.HeaderText = "userrole";
            this.userroleDataGridViewTextBoxColumn1.Name = "userroleDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // datepasswordDataGridViewTextBoxColumn
            // 
            this.datepasswordDataGridViewTextBoxColumn.DataPropertyName = "date_password";
            this.datepasswordDataGridViewTextBoxColumn.HeaderText = "date_password";
            this.datepasswordDataGridViewTextBoxColumn.Name = "datepasswordDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Дата регистрации пароля";
            // 
            // dtmDatePassword
            // 
            this.dtmDatePassword.Location = new System.Drawing.Point(260, 470);
            this.dtmDatePassword.Name = "dtmDatePassword";
            this.dtmDatePassword.Size = new System.Drawing.Size(200, 20);
            this.dtmDatePassword.TabIndex = 47;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 598);
            this.Controls.Add(this.dtmDatePassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.MouseEnter += new System.EventHandler(this.AdministratorForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtSurname;
        private DataUsers dataUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataUsersTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserRole;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataU dataU;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private DataUTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userroleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmDatePassword;
    }
}