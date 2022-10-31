namespace LibrarySystem
{
    partial class CompleteBookDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.識別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.科系 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書籍名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借書日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.還書日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(433, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "借出書籍";
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
            this.書籍名稱,
            this.借書日期,
            this.還書日期});
            this.dataGridView1.Location = new System.Drawing.Point(11, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(978, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(433, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "還回書籍";
            // 
            // 識別
            // 
            this.識別.DataPropertyName = "id";
            this.識別.HeaderText = "識別";
            this.識別.MinimumWidth = 6;
            this.識別.Name = "識別";
            this.識別.Width = 75;
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
            this.科系.Width = 75;
            // 
            // 學期
            // 
            this.學期.DataPropertyName = "std_sem";
            this.學期.HeaderText = "學期";
            this.學期.MinimumWidth = 6;
            this.學期.Name = "學期";
            this.學期.Width = 75;
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
            this.信箱.Width = 175;
            // 
            // 書籍名稱
            // 
            this.書籍名稱.DataPropertyName = "book_name";
            this.書籍名稱.HeaderText = "書籍名稱";
            this.書籍名稱.MinimumWidth = 6;
            this.書籍名稱.Name = "書籍名稱";
            this.書籍名稱.Width = 175;
            // 
            // 借書日期
            // 
            this.借書日期.DataPropertyName = "book_issue_date";
            this.借書日期.HeaderText = "借書日期";
            this.借書日期.MinimumWidth = 6;
            this.借書日期.Name = "借書日期";
            this.借書日期.Width = 125;
            // 
            // 還書日期
            // 
            this.還書日期.DataPropertyName = "book_return_date";
            this.還書日期.HeaderText = "還書日期";
            this.還書日期.MinimumWidth = 6;
            this.還書日期.Name = "還書日期";
            this.還書日期.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView2.Location = new System.Drawing.Point(10, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(978, 219);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "識別";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "std_enroll";
            this.dataGridViewTextBoxColumn2.HeaderText = "學號";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "std_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "std_dep";
            this.dataGridViewTextBoxColumn4.HeaderText = "科系";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "std_sem";
            this.dataGridViewTextBoxColumn5.HeaderText = "學期";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "std_contact";
            this.dataGridViewTextBoxColumn6.HeaderText = "電話";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "std_email";
            this.dataGridViewTextBoxColumn7.HeaderText = "信箱";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "book_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "書籍名稱";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 175;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "book_issue_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "借書日期";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "book_return_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "還書日期";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1000, 568);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompleteBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBookDetails";
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 識別;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 科系;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書籍名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借書日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 還書日期;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}