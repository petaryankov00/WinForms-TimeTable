﻿
namespace TimeTable.Projects
{
    partial class ProjectViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionDropdown = new System.Windows.Forms.ComboBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AllEmployeesGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.WorkedHoursGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddHoursButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedHoursGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(20, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Start date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(23, 272);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(259, 26);
            this.StartDatePicker.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(325, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "End date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.Location = new System.Drawing.Point(328, 272);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(258, 26);
            this.EndDatePicker.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(20, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Maximum working hours";
            // 
            // PositionDropdown
            // 
            this.PositionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionDropdown.FormattingEnabled = true;
            this.PositionDropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "7",
            "8"});
            this.PositionDropdown.Location = new System.Drawing.Point(23, 221);
            this.PositionDropdown.Name = "PositionDropdown";
            this.PositionDropdown.Size = new System.Drawing.Size(226, 28);
            this.PositionDropdown.TabIndex = 31;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(23, 119);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(563, 68);
            this.DescriptionTextBox.TabIndex = 30;
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.White;
            this.LabelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelMiddleName.Location = new System.Drawing.Point(20, 99);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(79, 17);
            this.LabelMiddleName.TabIndex = 29;
            this.LabelMiddleName.Text = "Description";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(23, 58);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(563, 30);
            this.ProjectNameTextBox.TabIndex = 28;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.White;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFirstName.Location = new System.Drawing.Point(20, 38);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(45, 17);
            this.LabelFirstName.TabIndex = 27;
            this.LabelFirstName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(325, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status";
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(328, 221);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(226, 28);
            this.StatusBox.TabIndex = 37;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1108, 58);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(70, 23);
            this.SearchButton.TabIndex = 42;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(646, 58);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(434, 23);
            this.SearchBox.TabIndex = 41;
            // 
            // AllEmployeesGridView
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllEmployeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.AllEmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployeesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.StartDate,
            this.EndDate,
            this.Status});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllEmployeesGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.AllEmployeesGridView.Location = new System.Drawing.Point(646, 87);
            this.AllEmployeesGridView.Name = "AllEmployeesGridView";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllEmployeesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.AllEmployeesGridView.Size = new System.Drawing.Size(532, 228);
            this.AllEmployeesGridView.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "All Projects";
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(112, 322);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 41);
            this.CancelButton.TabIndex = 44;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(299, 322);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(225, 41);
            this.EditButton.TabIndex = 43;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // WorkedHoursGridView
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkedHoursGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.WorkedHoursGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkedHoursGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.RegisteredHours,
            this.EmployeeCount});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkedHoursGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.WorkedHoursGridView.Location = new System.Drawing.Point(25, 426);
            this.WorkedHoursGridView.Name = "WorkedHoursGridView";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkedHoursGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.WorkedHoursGridView.Size = new System.Drawing.Size(532, 162);
            this.WorkedHoursGridView.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Employees";
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // RegisteredHours
            // 
            this.RegisteredHours.HeaderText = "Registered Hours";
            this.RegisteredHours.Name = "RegisteredHours";
            // 
            // EmployeeCount
            // 
            this.EmployeeCount.HeaderText = "Employee Count";
            this.EmployeeCount.Name = "EmployeeCount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(855, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Register Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(774, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Month";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(777, 437);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 26);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // AddHoursButton
            // 
            this.AddHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHoursButton.Location = new System.Drawing.Point(858, 478);
            this.AddHoursButton.Name = "AddHoursButton";
            this.AddHoursButton.Size = new System.Drawing.Size(140, 36);
            this.AddHoursButton.TabIndex = 50;
            this.AddHoursButton.Text = "Add ";
            this.AddHoursButton.UseVisualStyleBackColor = true;
            // 
            // ProjectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 615);
            this.Controls.Add(this.AddHoursButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WorkedHoursGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AllEmployeesGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PositionDropdown);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.LabelFirstName);
            this.Name = "ProjectViewForm";
            this.Text = "ProjectViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedHoursGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PositionDropdown;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView AllEmployeesGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView WorkedHoursGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddHoursButton;
    }
}