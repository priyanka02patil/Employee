namespace Employee
{
    partial class Form1
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
            this.labelEmpid = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmpSal = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmpid
            // 
            this.labelEmpid.AutoSize = true;
            this.labelEmpid.Location = new System.Drawing.Point(113, 53);
            this.labelEmpid.Name = "labelEmpid";
            this.labelEmpid.Size = new System.Drawing.Size(143, 20);
            this.labelEmpid.TabIndex = 0;
            this.labelEmpid.Text = "Enter Employee ID";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(113, 119);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(168, 20);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Enter Employee Name";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(113, 196);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(96, 20);
            this.labelSalary.TabIndex = 2;
            this.labelSalary.Text = "Enter Salary";
            // 
            // textEmpId
            // 
            this.textEmpId.Location = new System.Drawing.Point(353, 47);
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(183, 26);
            this.textEmpId.TabIndex = 3;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(353, 119);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(183, 26);
            this.textEmpName.TabIndex = 4;
            // 
            // textEmpSal
            // 
            this.textEmpSal.Location = new System.Drawing.Point(353, 190);
            this.textEmpSal.Name = "textEmpSal";
            this.textEmpSal.Size = new System.Drawing.Size(183, 26);
            this.textEmpSal.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(117, 302);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 47);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(353, 302);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 47);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(656, 50);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(140, 71);
            this.btnfolder.TabIndex = 8;
            this.btnfolder.Text = "Create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(823, 52);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(124, 69);
            this.btnfile.TabIndex = 9;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textEmpSal);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpid;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmpSal;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnfile;
    }
}

