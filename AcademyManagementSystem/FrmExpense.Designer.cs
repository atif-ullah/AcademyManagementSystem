namespace AcademyManagementSystem
{
    partial class FrmExpense
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
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExpenseheadName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ExpenseHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.Expense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.ddlExpenseHead = new System.Windows.Forms.ComboBox();
            this.lblGoToHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvList
            // 
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvList.Location = new System.Drawing.Point(448, 130);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowHeadersWidth = 62;
            this.DgvList.RowTemplate.Height = 28;
            this.DgvList.Size = new System.Drawing.Size(465, 441);
            this.DgvList.TabIndex = 51;
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
            // lblExpenseheadName
            // 
            this.lblExpenseheadName.Location = new System.Drawing.Point(345, 90);
            this.lblExpenseheadName.Name = "lblExpenseheadName";
            this.lblExpenseheadName.Size = new System.Drawing.Size(82, 23);
            this.lblExpenseheadName.TabIndex = 50;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(24, 348);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(358, 55);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ExpenseHead
            // 
            this.ExpenseHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExpenseHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseHead.ForeColor = System.Drawing.SystemColors.Control;
            this.ExpenseHead.Location = new System.Drawing.Point(19, 119);
            this.ExpenseHead.Name = "ExpenseHead";
            this.ExpenseHead.Size = new System.Drawing.Size(120, 30);
            this.ExpenseHead.TabIndex = 45;
            this.ExpenseHead.Text = "ExpenseHead ";
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
            this.label1.TabIndex = 44;
            this.label1.Text = "Expense Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(345, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 54;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(136, 193);
            this.txtExpense.Multiline = true;
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(246, 33);
            this.txtExpense.TabIndex = 53;
            // 
            // Expense
            // 
            this.Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense.ForeColor = System.Drawing.SystemColors.Control;
            this.Expense.Location = new System.Drawing.Point(19, 196);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(120, 30);
            this.Expense.TabIndex = 52;
            this.Expense.Text = "Expense";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(345, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 57;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(136, 272);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(246, 33);
            this.txtAmount.TabIndex = 56;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.Control;
            this.Amount.Location = new System.Drawing.Point(19, 275);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 30);
            this.Amount.TabIndex = 55;
            this.Amount.Text = "Amount";
            // 
            // ddlExpenseHead
            // 
            this.ddlExpenseHead.FormattingEnabled = true;
            this.ddlExpenseHead.Items.AddRange(new object[] {
            "Active ",
            "InActive"});
            this.ddlExpenseHead.Location = new System.Drawing.Point(136, 121);
            this.ddlExpenseHead.Name = "ddlExpenseHead";
            this.ddlExpenseHead.Size = new System.Drawing.Size(246, 28);
            this.ddlExpenseHead.TabIndex = 59;
            // 
            // lblGoToHome
            // 
            this.lblGoToHome.AutoSize = true;
            this.lblGoToHome.Location = new System.Drawing.Point(817, 93);
            this.lblGoToHome.Name = "lblGoToHome";
            this.lblGoToHome.Size = new System.Drawing.Size(96, 20);
            this.lblGoToHome.TabIndex = 113;
            this.lblGoToHome.TabStop = true;
            this.lblGoToHome.Text = "Go to Home";
            this.lblGoToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoToHome_LinkClicked);
            // 
            // FrmExpense
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 583);
            this.Controls.Add(this.lblGoToHome);
            this.Controls.Add(this.ddlExpenseHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.lblExpenseheadName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ExpenseHead);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpense";
            this.Load += new System.EventHandler(this.FrmExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblExpenseheadName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label ExpenseHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label Expense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.ComboBox ddlExpenseHead;
        private System.Windows.Forms.LinkLabel lblGoToHome;
    }
}