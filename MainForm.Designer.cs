namespace StudentGradeManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAddStudent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnHighLow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.ListBox lstStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAddStudent = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.grpAddStudent.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(180, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Grade Management System";
            // 
            // grpAddStudent
            // 
            this.grpAddStudent.Controls.Add(this.btnAdd);
            this.grpAddStudent.Controls.Add(this.txtGrade);
            this.grpAddStudent.Controls.Add(this.txtName);
            this.grpAddStudent.Controls.Add(this.lblGrade);
            this.grpAddStudent.Controls.Add(this.lblName);
            this.grpAddStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.grpAddStudent.Location = new System.Drawing.Point(20, 60);
            this.grpAddStudent.Name = "grpAddStudent";
            this.grpAddStudent.Size = new System.Drawing.Size(350, 140);
            this.grpAddStudent.TabIndex = 1;
            this.grpAddStudent.TabStop = false;
            this.grpAddStudent.Text = "Add New Student";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(120, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGrade.Location = new System.Drawing.Point(120, 65);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(200, 23);
            this.txtGrade.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrade.ForeColor = System.Drawing.Color.Black;
            this.lblGrade.Location = new System.Drawing.Point(20, 68);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(76, 15);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade (0-100):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(20, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name:";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnClear);
            this.grpOperations.Controls.Add(this.btnHighLow);
            this.grpOperations.Controls.Add(this.btnAverage);
            this.grpOperations.Controls.Add(this.btnDisplay);
            this.grpOperations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.grpOperations.Location = new System.Drawing.Point(390, 60);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(380, 140);
            this.grpOperations.TabIndex = 2;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operations";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(195, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All Students";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHighLow
            // 
            this.btnHighLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnHighLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHighLow.ForeColor = System.Drawing.Color.White;
            this.btnHighLow.Location = new System.Drawing.Point(195, 35);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(165, 35);
            this.btnHighLow.TabIndex = 2;
            this.btnHighLow.Text = "Highest && Lowest";
            this.btnHighLow.UseVisualStyleBackColor = false;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAverage.ForeColor = System.Drawing.Color.White;
            this.btnAverage.Location = new System.Drawing.Point(20, 85);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(165, 35);
            this.btnAverage.TabIndex = 1;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(20, 35);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(165, 35);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display All Students";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.grpSearch.Location = new System.Drawing.Point(20, 215);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(750, 80);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Student";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(620, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(140, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(20, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter Student Name:";
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.lstStudents);
            this.grpDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.grpDisplay.Location = new System.Drawing.Point(20, 310);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(750, 260);
            this.grpDisplay.TabIndex = 4;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Student Records";
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 14;
            this.lstStudents.Location = new System.Drawing.Point(15, 25);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(720, 214);
            this.lstStudents.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 590);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpAddStudent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Management System";
            this.grpAddStudent.ResumeLayout(false);
            this.grpAddStudent.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
