namespace _5_postgres
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.AuthentificationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataU = new _5_postgres.DataU();
            this.dataUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataUsers = new _5_postgres.DataUsers();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new _5_postgres.DataUsersTableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new _5_postgres.DataUTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthentificationButton
            // 
            this.AuthentificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthentificationButton.Location = new System.Drawing.Point(247, 226);
            this.AuthentificationButton.Name = "AuthentificationButton";
            this.AuthentificationButton.Size = new System.Drawing.Size(163, 40);
            this.AuthentificationButton.TabIndex = 0;
            this.AuthentificationButton.Text = "Войти";
            this.AuthentificationButton.UseVisualStyleBackColor = true;
            this.AuthentificationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(237, 137);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(163, 24);
            this.loginBox.TabIndex = 3;
            // 
            // passwdBox
            // 
            this.passwdBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdBox.Location = new System.Drawing.Point(237, 175);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(163, 24);
            this.passwdBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(101, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Войдите в систему для работы с программой";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.Location = new System.Drawing.Point(562, 211);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(145, 40);
            this.RegistrationButton.TabIndex = 13;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(539, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Создать  новый аккаунт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(266, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 60);
            this.label5.TabIndex = 15;
            this.label5.Text = "Подсказка:\r\nЛогин- User1\r\nПароль- 123456";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(406, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(406, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 35);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataU
            // 
            this.dataU.DataSetName = "DataU";
            this.dataU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataUBindingSource
            // 
            this.dataUBindingSource.DataSource = this.dataU;
            this.dataUBindingSource.Position = 0;
            // 
            // dataUsers
            // 
            this.dataUsers.DataSetName = "DataUsers";
            this.dataUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataUsers;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.dataU;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthentificationButton);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizatrionForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthentificationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dataUBindingSource;
        private DataU dataU;
        private DataUsers dataUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataUsersTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private DataUTableAdapters.usersTableAdapter usersTableAdapter1;
    }
}