namespace DataBaseCinema
{
    partial class GeneralForm
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
            this.addCinema = new System.Windows.Forms.Button();
            this.deleteCinema = new System.Windows.Forms.Button();
            this.changeCinema = new System.Windows.Forms.Button();
            this.importFile = new System.Windows.Forms.Button();
            this.saveChange = new System.Windows.Forms.Button();
            this.allCinemaControl = new System.Windows.Forms.TabControl();
            this.allCinemaPage = new System.Windows.Forms.TabPage();
            this.allCinemaTable = new System.Windows.Forms.DataGridView();
            this.expectCheckPage = new System.Windows.Forms.TabPage();
            this.expectCheckTable = new System.Windows.Forms.DataGridView();
            this.passCheckPage = new System.Windows.Forms.TabPage();
            this.passCheckTable = new System.Windows.Forms.DataGridView();
            this.cheduleCheckPage = new System.Windows.Forms.TabPage();
            this.cheduleCheckTable = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.allCinemaControl.SuspendLayout();
            this.allCinemaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCinemaTable)).BeginInit();
            this.expectCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectCheckTable)).BeginInit();
            this.passCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passCheckTable)).BeginInit();
            this.cheduleCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheduleCheckTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addCinema
            // 
            this.addCinema.Location = new System.Drawing.Point(7, 65);
            this.addCinema.Name = "addCinema";
            this.addCinema.Size = new System.Drawing.Size(75, 23);
            this.addCinema.TabIndex = 2;
            this.addCinema.Text = "Добавить";
            this.addCinema.UseVisualStyleBackColor = true;
            this.addCinema.Click += new System.EventHandler(this.addCinema_Click);
            // 
            // deleteCinema
            // 
            this.deleteCinema.Location = new System.Drawing.Point(169, 64);
            this.deleteCinema.Name = "deleteCinema";
            this.deleteCinema.Size = new System.Drawing.Size(75, 23);
            this.deleteCinema.TabIndex = 3;
            this.deleteCinema.Text = "Удалить";
            this.deleteCinema.UseVisualStyleBackColor = true;
            this.deleteCinema.Click += new System.EventHandler(this.deleteCinema_Click);
            // 
            // changeCinema
            // 
            this.changeCinema.Location = new System.Drawing.Point(88, 64);
            this.changeCinema.Name = "changeCinema";
            this.changeCinema.Size = new System.Drawing.Size(75, 23);
            this.changeCinema.TabIndex = 4;
            this.changeCinema.Text = "Изменить";
            this.changeCinema.UseVisualStyleBackColor = true;
            this.changeCinema.Click += new System.EventHandler(this.changeCinema_Click);
            // 
            // importFile
            // 
            this.importFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importFile.Location = new System.Drawing.Point(640, 65);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(148, 23);
            this.importFile.TabIndex = 5;
            this.importFile.Text = "Импортировать данные";
            this.importFile.UseVisualStyleBackColor = true;
            this.importFile.Click += new System.EventHandler(this.importFile_Click);
            // 
            // saveChange
            // 
            this.saveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChange.Location = new System.Drawing.Point(503, 66);
            this.saveChange.Name = "saveChange";
            this.saveChange.Size = new System.Drawing.Size(131, 23);
            this.saveChange.TabIndex = 6;
            this.saveChange.Text = "Сохранить";
            this.saveChange.UseVisualStyleBackColor = true;
            this.saveChange.Click += new System.EventHandler(this.saveChange_Click);
            // 
            // allCinemaControl
            // 
            this.allCinemaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allCinemaControl.Controls.Add(this.allCinemaPage);
            this.allCinemaControl.Controls.Add(this.expectCheckPage);
            this.allCinemaControl.Controls.Add(this.passCheckPage);
            this.allCinemaControl.Controls.Add(this.cheduleCheckPage);
            this.allCinemaControl.Location = new System.Drawing.Point(3, 107);
            this.allCinemaControl.Name = "allCinemaControl";
            this.allCinemaControl.SelectedIndex = 0;
            this.allCinemaControl.Size = new System.Drawing.Size(797, 374);
            this.allCinemaControl.TabIndex = 7;
            // 
            // allCinemaPage
            // 
            this.allCinemaPage.Controls.Add(this.allCinemaTable);
            this.allCinemaPage.Location = new System.Drawing.Point(4, 22);
            this.allCinemaPage.Name = "allCinemaPage";
            this.allCinemaPage.Padding = new System.Windows.Forms.Padding(3);
            this.allCinemaPage.Size = new System.Drawing.Size(789, 348);
            this.allCinemaPage.TabIndex = 0;
            this.allCinemaPage.Text = "Все фирмы";
            this.allCinemaPage.UseVisualStyleBackColor = true;
            // 
            // allCinemaTable
            // 
            this.allCinemaTable.AllowUserToAddRows = false;
            this.allCinemaTable.AllowUserToDeleteRows = false;
            this.allCinemaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCinemaTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCinemaTable.Location = new System.Drawing.Point(3, 3);
            this.allCinemaTable.Name = "allCinemaTable";
            this.allCinemaTable.ReadOnly = true;
            this.allCinemaTable.Size = new System.Drawing.Size(783, 342);
            this.allCinemaTable.TabIndex = 1;
            this.allCinemaTable.SelectionChanged += new System.EventHandler(this.allCinemaTable_SelectionChanged);
            // 
            // expectCheckPage
            // 
            this.expectCheckPage.Controls.Add(this.expectCheckTable);
            this.expectCheckPage.Location = new System.Drawing.Point(4, 22);
            this.expectCheckPage.Name = "expectCheckPage";
            this.expectCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.expectCheckPage.Size = new System.Drawing.Size(789, 348);
            this.expectCheckPage.TabIndex = 1;
            this.expectCheckPage.Text = "Ожидают проверки";
            this.expectCheckPage.UseVisualStyleBackColor = true;
            // 
            // expectCheckTable
            // 
            this.expectCheckTable.AllowUserToAddRows = false;
            this.expectCheckTable.AllowUserToDeleteRows = false;
            this.expectCheckTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expectCheckTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectCheckTable.Location = new System.Drawing.Point(3, 3);
            this.expectCheckTable.Name = "expectCheckTable";
            this.expectCheckTable.ReadOnly = true;
            this.expectCheckTable.Size = new System.Drawing.Size(783, 342);
            this.expectCheckTable.TabIndex = 0;
            this.expectCheckTable.SelectionChanged += new System.EventHandler(this.expectCheckTable_SelectionChanged);
            // 
            // passCheckPage
            // 
            this.passCheckPage.Controls.Add(this.passCheckTable);
            this.passCheckPage.Location = new System.Drawing.Point(4, 22);
            this.passCheckPage.Name = "passCheckPage";
            this.passCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.passCheckPage.Size = new System.Drawing.Size(789, 348);
            this.passCheckPage.TabIndex = 2;
            this.passCheckPage.Text = "Прошли проверку";
            this.passCheckPage.UseVisualStyleBackColor = true;
            // 
            // passCheckTable
            // 
            this.passCheckTable.AllowUserToAddRows = false;
            this.passCheckTable.AllowUserToDeleteRows = false;
            this.passCheckTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passCheckTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passCheckTable.Location = new System.Drawing.Point(3, 3);
            this.passCheckTable.Name = "passCheckTable";
            this.passCheckTable.ReadOnly = true;
            this.passCheckTable.Size = new System.Drawing.Size(783, 342);
            this.passCheckTable.TabIndex = 0;
            this.passCheckTable.SelectionChanged += new System.EventHandler(this.passCheckTable_SelectionChanged);
            // 
            // cheduleCheckPage
            // 
            this.cheduleCheckPage.Controls.Add(this.cheduleCheckTable);
            this.cheduleCheckPage.Location = new System.Drawing.Point(4, 22);
            this.cheduleCheckPage.Name = "cheduleCheckPage";
            this.cheduleCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.cheduleCheckPage.Size = new System.Drawing.Size(789, 348);
            this.cheduleCheckPage.TabIndex = 3;
            this.cheduleCheckPage.Text = "Запланированная проверка";
            this.cheduleCheckPage.UseVisualStyleBackColor = true;
            // 
            // cheduleCheckTable
            // 
            this.cheduleCheckTable.AllowUserToAddRows = false;
            this.cheduleCheckTable.AllowUserToDeleteRows = false;
            this.cheduleCheckTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheduleCheckTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cheduleCheckTable.Location = new System.Drawing.Point(3, 3);
            this.cheduleCheckTable.Name = "cheduleCheckTable";
            this.cheduleCheckTable.ReadOnly = true;
            this.cheduleCheckTable.Size = new System.Drawing.Size(783, 342);
            this.cheduleCheckTable.TabIndex = 0;
            this.cheduleCheckTable.SelectionChanged += new System.EventHandler(this.cheduleCheckTable_SelectionChanged);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(654, 91);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(137, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата сегодня: 00.00.0000";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(790, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.TabStop = false;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(790, 46);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Начните писать текст для поиска по таблице...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.allCinemaControl);
            this.Controls.Add(this.saveChange);
            this.Controls.Add(this.importFile);
            this.Controls.Add(this.changeCinema);
            this.Controls.Add(this.deleteCinema);
            this.Controls.Add(this.addCinema);
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "GeneralForm";
            this.Text = "Cinema Base";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.allCinemaControl.ResumeLayout(false);
            this.allCinemaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCinemaTable)).EndInit();
            this.expectCheckPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expectCheckTable)).EndInit();
            this.passCheckPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passCheckTable)).EndInit();
            this.cheduleCheckPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cheduleCheckTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addCinema;
        private System.Windows.Forms.Button deleteCinema;
        private System.Windows.Forms.Button changeCinema;
        private System.Windows.Forms.Button importFile;
        private System.Windows.Forms.Button saveChange;
        private System.Windows.Forms.TabControl allCinemaControl;
        private System.Windows.Forms.TabPage allCinemaPage;
        private System.Windows.Forms.TabPage expectCheckPage;
        private System.Windows.Forms.TabPage passCheckPage;
        private System.Windows.Forms.TabPage cheduleCheckPage;
        private System.Windows.Forms.DataGridView allCinemaTable;
        private System.Windows.Forms.DataGridView expectCheckTable;
        protected internal System.Windows.Forms.DataGridView passCheckTable;
        private System.Windows.Forms.DataGridView cheduleCheckTable;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

