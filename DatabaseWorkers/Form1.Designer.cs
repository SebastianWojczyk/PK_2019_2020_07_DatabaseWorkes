namespace DatabaseWorkers
{
    partial class Form1
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
            this.listBoxWorkes = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateBegin = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWorkes
            // 
            this.listBoxWorkes.FormattingEnabled = true;
            this.listBoxWorkes.Location = new System.Drawing.Point(13, 13);
            this.listBoxWorkes.Name = "listBoxWorkes";
            this.listBoxWorkes.Size = new System.Drawing.Size(319, 420);
            this.listBoxWorkes.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.22222F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateBegin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxManager, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 161);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data zatrudnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wynagrodzenie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kierownik";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(91, 29);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(91, 55);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateBegin.TabIndex = 7;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.DecimalPlaces = 2;
            this.numericUpDownSalary.Location = new System.Drawing.Point(91, 81);
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownSalary.TabIndex = 8;
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(91, 107);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(15, 14);
            this.checkBoxManager.TabIndex = 9;
            this.checkBoxManager.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(338, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxWorkes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBegin;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button buttonAdd;
    }
}

