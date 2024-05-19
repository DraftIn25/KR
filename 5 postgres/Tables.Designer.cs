namespace _5_postgres
{
    partial class Tables
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnRenters = new System.Windows.Forms.Button();
            this.BtnHalls = new System.Windows.Forms.Button();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.BtnDirectoryStreet = new System.Windows.Forms.Button();
            this.BtnDirectoryArea = new System.Windows.Forms.Button();
            this.BtnBanks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelRole = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "bank";
            // 
            // BtnRenters
            // 
            this.BtnRenters.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRenters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRenters.Location = new System.Drawing.Point(221, 192);
            this.BtnRenters.Name = "BtnRenters";
            this.BtnRenters.Size = new System.Drawing.Size(120, 43);
            this.BtnRenters.TabIndex = 2;
            this.BtnRenters.Text = "Арендаторы";
            this.BtnRenters.Click += new System.EventHandler(this.BtnRenters_Click);
            // 
            // BtnHalls
            // 
            this.BtnHalls.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnHalls.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnHalls.Location = new System.Drawing.Point(378, 192);
            this.BtnHalls.Name = "BtnHalls";
            this.BtnHalls.Size = new System.Drawing.Size(109, 43);
            this.BtnHalls.TabIndex = 3;
            this.BtnHalls.Text = "Помещения";
            this.BtnHalls.UseVisualStyleBackColor = true;
            this.BtnHalls.Click += new System.EventHandler(this.BtnHalls_Click);
            // 
            // BtnContracts
            // 
            this.BtnContracts.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnContracts.Location = new System.Drawing.Point(520, 192);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Size = new System.Drawing.Size(95, 43);
            this.BtnContracts.TabIndex = 4;
            this.BtnContracts.Text = "Договора";
            this.BtnContracts.UseVisualStyleBackColor = true;
            this.BtnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // BtnDirectoryStreet
            // 
            this.BtnDirectoryStreet.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDirectoryStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDirectoryStreet.Location = new System.Drawing.Point(221, 284);
            this.BtnDirectoryStreet.Name = "BtnDirectoryStreet";
            this.BtnDirectoryStreet.Size = new System.Drawing.Size(120, 49);
            this.BtnDirectoryStreet.TabIndex = 5;
            this.BtnDirectoryStreet.Text = "Справочник улиц";
            this.BtnDirectoryStreet.UseVisualStyleBackColor = true;
            this.BtnDirectoryStreet.Click += new System.EventHandler(this.BtnDirectoryStreet_Click);
            // 
            // BtnDirectoryArea
            // 
            this.BtnDirectoryArea.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDirectoryArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDirectoryArea.Location = new System.Drawing.Point(378, 284);
            this.BtnDirectoryArea.Name = "BtnDirectoryArea";
            this.BtnDirectoryArea.Size = new System.Drawing.Size(109, 49);
            this.BtnDirectoryArea.TabIndex = 6;
            this.BtnDirectoryArea.Text = "Справочник районов";
            this.BtnDirectoryArea.UseVisualStyleBackColor = true;
            this.BtnDirectoryArea.Click += new System.EventHandler(this.BtnDirectoryArea_Click);
            // 
            // BtnBanks
            // 
            this.BtnBanks.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBanks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnBanks.Location = new System.Drawing.Point(520, 284);
            this.BtnBanks.Name = "BtnBanks";
            this.BtnBanks.Size = new System.Drawing.Size(95, 49);
            this.BtnBanks.TabIndex = 7;
            this.BtnBanks.Text = "Банки";
            this.BtnBanks.UseVisualStyleBackColor = true;
            this.BtnBanks.Click += new System.EventHandler(this.BtnBanks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 156);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добро пожаловать!\r\nВыберите таблицу для просмотра данных\r\n или для работы с данны" +
    "ми\r\n (в случае, если включен режим привилегии)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hallsBindingSource
            // 
            this.hallsBindingSource.DataMember = "halls";
            // 
            // LabelRole
            // 
            this.LabelRole.AutoSize = true;
            this.LabelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRole.Location = new System.Drawing.Point(581, 23);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(57, 20);
            this.LabelRole.TabIndex = 10;
            this.LabelRole.Text = "label2";
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUsers.Location = new System.Drawing.Point(645, 226);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(143, 72);
            this.btnUsers.TabIndex = 11;
            this.btnUsers.Text = "Список пользователей";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.LabelRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBanks);
            this.Controls.Add(this.BtnDirectoryArea);
            this.Controls.Add(this.BtnDirectoryStreet);
            this.Controls.Add(this.BtnContracts);
            this.Controls.Add(this.BtnHalls);
            this.Controls.Add(this.BtnRenters);
            this.Name = "Tables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRenters;
        private System.Windows.Forms.Button BtnHalls;
        private System.Windows.Forms.Button BtnContracts;
        private System.Windows.Forms.Button BtnDirectoryStreet;
        private System.Windows.Forms.Button BtnDirectoryArea;
        private System.Windows.Forms.Button BtnBanks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hallsBindingSource;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private System.Windows.Forms.Label LabelRole;
        private System.Windows.Forms.Button btnUsers;
    }
}

