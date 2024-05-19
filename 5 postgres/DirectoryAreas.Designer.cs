namespace _5_postgres
{
    partial class DirectoryAreas
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
            this.labelRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.txtIDArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.areaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDirectoryArea = new _5_postgres.DataDirectoryArea();
            this.directoryareaTableAdapter = new _5_postgres.DataDirectoryAreaTableAdapters.directoryareaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcelOne = new System.Windows.Forms.Button();
            this.btnWordOne = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryareaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryArea)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(791, 18);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(57, 20);
            this.labelRole.TabIndex = 22;
            this.labelRole.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(411, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 52);
            this.label3.TabIndex = 21;
            this.label3.Text = "Для подсказки наведите \r\nуказатель мыши на кнопки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Purple;
            this.BtnSearch.Location = new System.Drawing.Point(902, 86);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(149, 55);
            this.BtnSearch.TabIndex = 20;
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
            this.BtnChange.Location = new System.Drawing.Point(584, 84);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(128, 55);
            this.BtnChange.TabIndex = 19;
            this.BtnChange.Text = "Обновить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            this.BtnChange.MouseEnter += new System.EventHandler(this.BtnChange_MouseEnter);
            // 
            // txtIDArea
            // 
            this.txtIDArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDArea.Location = new System.Drawing.Point(251, 158);
            this.txtIDArea.Name = "txtIDArea";
            this.txtIDArea.Size = new System.Drawing.Size(100, 22);
            this.txtIDArea.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 60);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID района\r\n(используется для \r\nПоиска и Удаления)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название района\r\n";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAreaName.Location = new System.Drawing.Point(251, 208);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(100, 22);
            this.txtAreaName.TabIndex = 15;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(740, 85);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 56);
            this.BtnDelete.TabIndex = 14;
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
            this.BtnAdd.Location = new System.Drawing.Point(416, 83);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(146, 56);
            this.BtnAdd.TabIndex = 13;
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
            this.areaidDataGridViewTextBoxColumn,
            this.areanameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.directoryareaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(416, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 222);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // areaidDataGridViewTextBoxColumn
            // 
            this.areaidDataGridViewTextBoxColumn.DataPropertyName = "areaid";
            this.areaidDataGridViewTextBoxColumn.HeaderText = "areaid";
            this.areaidDataGridViewTextBoxColumn.Name = "areaidDataGridViewTextBoxColumn";
            // 
            // areanameDataGridViewTextBoxColumn
            // 
            this.areanameDataGridViewTextBoxColumn.DataPropertyName = "areaname";
            this.areanameDataGridViewTextBoxColumn.HeaderText = "areaname";
            this.areanameDataGridViewTextBoxColumn.Name = "areanameDataGridViewTextBoxColumn";
            // 
            // directoryareaBindingSource
            // 
            this.directoryareaBindingSource.DataMember = "directoryarea";
            this.directoryareaBindingSource.DataSource = this.dataDirectoryArea;
            // 
            // dataDirectoryArea
            // 
            this.dataDirectoryArea.DataSetName = "DataDirectoryArea";
            this.dataDirectoryArea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoryareaTableAdapter
            // 
            this.directoryareaTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Таблица: Справочник районов";
            // 
            // btnExcelOne
            // 
            this.btnExcelOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcelOne.Location = new System.Drawing.Point(429, 485);
            this.btnExcelOne.Name = "btnExcelOne";
            this.btnExcelOne.Size = new System.Drawing.Size(226, 71);
            this.btnExcelOne.TabIndex = 140;
            this.btnExcelOne.Text = "Отчет для выбранного поля в Excel";
            this.btnExcelOne.UseVisualStyleBackColor = false;
            this.btnExcelOne.Click += new System.EventHandler(this.btnExcelOne_Click);
            // 
            // btnWordOne
            // 
            this.btnWordOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnWordOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWordOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWordOne.Location = new System.Drawing.Point(778, 485);
            this.btnWordOne.Name = "btnWordOne";
            this.btnWordOne.Size = new System.Drawing.Size(226, 71);
            this.btnWordOne.TabIndex = 139;
            this.btnWordOne.Text = "Отчет для выбранного поля в Word";
            this.btnWordOne.UseVisualStyleBackColor = false;
            this.btnWordOne.Click += new System.EventHandler(this.btnWordOne_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.DarkGray;
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWord.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnWord.Location = new System.Drawing.Point(778, 411);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(226, 55);
            this.btnWord.TabIndex = 138;
            this.btnWord.Text = "Общий отчет Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGray;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Location = new System.Drawing.Point(429, 411);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(226, 56);
            this.btnExcel.TabIndex = 137;
            this.btnExcel.Text = "Общий отчет Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // DirectoryAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 607);
            this.Controls.Add(this.btnExcelOne);
            this.Controls.Add(this.btnWordOne);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.txtIDArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DirectoryAreas";
            this.Text = "DirectoryAreas";
            this.Load += new System.EventHandler(this.DirectoryAreas_Load);
            this.MouseEnter += new System.EventHandler(this.DirectoryAreas_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryareaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox txtIDArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDirectoryArea dataDirectoryArea;
        private System.Windows.Forms.BindingSource directoryareaBindingSource;
        private DataDirectoryAreaTableAdapters.directoryareaTableAdapter directoryareaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcelOne;
        private System.Windows.Forms.Button btnWordOne;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}