namespace DataBaseCinema
{
    partial class AddForm
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
            this.add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameCinema = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yearCheck = new System.Windows.Forms.NumericUpDown();
            this.mounthCheck = new System.Windows.Forms.NumericUpDown();
            this.dayCheck = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearCheckNext = new System.Windows.Forms.NumericUpDown();
            this.mounthCheckNext = new System.Windows.Forms.NumericUpDown();
            this.dayCheckNext = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPlanned = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mounthCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearCheckNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mounthCheckNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCheckNext)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(550, 141);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(633, 141);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nameCinema);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 60);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наименование";
            // 
            // nameCinema
            // 
            this.nameCinema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCinema.Location = new System.Drawing.Point(3, 19);
            this.nameCinema.Multiline = true;
            this.nameCinema.Name = "nameCinema";
            this.nameCinema.Size = new System.Drawing.Size(692, 35);
            this.nameCinema.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.yearCheck);
            this.groupBox2.Controls.Add(this.mounthCheck);
            this.groupBox2.Controls.Add(this.dayCheck);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yearCheckNext);
            this.groupBox2.Controls.Add(this.mounthCheckNext);
            this.groupBox2.Controls.Add(this.dayCheckNext);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 66);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Год";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Месяц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "День";
            // 
            // yearCheck
            // 
            this.yearCheck.Location = new System.Drawing.Point(267, 33);
            this.yearCheck.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearCheck.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yearCheck.Name = "yearCheck";
            this.yearCheck.Size = new System.Drawing.Size(52, 20);
            this.yearCheck.TabIndex = 31;
            this.yearCheck.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // mounthCheck
            // 
            this.mounthCheck.Location = new System.Drawing.Point(209, 33);
            this.mounthCheck.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mounthCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mounthCheck.Name = "mounthCheck";
            this.mounthCheck.Size = new System.Drawing.Size(52, 20);
            this.mounthCheck.TabIndex = 30;
            this.mounthCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayCheck
            // 
            this.dayCheck.Location = new System.Drawing.Point(151, 33);
            this.dayCheck.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayCheck.Name = "dayCheck";
            this.dayCheck.Size = new System.Drawing.Size(52, 20);
            this.dayCheck.TabIndex = 29;
            this.dayCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Месяц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "День";
            // 
            // yearCheckNext
            // 
            this.yearCheckNext.Location = new System.Drawing.Point(643, 31);
            this.yearCheckNext.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearCheckNext.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yearCheckNext.Name = "yearCheckNext";
            this.yearCheckNext.Size = new System.Drawing.Size(52, 20);
            this.yearCheckNext.TabIndex = 25;
            this.yearCheckNext.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // mounthCheckNext
            // 
            this.mounthCheckNext.Location = new System.Drawing.Point(585, 31);
            this.mounthCheckNext.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mounthCheckNext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mounthCheckNext.Name = "mounthCheckNext";
            this.mounthCheckNext.Size = new System.Drawing.Size(52, 20);
            this.mounthCheckNext.TabIndex = 24;
            this.mounthCheckNext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayCheckNext
            // 
            this.dayCheckNext.Location = new System.Drawing.Point(527, 31);
            this.dayCheckNext.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayCheckNext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayCheckNext.Name = "dayCheckNext";
            this.dayCheckNext.Size = new System.Drawing.Size(52, 20);
            this.dayCheckNext.TabIndex = 23;
            this.dayCheckNext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата следующей проверки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дата последней проверки";
            // 
            // checkBoxPlanned
            // 
            this.checkBoxPlanned.AutoSize = true;
            this.checkBoxPlanned.Checked = true;
            this.checkBoxPlanned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlanned.Location = new System.Drawing.Point(16, 140);
            this.checkBoxPlanned.Name = "checkBoxPlanned";
            this.checkBoxPlanned.Size = new System.Drawing.Size(111, 17);
            this.checkBoxPlanned.TabIndex = 23;
            this.checkBoxPlanned.Text = "Запланированно";
            this.checkBoxPlanned.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 169);
            this.Controls.Add(this.checkBoxPlanned);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mounthCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearCheckNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mounthCheckNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCheckNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameCinema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown yearCheck;
        private System.Windows.Forms.NumericUpDown mounthCheck;
        private System.Windows.Forms.NumericUpDown dayCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yearCheckNext;
        private System.Windows.Forms.NumericUpDown mounthCheckNext;
        private System.Windows.Forms.NumericUpDown dayCheckNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPlanned;
    }
}