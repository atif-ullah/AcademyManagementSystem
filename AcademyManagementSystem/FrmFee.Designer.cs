namespace AcademyManagementSystem
{
    partial class FrmFee
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
            this.Expense = new System.Windows.Forms.Label();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFeeAmount = new System.Windows.Forms.Label();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.dtpPaid = new System.Windows.Forms.DateTimePicker();
            this.dtpUpPaid = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGoToHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // Expense
            // 
            this.Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense.ForeColor = System.Drawing.SystemColors.Control;
            this.Expense.Location = new System.Drawing.Point(7, 94);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(120, 33);
            this.Expense.TabIndex = 65;
            this.Expense.Text = "Student";
            // 
            // DgvList
            // 
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvList.Location = new System.Drawing.Point(433, 200);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowHeadersWidth = 62;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(480, 371);
            this.DgvList.TabIndex = 64;
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
            // LblFeeAmount
            // 
            this.LblFeeAmount.Location = new System.Drawing.Point(336, 147);
            this.LblFeeAmount.Name = "LblFeeAmount";
            this.LblFeeAmount.Size = new System.Drawing.Size(18, 23);
            this.LblFeeAmount.TabIndex = 70;
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Enabled = false;
            this.txtFeeAmount.Location = new System.Drawing.Point(126, 173);
            this.txtFeeAmount.Multiline = true;
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(227, 33);
            this.txtFeeAmount.TabIndex = 69;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.Control;
            this.Amount.Location = new System.Drawing.Point(6, 173);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 33);
            this.Amount.TabIndex = 68;
            this.Amount.Text = "FeeAmount";
            // 
            // lblStudentId
            // 
            this.lblStudentId.Location = new System.Drawing.Point(336, 68);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(18, 23);
            this.lblStudentId.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(23, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(331, 52);
            this.btnSubmit.TabIndex = 62;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.label1.TabIndex = 60;
            this.label1.Text = "Fee Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlStudent
            // 
            this.ddlStudent.FormattingEnabled = true;
            this.ddlStudent.Location = new System.Drawing.Point(127, 98);
            this.ddlStudent.Name = "ddlStudent";
            this.ddlStudent.Size = new System.Drawing.Size(227, 28);
            this.ddlStudent.TabIndex = 81;
            this.ddlStudent.SelectionChangeCommitted += new System.EventHandler(this.ddlStudent_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(433, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "Paid Students";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 86;
            this.label3.Text = "CreatedAt";
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.CustomFormat = "MMMM/yyyy";
            this.dtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedAt.Location = new System.Drawing.Point(125, 267);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(227, 26);
            this.dtpCreatedAt.TabIndex = 87;
            // 
            // dtpPaid
            // 
            this.dtpPaid.CustomFormat = "MMMM/yyyy";
            this.dtpPaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaid.Location = new System.Drawing.Point(432, 151);
            this.dtpPaid.Name = "dtpPaid";
            this.dtpPaid.Size = new System.Drawing.Size(217, 26);
            this.dtpPaid.TabIndex = 88;
            this.dtpPaid.ValueChanged += new System.EventHandler(this.dtpPaid_ValueChanged);
            // 
            // dtpUpPaid
            // 
            this.dtpUpPaid.CustomFormat = "MMMM/yyyy";
            this.dtpUpPaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpPaid.Location = new System.Drawing.Point(682, 151);
            this.dtpUpPaid.Name = "dtpUpPaid";
            this.dtpUpPaid.Size = new System.Drawing.Size(229, 26);
            this.dtpUpPaid.TabIndex = 89;
            this.dtpUpPaid.ValueChanged += new System.EventHandler(this.dtpUpPaid_ValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(680, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 26);
            this.label4.TabIndex = 90;
            this.label4.Text = "Defaulter Students";
            // 
            // lblGoToHome
            // 
            this.lblGoToHome.AutoSize = true;
            this.lblGoToHome.Location = new System.Drawing.Point(817, 71);
            this.lblGoToHome.Name = "lblGoToHome";
            this.lblGoToHome.Size = new System.Drawing.Size(96, 20);
            this.lblGoToHome.TabIndex = 115;
            this.lblGoToHome.TabStop = true;
            this.lblGoToHome.Text = "Go to Home";
            this.lblGoToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoToHome_LinkClicked);
            // 
            // FrmFee
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 583);
            this.Controls.Add(this.lblGoToHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpUpPaid);
            this.Controls.Add(this.dtpPaid);
            this.Controls.Add(this.dtpCreatedAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlStudent);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.LblFeeAmount);
            this.Controls.Add(this.txtFeeAmount);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFee";
            this.Load += new System.EventHandler(this.FrmFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Expense;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label LblFeeAmount;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.DateTimePicker dtpPaid;
        private System.Windows.Forms.DateTimePicker dtpUpPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblGoToHome;
    }
}