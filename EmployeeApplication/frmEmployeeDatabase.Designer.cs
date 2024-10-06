namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridViewEmployee = new DataGridView();
            txtEmployeeID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 35);
            label1.TabIndex = 0;
            label1.Text = "Add Employee : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Last name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 252);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Position *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(245, 19);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 5;
            label6.Text = "Employee List:";
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(245, 45);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 51;
            dataGridViewEmployee.Size = new Size(543, 302);
            dataGridViewEmployee.TabIndex = 6;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(12, 95);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(227, 27);
            txtEmployeeID.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 159);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(227, 27);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 219);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(227, 27);
            txtLastName.TabIndex = 9;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(12, 275);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(227, 27);
            txtPosition.TabIndex = 10;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(70, 308);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(111, 39);
            submitButton.TabIndex = 11;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(submitButton);
            Controls.Add(txtPosition);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeID);
            Controls.Add(dataGridViewEmployee);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmployeeDatabase";
            Text = "Form1";
            Load += frmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridViewEmployee;
        private TextBox txtEmployeeID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPosition;
        private Button submitButton;
    }
}
