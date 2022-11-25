
namespace TimeTable.Projects
{
    partial class AddProjectForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxHours = new System.Windows.Forms.ComboBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(473, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "End date";
            // 
            // EndDate
            // 
            this.EndDate.CustomFormat = "yyyy-MM-dd";
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(477, 401);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(343, 30);
            this.EndDate.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(67, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Maximum working hours";
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
            this.MaxHours.Location = new System.Drawing.Point(71, 338);
            this.MaxHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxHours.Name = "MaxHours";
            this.MaxHours.Size = new System.Drawing.Size(300, 34);
            this.MaxHours.TabIndex = 21;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(71, 213);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTextBox.MinimumSize = new System.Drawing.Size(749, 83);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(749, 83);
            this.DescriptionTextBox.TabIndex = 16;
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.White;
            this.LabelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelMiddleName.Location = new System.Drawing.Point(67, 188);
            this.LabelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(95, 20);
            this.LabelMiddleName.TabIndex = 15;
            this.LabelMiddleName.Text = "Description";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(71, 138);
            this.ProjectNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(749, 36);
            this.ProjectNameTextBox.TabIndex = 14;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.White;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFirstName.Location = new System.Drawing.Point(67, 113);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(53, 20);
            this.LabelFirstName.TabIndex = 13;
            this.LabelFirstName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(67, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Start date";
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy-MM-dd";
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(71, 401);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(344, 30);
            this.StartDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(297, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 42);
            this.label2.TabIndex = 27;
            this.label2.Text = "Create Project";
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjectButton.Location = new System.Drawing.Point(176, 506);
            this.CreateProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(524, 48);
            this.CreateProjectButton.TabIndex = 28;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.UseVisualStyleBackColor = false;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 761);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxHours);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.LabelFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.Load += new System.EventHandler(this.AddProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MaxHours;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateProjectButton;
    }
}