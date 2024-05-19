namespace _5_postgres
{
    partial class Contracts
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
            this.comboPeriod = new System.Windows.Forms.ComboBox();
            this.ckbValid = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.txtIDContract = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contractidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContracts = new _5_postgres.DataContracts();
            this.txtIDRenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dtmStart = new System.Windows.Forms.DateTimePicker();
            this.dtmStop = new System.Windows.Forms.DateTimePicker();
            this.contractsTableAdapter = new _5_postgres.DataContractsTableAdapters.contractsTableAdapter();
            this.btnExcelOne = new System.Windows.Forms.Button();
            this.btnWordOne = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPeriod
            // 
            this.comboPeriod.FormattingEnabled = true;
            this.comboPeriod.Items.AddRange(new object[] {
            "Ежемесячная",
            "Квартальная"});
            this.comboPeriod.Location = new System.Drawing.Point(279, 366);
            this.comboPeriod.Name = "comboPeriod";
            this.comboPeriod.Size = new System.Drawing.Size(181, 21);
            this.comboPeriod.TabIndex = 127;
            // 
            // ckbValid
            // 
            this.ckbValid.AutoSize = true;
            this.ckbValid.Location = new System.Drawing.Point(279, 218);
            this.ckbValid.Name = "ckbValid";
            this.ckbValid.Size = new System.Drawing.Size(80, 17);
            this.ckbValid.TabIndex = 126;
            this.ckbValid.Text = "checkBox1";
            this.ckbValid.UseVisualStyleBackColor = true;
            this.ckbValid.Click += new System.EventHandler(this.ckbValid_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(28, 473);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 125;
            this.label16.Text = "Штраф";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(28, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 20);
            this.label14.TabIndex = 124;
            this.label14.Text = "Периодичность оплаты";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(28, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 20);
            this.label13.TabIndex = 123;
            this.label13.Text = "Дата окончания договора";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(28, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 20);
            this.label12.TabIndex = 122;
            this.label12.Text = "Дата начала договора";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(28, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 40);
            this.label10.TabIndex = 121;
            this.label10.Text = "Действителен\r\n/Недействителен";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(28, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 120;
            this.label9.Text = "Сумма";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTax.Location = new System.Drawing.Point(279, 473);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(181, 20);
            this.txtTax.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(75, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Таблица: Договора";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(902, 57);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(57, 20);
            this.labelRole.TabIndex = 114;
            this.labelRole.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(522, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 52);
            this.label3.TabIndex = 113;
            this.label3.Text = "Для подсказки наведите \r\nуказатель мыши на кнопки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Purple;
            this.BtnSearch.Location = new System.Drawing.Point(1013, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(149, 55);
            this.BtnSearch.TabIndex = 112;
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
            this.BtnChange.Location = new System.Drawing.Point(695, 123);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(128, 55);
            this.BtnChange.TabIndex = 111;
            this.BtnChange.Text = "Обновить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            this.BtnChange.MouseEnter += new System.EventHandler(this.BtnChange_MouseEnter);
            // 
            // txtIDContract
            // 
            this.txtIDContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDContract.Location = new System.Drawing.Point(279, 155);
            this.txtIDContract.Multiline = true;
            this.txtIDContract.Name = "txtIDContract";
            this.txtIDContract.Size = new System.Drawing.Size(181, 20);
            this.txtIDContract.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 60);
            this.label2.TabIndex = 109;
            this.label2.Text = "ID Договора\r\n(используется для \r\nПоиска и Удаления)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(851, 124);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 56);
            this.BtnDelete.TabIndex = 108;
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
            this.BtnAdd.Location = new System.Drawing.Point(527, 119);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 56);
            this.BtnAdd.TabIndex = 107;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractidDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.datestopDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.renteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(509, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 269);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // contractidDataGridViewTextBoxColumn
            // 
            this.contractidDataGridViewTextBoxColumn.DataPropertyName = "contractid";
            this.contractidDataGridViewTextBoxColumn.HeaderText = "contractid";
            this.contractidDataGridViewTextBoxColumn.Name = "contractidDataGridViewTextBoxColumn";
            // 
            // validDataGridViewTextBoxColumn
            // 
            this.validDataGridViewTextBoxColumn.DataPropertyName = "valid";
            this.validDataGridViewTextBoxColumn.HeaderText = "valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "datestart";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "datestart";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // datestopDataGridViewTextBoxColumn
            // 
            this.datestopDataGridViewTextBoxColumn.DataPropertyName = "datestop";
            this.datestopDataGridViewTextBoxColumn.HeaderText = "datestop";
            this.datestopDataGridViewTextBoxColumn.Name = "datestopDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // renteridDataGridViewTextBoxColumn
            // 
            this.renteridDataGridViewTextBoxColumn.DataPropertyName = "renterid";
            this.renteridDataGridViewTextBoxColumn.HeaderText = "renterid";
            this.renteridDataGridViewTextBoxColumn.Name = "renteridDataGridViewTextBoxColumn";
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "contracts";
            this.contractsBindingSource.DataSource = this.dataContracts;
            // 
            // dataContracts
            // 
            this.dataContracts.DataSetName = "DataContracts";
            this.dataContracts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIDRenter
            // 
            this.txtIDRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDRenter.Location = new System.Drawing.Point(279, 520);
            this.txtIDRenter.Multiline = true;
            this.txtIDRenter.Name = "txtIDRenter";
            this.txtIDRenter.Size = new System.Drawing.Size(181, 20);
            this.txtIDRenter.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "ID арендатора";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValue.Location = new System.Drawing.Point(279, 415);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(181, 20);
            this.txtValue.TabIndex = 130;
            // 
            // dtmStart
            // 
            this.dtmStart.Location = new System.Drawing.Point(279, 269);
            this.dtmStart.Name = "dtmStart";
            this.dtmStart.Size = new System.Drawing.Size(200, 20);
            this.dtmStart.TabIndex = 131;
            // 
            // dtmStop
            // 
            this.dtmStop.Location = new System.Drawing.Point(279, 316);
            this.dtmStop.Name = "dtmStop";
            this.dtmStop.Size = new System.Drawing.Size(200, 20);
            this.dtmStop.TabIndex = 132;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcelOne
            // 
            this.btnExcelOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcelOne.Location = new System.Drawing.Point(521, 591);
            this.btnExcelOne.Name = "btnExcelOne";
            this.btnExcelOne.Size = new System.Drawing.Size(226, 71);
            this.btnExcelOne.TabIndex = 136;
            this.btnExcelOne.Text = "Отчет для выбранного поля в Excel";
            this.btnExcelOne.UseVisualStyleBackColor = false;
            this.btnExcelOne.Click += new System.EventHandler(this.btnExcelOne_Click);
            // 
            // btnWordOne
            // 
            this.btnWordOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnWordOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWordOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWordOne.Location = new System.Drawing.Point(919, 591);
            this.btnWordOne.Name = "btnWordOne";
            this.btnWordOne.Size = new System.Drawing.Size(226, 71);
            this.btnWordOne.TabIndex = 135;
            this.btnWordOne.Text = "Отчет для выбранного поля в Word";
            this.btnWordOne.UseVisualStyleBackColor = false;
            this.btnWordOne.Click += new System.EventHandler(this.btnWordOne_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.DarkGray;
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWord.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWord.Location = new System.Drawing.Point(919, 520);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(226, 55);
            this.btnWord.TabIndex = 134;
            this.btnWord.Text = "Общий отчет Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Location = new System.Drawing.Point(521, 529);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(226, 56);
            this.btnExcel.TabIndex = 133;
            this.btnExcel.Text = "Общий отчет Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 719);
            this.Controls.Add(this.btnExcelOne);
            this.Controls.Add(this.btnWordOne);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtmStop);
            this.Controls.Add(this.dtmStart);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDRenter);
            this.Controls.Add(this.comboPeriod);
            this.Controls.Add(this.ckbValid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.txtIDContract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Contracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.Contracts_Load);
            this.MouseEnter += new System.EventHandler(this.Contracts_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPeriod;
        private System.Windows.Forms.CheckBox ckbValid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox txtIDContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDRenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DateTimePicker dtmStart;
        private System.Windows.Forms.DateTimePicker dtmStop;
        private DataContracts dataContracts;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private DataContractsTableAdapters.contractsTableAdapter contractsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcelOne;
        private System.Windows.Forms.Button btnWordOne;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}