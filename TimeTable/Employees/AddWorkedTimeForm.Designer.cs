
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.DateOfWorkedHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddHoursButton = new System.Windows.Forms.Button();
            this.ProjectsGridView = new System.Windows.Forms.DataGridView();
            this.ProjectsLabel = new System.Windows.Forms.Label();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.MaxHours = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(310, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Date";
            // 
            // DateOfWorkedHoursPicker
            // 
            this.DateOfWorkedHoursPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfWorkedHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfWorkedHoursPicker.Location = new System.Drawing.Point(313, 258);
            this.DateOfWorkedHoursPicker.Name = "DateOfWorkedHoursPicker";
            this.DateOfWorkedHoursPicker.Size = new System.Drawing.Size(214, 26);
            this.DateOfWorkedHoursPicker.TabIndex = 57;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(77, 258);
            this.DescriptionTextBox.MinimumSize = new System.Drawing.Size(214, 99);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(214, 99);
            this.DescriptionTextBox.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(74, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Description";
            // 
            // AddHoursButton
            // 
            this.AddHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHoursButton.Location = new System.Drawing.Point(344, 310);
            this.AddHoursButton.Name = "AddHoursButton";
            this.AddHoursButton.Size = new System.Drawing.Size(140, 36);
            this.AddHoursButton.TabIndex = 54;
            this.AddHoursButton.Text = "Report";
            this.AddHoursButton.UseVisualStyleBackColor = true;
            this.AddHoursButton.Click += new System.EventHandler(this.AddHoursButton_Click);
            // 
            // ProjectsGridView
            // 
            this.ProjectsGridView.AllowUserToAddRows = false;
            this.ProjectsGridView.AllowUserToDeleteRows = false;
            this.ProjectsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProjectsGridView.Location = new System.Drawing.Point(75, 48);
            this.ProjectsGridView.Name = "ProjectsGridView";
            this.ProjectsGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProjectsGridView.RowHeadersWidth = 51;
            this.ProjectsGridView.Size = new System.Drawing.Size(429, 115);
            this.ProjectsGridView.TabIndex = 53;
            this.ProjectsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGridView_CellContentClick);
            // 
            // ProjectsLabel
            // 
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(260, 10);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(82, 25);
            this.ProjectsLabel.TabIndex = 52;
            this.ProjectsLabel.Text = "Projects";
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.White;
            this.LabelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelMiddleName.Location = new System.Drawing.Point(310, 176);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(46, 17);
            this.LabelMiddleName.TabIndex = 50;
            this.LabelMiddleName.Text = "Hours";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(77, 196);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.ReadOnly = true;
            this.ProjectNameTextBox.Size = new System.Drawing.Size(214, 30);
            this.ProjectNameTextBox.TabIndex = 49;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.White;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFirstName.Location = new System.Drawing.Point(74, 176);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(93, 17);
            this.LabelFirstName.TabIndex = 48;
            this.LabelFirstName.Text = "Project Name";
            // 
            // MaxHours
            // 
            this.MaxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHours.FormattingEnabled = true;
            this.MaxHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "7",
            "8"});
            this.MaxHours.Location = new System.Drawing.Point(313, 196);
            this.MaxHours.Name = "MaxHours";
            this.MaxHours.Size = new System.Drawing.Size(214, 28);
            this.MaxHours.TabIndex = 59;
            // 
            // AddWorkedTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.MaxHours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateOfWorkedHoursPicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddHoursButton);
            this.Controls.Add(this.ProjectsGridView);
            this.Controls.Add(this.ProjectsLabel);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.LabelFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddWorkedTimeForm";
            this.Text = "AddWorkedTimeForm";
            this.Load += new System.EventHandler(this.AddWorkedTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateOfWorkedHoursPicker;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddHoursButton;
        private System.Windows.Forms.DataGridView ProjectsGridView;
        private System.Windows.Forms.Label ProjectsLabel;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.ComboBox MaxHours;
    }
}