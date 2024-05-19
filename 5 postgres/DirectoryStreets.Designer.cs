namespace _5_postgres
{
    partial class DirectoryStreets
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
            this.txtIDStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.streetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorystreetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDirectoryStreet = new _5_postgres.DataDirectoryStreet();
            this.directorystreetTableAdapter = new _5_postgres.DataDirectoryStreetTableAdapters.directorystreetTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnExcelOne = new System.Windows.Forms.Button();
            this.btnWordOne = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorystreetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryStreet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(80, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Таблица: Справочник улиц";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(849, 63);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(57, 20);
            this.labelRole.TabIndex = 34;
            this.labelRole.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(469, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 52);
            this.label3.TabIndex = 33;
            this.label3.Text = "Для подсказки наведите \r\nуказатель мыши на кнопки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Purple;
            this.BtnSearch.Location = new System.Drawing.Point(960, 131);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(149, 55);
            this.BtnSearch.TabIndex = 32;
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
            this.BtnChange.Location = new System.Drawing.Point(642, 129);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(128, 55);
            this.BtnChange.TabIndex = 31;
            this.BtnChange.Text = "Обновить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            this.BtnChange.MouseEnter += new System.EventHandler(this.BtnChange_MouseEnter);
            // 
            // txtIDStreet
            // 
            this.txtIDStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDStreet.Location = new System.Drawing.Point(309, 203);
            this.txtIDStreet.Name = "txtIDStreet";
            this.txtIDStreet.Size = new System.Drawing.Size(100, 22);
            this.txtIDStreet.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 60);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID улицы\r\n(используется для \r\nПоиска и Удаления)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Название улицы\r\n";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStreetName.Location = new System.Drawing.Point(309, 253);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(100, 22);
            this.txtStreetName.TabIndex = 27;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(798, 130);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 56);
            this.BtnDelete.TabIndex = 26;
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
            this.BtnAdd.Location = new System.Drawing.Point(474, 128);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 56);
            this.BtnAdd.TabIndex = 25;
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
            this.streetidDataGridViewTextBoxColumn,
            this.streetnameDataGridViewTextBoxColumn,
            this.signDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.directorystreetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(474, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 208);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // streetidDataGridViewTextBoxColumn
            // 
            this.streetidDataGridViewTextBoxColumn.DataPropertyName = "streetid";
            this.streetidDataGridViewTextBoxColumn.HeaderText = "streetid";
            this.streetidDataGridViewTextBoxColumn.Name = "streetidDataGridViewTextBoxColumn";
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "streetname";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "streetname";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            // 
            // signDataGridViewTextBoxColumn
            // 
            this.signDataGridViewTextBoxColumn.DataPropertyName = "sign";
            this.signDataGridViewTextBoxColumn.HeaderText = "sign";
            this.signDataGridViewTextBoxColumn.Name = "signDataGridViewTextBoxColumn";
            // 
            // directorystreetBindingSource
            // 
            this.directorystreetBindingSource.DataMember = "directorystreet";
            this.directorystreetBindingSource.DataSource = this.dataDirectoryStreet;
            // 
            // dataDirectoryStreet
            // 
            this.dataDirectoryStreet.DataSetName = "DataDirectoryStreet";
            this.dataDirectoryStreet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorystreetTableAdapter
            // 
            this.directorystreetTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(131, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Признак улицы\r\n";
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSign.Location = new System.Drawing.Point(309, 304);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(100, 22);
            this.txtSign.TabIndex = 37;
            // 
            // btnExcelOne
            // 
            this.btnExcelOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcelOne.Location = new System.Drawing.Point(474, 489);
            this.btnExcelOne.Name = "btnExcelOne";
            this.btnExcelOne.Size = new System.Drawing.Size(226, 71);
            this.btnExcelOne.TabIndex = 144;
            this.btnExcelOne.Text = "Отчет для выбранного поля в Excel";
            this.btnExcelOne.UseVisualStyleBackColor = false;
            this.btnExcelOne.Click += new System.EventHandler(this.btnExcelOne_Click);
            // 
            // btnWordOne
            // 
            this.btnWordOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnWordOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWordOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWordOne.Location = new System.Drawing.Point(826, 489);
            this.btnWordOne.Name = "btnWordOne";
            this.btnWordOne.Size = new System.Drawing.Size(226, 71);
            this.btnWordOne.TabIndex = 143;
            this.btnWordOne.Text = "Отчет для выбранного поля в Word";
            this.btnWordOne.UseVisualStyleBackColor = false;
            this.btnWordOne.Click += new System.EventHandler(this.btnWordOne_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.DarkGray;
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWord.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWord.Location = new System.Drawing.Point(826, 416);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(226, 55);
            this.btnWord.TabIndex = 142;
            this.btnWord.Text = "Общий отчет Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Location = new System.Drawing.Point(474, 416);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(226, 56);
            this.btnExcel.TabIndex = 141;
            this.btnExcel.Text = "Общий отчет Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // DirectoryStreets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 629);
            this.Controls.Add(this.btnExcelOne);
            this.Controls.Add(this.btnWordOne);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.txtIDStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DirectoryStreets";
            this.Text = "DirectoryStreets";
            this.Load += new System.EventHandler(this.DirectoryStreets_Load);
            this.MouseEnter += new System.EventHandler(this.DirectoryStreets_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorystreetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryStreet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox txtIDStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDirectoryStreet dataDirectoryStreet;
        private System.Windows.Forms.BindingSource directorystreetBindingSource;
        private DataDirectoryStreetTableAdapters.directorystreetTableAdapter directorystreetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button btnExcelOne;
        private System.Windows.Forms.Button btnWordOne;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}