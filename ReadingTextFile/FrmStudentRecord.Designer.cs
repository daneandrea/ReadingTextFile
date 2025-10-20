namespace ReadingTextFile
{
    partial class FrmStudentRecord
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
            this.lblViewRecord = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lvStudentRecord = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblViewRecord
            // 
            this.lblViewRecord.AutoSize = true;
            this.lblViewRecord.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.lblViewRecord.Location = new System.Drawing.Point(33, 18);
            this.lblViewRecord.Name = "lblViewRecord";
            this.lblViewRecord.Size = new System.Drawing.Size(154, 30);
            this.lblViewRecord.TabIndex = 13;
            this.lblViewRecord.Text = "View Records";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.btnUpload.Location = new System.Drawing.Point(348, 159);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(85, 42);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.btnFind.Location = new System.Drawing.Point(348, 111);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 42);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.btnRegister.Location = new System.Drawing.Point(348, 63);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(85, 42);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lvStudentRecord
            // 
            this.lvStudentRecord.HideSelection = false;
            this.lvStudentRecord.Location = new System.Drawing.Point(26, 62);
            this.lvStudentRecord.Name = "lvStudentRecord";
            this.lvStudentRecord.Size = new System.Drawing.Size(300, 225);
            this.lvStudentRecord.TabIndex = 9;
            this.lvStudentRecord.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(458, 305);
            this.Controls.Add(this.lblViewRecord);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lvStudentRecord);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewRecord;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListView lvStudentRecord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}