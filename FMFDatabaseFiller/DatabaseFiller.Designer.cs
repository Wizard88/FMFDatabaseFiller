namespace FMFDatabaseFiller
{
    partial class DatabaseFiller
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cbRunAsTest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(55, 9);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(673, 40);
            this.tbPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(746, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 35);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 21);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 17);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "access files (*.accdb)|*.accdb|All files (*.*)|*.*";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.InitialDirectory = "c:\\\\";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(746, 92);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 35);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbRunAsTest
            // 
            this.cbRunAsTest.AutoSize = true;
            this.cbRunAsTest.Checked = true;
            this.cbRunAsTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRunAsTest.Location = new System.Drawing.Point(55, 92);
            this.cbRunAsTest.Name = "cbRunAsTest";
            this.cbRunAsTest.Size = new System.Drawing.Size(102, 21);
            this.cbRunAsTest.TabIndex = 4;
            this.cbRunAsTest.Text = "Run as test";
            this.cbRunAsTest.UseVisualStyleBackColor = true;
            // 
            // DatabaseFiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 139);
            this.Controls.Add(this.cbRunAsTest);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.MinimumSize = new System.Drawing.Size(851, 186);
            this.Name = "DatabaseFiller";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DatabaseFiller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.CheckBox cbRunAsTest;
    }
}

