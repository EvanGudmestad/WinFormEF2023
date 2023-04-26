namespace EFDemoLINQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResult = new Label();
            label1 = new Label();
            txtMinBudget = new TextBox();
            btnSearchCustomers = new Button();
            lblMinBudgetCust = new Label();
            btnIdSearch = new Button();
            txtCustId = new TextBox();
            label2 = new Label();
            txtAddBudget = new TextBox();
            txtAddName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnAddCustomer = new Button();
            cboCustIds = new ComboBox();
            label5 = new Label();
            btnDeleteCust = new Button();
            lblDelete = new Label();
            label6 = new Label();
            cboUpdateById = new ComboBox();
            lblUpdateCust = new Label();
            btnUpdate = new Button();
            txtUpdateBudget = new TextBox();
            txtUpdateName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(647, 374);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter a Minimum Budget:";
            // 
            // txtMinBudget
            // 
            txtMinBudget.Location = new Point(179, 26);
            txtMinBudget.Name = "txtMinBudget";
            txtMinBudget.Size = new Size(176, 23);
            txtMinBudget.TabIndex = 2;
            // 
            // btnSearchCustomers
            // 
            btnSearchCustomers.Location = new Point(379, 27);
            btnSearchCustomers.Name = "btnSearchCustomers";
            btnSearchCustomers.Size = new Size(85, 23);
            btnSearchCustomers.TabIndex = 3;
            btnSearchCustomers.Text = "Search";
            btnSearchCustomers.UseVisualStyleBackColor = true;
            btnSearchCustomers.Click += btnSearchCustomers_Click;
            // 
            // lblMinBudgetCust
            // 
            lblMinBudgetCust.AutoSize = true;
            lblMinBudgetCust.Location = new Point(501, 29);
            lblMinBudgetCust.Name = "lblMinBudgetCust";
            lblMinBudgetCust.Size = new Size(0, 15);
            lblMinBudgetCust.TabIndex = 4;
            // 
            // btnIdSearch
            // 
            btnIdSearch.Location = new Point(379, 66);
            btnIdSearch.Name = "btnIdSearch";
            btnIdSearch.Size = new Size(85, 23);
            btnIdSearch.TabIndex = 7;
            btnIdSearch.Text = "Search";
            btnIdSearch.UseVisualStyleBackColor = true;
            btnIdSearch.Click += btnIdSearch_Click;
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(179, 65);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(176, 23);
            txtCustId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter a Customer ID";
            // 
            // txtAddBudget
            // 
            txtAddBudget.Location = new Point(128, 278);
            txtAddBudget.Name = "txtAddBudget";
            txtAddBudget.Size = new Size(176, 23);
            txtAddBudget.TabIndex = 9;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(128, 239);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(176, 23);
            txtAddName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 242);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 286);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 11;
            label4.Text = "Budget:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(345, 258);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 23);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // cboCustIds
            // 
            cboCustIds.FormattingEnabled = true;
            cboCustIds.Location = new Point(680, 28);
            cboCustIds.Name = "cboCustIds";
            cboCustIds.Size = new Size(121, 23);
            cboCustIds.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 36);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 14;
            label5.Text = "Delete Customer By Id:";
            // 
            // btnDeleteCust
            // 
            btnDeleteCust.Location = new Point(818, 25);
            btnDeleteCust.Name = "btnDeleteCust";
            btnDeleteCust.Size = new Size(141, 23);
            btnDeleteCust.TabIndex = 15;
            btnDeleteCust.Text = "Delete Customer";
            btnDeleteCust.UseVisualStyleBackColor = true;
            btnDeleteCust.Click += btnDeleteCust_Click;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(1021, 23);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(0, 15);
            lblDelete.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 159);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 18;
            label6.Text = "Update Customer By Id:";
            // 
            // cboUpdateById
            // 
            cboUpdateById.FormattingEnabled = true;
            cboUpdateById.Location = new Point(680, 156);
            cboUpdateById.Name = "cboUpdateById";
            cboUpdateById.Size = new Size(121, 23);
            cboUpdateById.TabIndex = 17;
            cboUpdateById.SelectedIndexChanged += cboUpdateById_SelectedIndexChanged;
            // 
            // lblUpdateCust
            // 
            lblUpdateCust.AutoSize = true;
            lblUpdateCust.Location = new Point(850, 162);
            lblUpdateCust.Name = "lblUpdateCust";
            lblUpdateCust.Size = new Size(0, 15);
            lblUpdateCust.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(818, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update Customer";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUpdateBudget
            // 
            txtUpdateBudget.Location = new Point(700, 236);
            txtUpdateBudget.Name = "txtUpdateBudget";
            txtUpdateBudget.Size = new Size(176, 23);
            txtUpdateBudget.TabIndex = 22;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(700, 197);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(176, 23);
            txtUpdateName.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(562, 236);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 24;
            label7.Text = "Customer budget";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 205);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 23;
            label8.Text = "Customer Name:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 476);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtUpdateBudget);
            Controls.Add(txtUpdateName);
            Controls.Add(btnUpdate);
            Controls.Add(lblUpdateCust);
            Controls.Add(label6);
            Controls.Add(cboUpdateById);
            Controls.Add(lblDelete);
            Controls.Add(btnDeleteCust);
            Controls.Add(label5);
            Controls.Add(cboCustIds);
            Controls.Add(btnAddCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAddBudget);
            Controls.Add(txtAddName);
            Controls.Add(btnIdSearch);
            Controls.Add(txtCustId);
            Controls.Add(label2);
            Controls.Add(lblMinBudgetCust);
            Controls.Add(btnSearchCustomers);
            Controls.Add(txtMinBudget);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label label1;
        private TextBox txtMinBudget;
        private Button btnSearchCustomers;
        private Label lblMinBudgetCust;
        private Button btnIdSearch;
        private TextBox txtCustId;
        private Label label2;
        private TextBox txtAddBudget;
        private TextBox txtAddName;
        private Label label3;
        private Label label4;
        private Button btnAddCustomer;
        private ComboBox cboCustIds;
        private Label label5;
        private Button btnDeleteCust;
        private Label lblDelete;
        private Label label6;
        private ComboBox cboUpdateById;
        private Label lblUpdateCust;
        private Button btnUpdate;
        private TextBox txtUpdateBudget;
        private TextBox txtUpdateName;
        private Label label7;
        private Label label8;
    }
}