
namespace TimeTable.Employees
{
    partial class EmployeeProjectsForm
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
            this.EmployeeProjectsGridView = new System.Windows.Forms.DataGridView();
            this.Hours = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateOfWorkedHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeProjectsGridView
            // 
            this.EmployeeProjectsGridView.AllowUserToAddRows = false;
            this.EmployeeProjectsGridView.AllowUserToDeleteRows = false;
            this.EmployeeProjectsGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeProjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeProjectsGridView.Location = new System.Drawing.Point(27, 28);
            this.EmployeeProjectsGridView.Name = "EmployeeProjectsGridView";
            this.EmployeeProjectsGridView.ReadOnly = true;
            this.EmployeeProjectsGridView.Size = new System.Drawing.Size(745, 181);
            this.EmployeeProjectsGridView.TabIndex = 0;
            this.EmployeeProjectsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeProjectsGridView_CellContentClick);
            // 
            // Hours
            // 
            this.Hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.FormattingEnabled = true;
            this.Hours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Hours.Location = new System.Drawing.Point(409, 241);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(256, 28);
            this.Hours.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(406, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Date";
            // 
            // DateOfWorkedHoursPicker
            // 
            this.DateOfWorkedHoursPicker.CustomFormat = "yyyy-MM-dd";
            this.DateOfWorkedHoursPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfWorkedHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfWorkedHoursPicker.Location = new System.Drawing.Point(409, 301);
            this.DateOfWorkedHoursPicker.Name = "DateOfWorkedHoursPicker";
            this.DateOfWorkedHoursPicker.Size = new System.Drawing.Size(256, 26);
            this.DateOfWorkedHoursPicker.TabIndex = 66;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(129, 303);
            this.DescriptionTextBox.MinimumSize = new System.Drawing.Size(214, 99);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(259, 129);
            this.DescriptionTextBox.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(129, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Description";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(578, 351);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(87, 36);
            this.EditButton.TabIndex = 63;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.White;
            this.LabelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelMiddleName.Location = new System.Drawing.Point(406, 221);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(46, 17);
            this.LabelMiddleName.TabIndex = 62;
            this.LabelMiddleName.Text = "Hours";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(132, 241);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.ReadOnly = true;
            this.ProjectNameTextBox.Size = new System.Drawing.Size(256, 30);
            this.ProjectNameTextBox.TabIndex = 61;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.White;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFirstName.Location = new System.Drawing.Point(129, 221);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(93, 17);
            this.LabelFirstName.TabIndex = 60;
            this.LabelFirstName.Text = "Project Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(485, 351);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 36);
            this.DeleteButton.TabIndex = 69;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(409, 351);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(70, 36);
            this.CancelButton.TabIndex = 70;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmployeeProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateOfWorkedHoursPicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.EmployeeProjectsGridView);
            this.Name = "EmployeeProjectsForm";
            this.Text = "EmployeeProjectsForm";
            this.Load += new System.EventHandler(this.EmployeeProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeProjectsGridView;
        private System.Windows.Forms.ComboBox Hours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateOfWorkedHoursPicker;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
    }
}