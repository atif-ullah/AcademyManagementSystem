namespace AcademyManagementSystem
{
    partial class FrmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalary));
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Expense = new System.Windows.Forms.Label();
            this.lblSalaryAmount = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ddlTeacher = new System.Windows.Forms.ComboBox();
            this.txtSalaryAmount = new System.Windows.Forms.TextBox();
            this.ddlPercentage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpUnPaid = new System.Windows.Forms.DateTimePicker();
            this.dtpPaid = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblGoToHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvList
            // 
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvList.Location = new System.Drawing.Point(387, 185);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowHeadersWidth = 62;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(526, 386);
            this.DgvList.TabIndex = 73;
            this.DgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edit";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Invoice";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 53);
            this.label1.TabIndex = 71;
            this.label1.Text = "Salary Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Expense
            // 
            this.Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense.ForeColor = System.Drawing.SystemColors.Control;
            this.Expense.Location = new System.Drawing.Point(7, 93);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(120, 30);
            this.Expense.TabIndex = 74;
            this.Expense.Text = "Teacher";
            // 
            // lblSalaryAmount
            // 
            this.lblSalaryAmount.Location = new System.Drawing.Point(240, 250);
            this.lblSalaryAmount.Name = "lblSalaryAmount";
            this.lblSalaryAmount.Size = new System.Drawing.Size(100, 23);
            this.lblSalaryAmount.TabIndex = 79;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.Control;
            this.Amount.Location = new System.Drawing.Point(6, 279);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 30);
            this.Amount.TabIndex = 77;
            this.Amount.Text = "SalaryAmount";
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.Location = new System.Drawing.Point(240, 68);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(100, 23);
            this.lblTeacherId.TabIndex = 76;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(10, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(319, 66);
            this.btnSubmit.TabIndex = 72;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ddlTeacher
            // 
            this.ddlTeacher.FormattingEnabled = true;
            this.ddlTeacher.Location = new System.Drawing.Point(126, 94);
            this.ddlTeacher.Name = "ddlTeacher";
            this.ddlTeacher.Size = new System.Drawing.Size(212, 28);
            this.ddlTeacher.TabIndex = 80;
            // 
            // txtSalaryAmount
            // 
            this.txtSalaryAmount.Location = new System.Drawing.Point(126, 276);
            this.txtSalaryAmount.Multiline = true;
            this.txtSalaryAmount.Name = "txtSalaryAmount";
            this.txtSalaryAmount.Size = new System.Drawing.Size(212, 33);
            this.txtSalaryAmount.TabIndex = 78;
            // 
            // ddlPercentage
            // 
            this.ddlPercentage.FormattingEnabled = true;
            this.ddlPercentage.Items.AddRange(new object[] {
            "Select Percentage",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.ddlPercentage.Location = new System.Drawing.Point(124, 186);
            this.ddlPercentage.Name = "ddlPercentage";
            this.ddlPercentage.Size = new System.Drawing.Size(212, 28);
            this.ddlPercentage.TabIndex = 90;
            this.ddlPercentage.SelectionChangeCommitted += new System.EventHandler(this.ddlPercentage_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 88;
            this.label3.Text = "Percentage";
            // 
            // lblPercentage
            // 
            this.lblPercentage.Location = new System.Drawing.Point(236, 160);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(100, 23);
            this.lblPercentage.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(632, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 27);
            this.label4.TabIndex = 94;
            this.label4.Text = "UnPaid Teachers";
            // 
            // dtpUnPaid
            // 
            this.dtpUnPaid.CustomFormat = "MMMM/yyyy";
            this.dtpUnPaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUnPaid.Location = new System.Drawing.Point(632, 145);
            this.dtpUnPaid.Name = "dtpUnPaid";
            this.dtpUnPaid.Size = new System.Drawing.Size(226, 26);
            this.dtpUnPaid.TabIndex = 93;
            this.dtpUnPaid.ValueChanged += new System.EventHandler(this.dtpUpPaid_ValueChanged);
            // 
            // dtpPaid
            // 
            this.dtpPaid.CustomFormat = "MMMM/yyyy";
            this.dtpPaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaid.Location = new System.Drawing.Point(392, 145);
            this.dtpPaid.Name = "dtpPaid";
            this.dtpPaid.Size = new System.Drawing.Size(221, 26);
            this.dtpPaid.TabIndex = 92;
            this.dtpPaid.ValueChanged += new System.EventHandler(this.dtpPaid_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(392, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 27);
            this.label2.TabIndex = 91;
            this.label2.Text = "Paid Teachers";
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.CustomFormat = "MMMM/yyyy";
            this.dtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedAt.Location = new System.Drawing.Point(128, 369);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(212, 26);
            this.dtpCreatedAt.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 95;
            this.label5.Text = "CreatedAt";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblGoToHome
            // 
            this.lblGoToHome.AutoSize = true;
            this.lblGoToHome.Location = new System.Drawing.Point(762, 71);
            this.lblGoToHome.Name = "lblGoToHome";
            this.lblGoToHome.Size = new System.Drawing.Size(96, 20);
            this.lblGoToHome.TabIndex = 116;
            this.lblGoToHome.TabStop = true;
            this.lblGoToHome.Text = "Go to Home";
            this.lblGoToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoToHome_LinkClicked);
            // 
            // FrmSalary
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 583);
            this.Controls.Add(this.lblGoToHome);
            this.Controls.Add(this.dtpCreatedAt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpUnPaid);
            this.Controls.Add(this.dtpPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.ddlTeacher);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.lblSalaryAmount);
            this.Controls.Add(this.txtSalaryAmount);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblTeacherId);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalary";
            this.Load += new System.EventHandler(this.FrmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Expense;
        private System.Windows.Forms.Label lblSalaryAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox ddlTeacher;
        private System.Windows.Forms.TextBox txtSalaryAmount;
        private System.Windows.Forms.ComboBox ddlPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpUnPaid;
        private System.Windows.Forms.DateTimePicker dtpPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.LinkLabel lblGoToHome;
    }
}