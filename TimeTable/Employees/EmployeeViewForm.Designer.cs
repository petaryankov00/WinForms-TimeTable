
namespace TimeTable.Employees
{
    partial class EmployeeViewForm
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
            this.EmployeeViewHeader = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartingDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionDropdown = new System.Windows.Forms.ComboBox();
            this.EGNTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AllEmployeesGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddWorkedTimeButton = new System.Windows.Forms.Button();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkedHoursGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedHoursGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeViewHeader
            // 
            this.EmployeeViewHeader.AutoSize = true;
            this.EmployeeViewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeViewHeader.Location = new System.Drawing.Point(417, 9);
            this.EmployeeViewHeader.Name = "EmployeeViewHeader";
            this.EmployeeViewHeader.Size = new System.Drawing.Size(195, 39);
            this.EmployeeViewHeader.TabIndex = 0;
            this.EmployeeViewHeader.Text = "Employees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(226, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Start date";
            // 
            // StartingDate
            // 
            this.StartingDate.CustomFormat = "yyyy-MM-dd";
            this.StartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartingDate.Location = new System.Drawing.Point(230, 254);
            this.StartingDate.Name = "StartingDate";
            this.StartingDate.Size = new System.Drawing.Size(197, 30);
            this.StartingDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(10, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Position";
            // 
            // PositionDropdown
            // 
            this.PositionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PositionDropdown.FormattingEnabled = true;
            this.PositionDropdown.Items.AddRange(new object[] {
            ".NET",
            "Java",
            "HR",
            "QA"});
            this.PositionDropdown.Location = new System.Drawing.Point(11, 247);
            this.PositionDropdown.Name = "PositionDropdown";
            this.PositionDropdown.Size = new System.Drawing.Size(195, 37);
            this.PositionDropdown.TabIndex = 23;
            // 
            // EGNTextBox
            // 
            this.EGNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EGNTextBox.Location = new System.Drawing.Point(230, 182);
            this.EGNTextBox.Name = "EGNTextBox";
            this.EGNTextBox.ReadOnly = true;
            this.EGNTextBox.Size = new System.Drawing.Size(194, 36);
            this.EGNTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(226, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Personal Identification Number";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(11, 182);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(195, 36);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.Color.White;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LastNameLabel.Location = new System.Drawing.Point(8, 162);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.LastNameLabel.TabIndex = 19;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmployeeDetailsLabel
            // 
            this.EmployeeDetailsLabel.AutoSize = true;
            this.EmployeeDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetailsLabel.Location = new System.Drawing.Point(143, 60);
            this.EmployeeDetailsLabel.Name = "EmployeeDetailsLabel";
            this.EmployeeDetailsLabel.Size = new System.Drawing.Size(212, 29);
            this.EmployeeDetailsLabel.TabIndex = 28;
            this.EmployeeDetailsLabel.Text = "Employee Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "All Employees";
            // 
            // AllEmployeesGridView
            // 
            this.AllEmployeesGridView.AllowUserToAddRows = false;
            this.AllEmployeesGridView.AllowUserToDeleteRows = false;
            this.AllEmployeesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AllEmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployeesGridView.Location = new System.Drawing.Point(433, 137);
            this.AllEmployeesGridView.Name = "AllEmployeesGridView";
            this.AllEmployeesGridView.ReadOnly = true;
            this.AllEmployeesGridView.RowHeadersWidth = 51;
            this.AllEmployeesGridView.ShowEditingIcon = false;
            this.AllEmployeesGridView.Size = new System.Drawing.Size(615, 228);
            this.AllEmployeesGridView.TabIndex = 30;
            this.AllEmployeesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllEmployeesGridView_CellContentClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(433, 108);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(517, 26);
            this.SearchBox.TabIndex = 32;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(963, 108);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 33;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(271, 324);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(152, 41);
            this.EditButton.TabIndex = 35;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(11, 324);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 41);
            this.CancelButton.TabIndex = 36;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddWorkedTimeButton
            // 
            this.AddWorkedTimeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddWorkedTimeButton.FlatAppearance.BorderSize = 0;
            this.AddWorkedTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWorkedTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWorkedTimeButton.Location = new System.Drawing.Point(126, 324);
            this.AddWorkedTimeButton.Name = "AddWorkedTimeButton";
            this.AddWorkedTimeButton.Size = new System.Drawing.Size(139, 41);
            this.AddWorkedTimeButton.TabIndex = 37;
            this.AddWorkedTimeButton.Text = "Add Worked Time";
            this.AddWorkedTimeButton.UseVisualStyleBackColor = false;
            this.AddWorkedTimeButton.Click += new System.EventHandler(this.AddWorkedTimeButton_Click);
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameTextBox.Location = new System.Drawing.Point(230, 123);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(195, 36);
            this.MiddleNameTextBox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(228, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Middle Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(11, 123);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(195, 36);
            this.FirstNameTextBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Worked Hours";
            // 
            // WorkedHoursGridView
            // 
            this.WorkedHoursGridView.AllowUserToAddRows = false;
            this.WorkedHoursGridView.AllowUserToDeleteRows = false;
            this.WorkedHoursGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.WorkedHoursGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkedHoursGridView.Location = new System.Drawing.Point(77, 421);
            this.WorkedHoursGridView.Name = "WorkedHoursGridView";
            this.WorkedHoursGridView.ReadOnly = true;
            this.WorkedHoursGridView.RowHeadersWidth = 51;
            this.WorkedHoursGridView.Size = new System.Drawing.Size(295, 159);
            this.WorkedHoursGridView.TabIndex = 43;
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 598);
            this.Controls.Add(this.WorkedHoursGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddWorkedTimeButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AllEmployeesGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDetailsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PositionDropdown);
            this.Controls.Add(this.EGNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.EmployeeViewHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeViewForm";
            this.Load += new System.EventHandler(this.EmployeeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedHoursGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeViewHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StartingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PositionDropdown;
        private System.Windows.Forms.TextBox EGNTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmployeeDetailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllEmployeesGridView;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddWorkedTimeButton;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView WorkedHoursGridView;
    }
}