namespace LibrarySystem
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtEnterEnroll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBookIssueDate = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.識別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.科系 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借書日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.還書日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.txtEnterEnroll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 487);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(188, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(34, 406);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 55);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchStudent.Location = new System.Drawing.Point(96, 275);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(158, 65);
            this.btnSearchStudent.TabIndex = 3;
            this.btnSearchStudent.Text = "搜尋學員";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtEnterEnroll
            // 
            this.txtEnterEnroll.Location = new System.Drawing.Point(75, 217);
            this.txtEnterEnroll.Name = "txtEnterEnroll";
            this.txtEnterEnroll.Size = new System.Drawing.Size(204, 34);
            this.txtEnterEnroll.TabIndex = 2;
            this.txtEnterEnroll.TextChanged += new System.EventHandler(this.txtEnterEnroll_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(119, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入學號";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.識別,
            this.學號,
            this.姓名,
            this.科系,
            this.學期,
            this.電話,
            this.信箱,
            this.書名,
            this.借書日期,
            this.還書日期});
            this.dataGridView1.Location = new System.Drawing.Point(356, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(827, 279);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtBookIssueDate);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(356, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 202);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(635, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 55);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.Location = new System.Drawing.Point(635, 37);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 55);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "還書";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 34);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtBookIssueDate
            // 
            this.txtBookIssueDate.Location = new System.Drawing.Point(271, 84);
            this.txtBookIssueDate.Name = "txtBookIssueDate";
            this.txtBookIssueDate.Size = new System.Drawing.Size(300, 34);
            this.txtBookIssueDate.TabIndex = 4;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(271, 37);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(300, 34);
            this.txtBookName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(93, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "還書日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(93, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "借書日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(93, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "書名";
            // 
            // 識別
            // 
            this.識別.DataPropertyName = "id";
            this.識別.HeaderText = "識別";
            this.識別.MinimumWidth = 6;
            this.識別.Name = "識別";
            this.識別.Width = 80;
            // 
            // 學號
            // 
            this.學號.DataPropertyName = "std_enroll";
            this.學號.HeaderText = "學號";
            this.學號.MinimumWidth = 6;
            this.學號.Name = "學號";
            this.學號.Width = 125;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "std_name";
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 6;
            this.姓名.Name = "姓名";
            this.姓名.Width = 125;
            // 
            // 科系
            // 
            this.科系.DataPropertyName = "std_dep";
            this.科系.HeaderText = "科系";
            this.科系.MinimumWidth = 6;
            this.科系.Name = "科系";
            this.科系.Width = 80;
            // 
            // 學期
            // 
            this.學期.DataPropertyName = "std_sem";
            this.學期.HeaderText = "學期";
            this.學期.MinimumWidth = 6;
            this.學期.Name = "學期";
            this.學期.Width = 80;
            // 
            // 電話
            // 
            this.電話.DataPropertyName = "std_contact";
            this.電話.HeaderText = "電話";
            this.電話.MinimumWidth = 6;
            this.電話.Name = "電話";
            this.電話.Width = 125;
            // 
            // 信箱
            // 
            this.信箱.DataPropertyName = "std_email";
            this.信箱.HeaderText = "信箱";
            this.信箱.MinimumWidth = 6;
            this.信箱.Name = "信箱";
            this.信箱.Width = 200;
            // 
            // 書名
            // 
            this.書名.DataPropertyName = "book_name";
            this.書名.HeaderText = "書名";
            this.書名.MinimumWidth = 6;
            this.書名.Name = "書名";
            this.書名.Width = 200;
            // 
            // 借書日期
            // 
            this.借書日期.DataPropertyName = "book_issue_date";
            this.借書日期.HeaderText = "借書日期";
            this.借書日期.MinimumWidth = 6;
            this.借書日期.Name = "借書日期";
            this.借書日期.Width = 200;
            // 
            // 還書日期
            // 
            this.還書日期.DataPropertyName = "book_return_date";
            this.還書日期.HeaderText = "還書日期";
            this.還書日期.MinimumWidth = 6;
            this.還書日期.Name = "還書日期";
            this.還書日期.Width = 200;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1195, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtEnterEnroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBookIssueDate;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 識別;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 科系;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借書日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 還書日期;
    }
}