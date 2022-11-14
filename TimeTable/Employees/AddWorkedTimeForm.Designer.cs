
namespace TimeTable.Employees
{
    partial class AddWorkedTimeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.DateOfWorkedHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddHoursButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkedHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectsLabel = new System.Windows.Forms.Label();
            this.AddHoursTextBox = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(413, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Date";
            // 
            // DateOfWorkedHoursPicker
            // 
            this.DateOfWorkedHoursPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfWorkedHoursPicker.Location = new System.Drawing.Point(417, 318);
            this.DateOfWorkedHoursPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfWorkedHoursPicker.Name = "DateOfWorkedHoursPicker";
            this.DateOfWorkedHoursPicker.Size = new System.Drawing.Size(284, 30);
            this.DateOfWorkedHoursPicker.TabIndex = 57;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(103, 318);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTextBox.MinimumSize = new System.Drawing.Size(284, 121);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(284, 121);
            this.DescriptionTextBox.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(99, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Description";
            // 
            // AddHoursButton
            // 
            this.AddHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHoursButton.Location = new System.Drawing.Point(459, 381);
            this.AddHoursButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddHoursButton.Name = "AddHoursButton";
            this.AddHoursButton.Size = new System.Drawing.Size(187, 44);
            this.AddHoursButton.TabIndex = 54;
            this.AddHoursButton.Text = "Add Hours";
            this.AddHoursButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectStatus,
            this.WorkedHours});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(100, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(601, 142);
            this.dataGridView1.TabIndex = 53;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 125;
            // 
            // ProjectStatus
            // 
            this.ProjectStatus.HeaderText = "Status";
            this.ProjectStatus.MinimumWidth = 6;
            this.ProjectStatus.Name = "ProjectStatus";
            this.ProjectStatus.Width = 125;
            // 
            // WorkedHours
            // 
            this.WorkedHours.HeaderText = "Worked Hours";
            this.WorkedHours.MinimumWidth = 6;
            this.WorkedHours.Name = "WorkedHours";
            this.WorkedHours.Width = 125;
            // 
            // ProjectsLabel
            // 
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(347, 12);
            this.ProjectsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(105, 29);
            this.ProjectsLabel.TabIndex = 52;
            this.ProjectsLabel.Text = "Projects";
            // 
            // AddHoursTextBox
            // 
            this.AddHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHoursTextBox.Location = new System.Drawing.Point(417, 241);
            this.AddHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddHoursTextBox.Name = "AddHoursTextBox";
            this.AddHoursTextBox.Size = new System.Drawing.Size(284, 36);
            this.AddHoursTextBox.TabIndex = 51;
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.White;
            this.LabelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelMiddleName.Location = new System.Drawing.Point(413, 217);
            this.LabelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(55, 20);
            this.LabelMiddleName.TabIndex = 50;
            this.LabelMiddleName.Text = "Hours";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(103, 241);
            this.ProjectNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(284, 36);
            this.ProjectNameTextBox.TabIndex = 49;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.White;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFirstName.Location = new System.Drawing.Point(99, 216);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(111, 20);
            this.LabelFirstName.TabIndex = 48;
            this.LabelFirstName.Text = "Project Name";
            // 
            // AddWorkedTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateOfWorkedHoursPicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddHoursButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProjectsLabel);
            this.Controls.Add(this.AddHoursTextBox);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.LabelFirstName);
            this.Name = "AddWorkedTimeForm";
            this.Text = "AddWorkedTimeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateOfWorkedHoursPicker;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddHoursButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkedHours;
        private System.Windows.Forms.Label ProjectsLabel;
        private System.Windows.Forms.TextBox AddHoursTextBox;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label LabelFirstName;
    }
}