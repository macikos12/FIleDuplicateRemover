namespace FIleDuplicateRemover
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
            this.dirTxtbox = new System.Windows.Forms.TextBox();
            this.changeDirBtn = new System.Windows.Forms.Button();
            this.deleteDuplicatesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirTxtbox
            // 
            this.dirTxtbox.Location = new System.Drawing.Point(115, 14);
            this.dirTxtbox.Name = "dirTxtbox";
            this.dirTxtbox.Size = new System.Drawing.Size(482, 20);
            this.dirTxtbox.TabIndex = 0;
            // 
            // changeDirBtn
            // 
            this.changeDirBtn.Location = new System.Drawing.Point(12, 12);
            this.changeDirBtn.Name = "changeDirBtn";
            this.changeDirBtn.Size = new System.Drawing.Size(97, 23);
            this.changeDirBtn.TabIndex = 1;
            this.changeDirBtn.Text = "Change Directory";
            this.changeDirBtn.UseVisualStyleBackColor = true;
            this.changeDirBtn.Click += new System.EventHandler(this.changeDirBtn_Click);
            // 
            // deleteDuplicatesBtn
            // 
            this.deleteDuplicatesBtn.Location = new System.Drawing.Point(255, 43);
            this.deleteDuplicatesBtn.Name = "deleteDuplicatesBtn";
            this.deleteDuplicatesBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteDuplicatesBtn.TabIndex = 2;
            this.deleteDuplicatesBtn.Text = "Delete";
            this.deleteDuplicatesBtn.UseVisualStyleBackColor = true;
            this.deleteDuplicatesBtn.Click += new System.EventHandler(this.deleteDuplicatesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 78);
            this.Controls.Add(this.deleteDuplicatesBtn);
            this.Controls.Add(this.changeDirBtn);
            this.Controls.Add(this.dirTxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirTxtbox;
        private System.Windows.Forms.Button changeDirBtn;
        private System.Windows.Forms.Button deleteDuplicatesBtn;
    }
}

