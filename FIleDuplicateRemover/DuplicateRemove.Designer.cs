namespace FIleDuplicateRemover
{
    partial class DuplicateRemove
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
            this.deleteProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dirTxtbox
            // 
            this.dirTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.deleteDuplicatesBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteDuplicatesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteDuplicatesBtn.Location = new System.Drawing.Point(210, 43);
            this.deleteDuplicatesBtn.Name = "deleteDuplicatesBtn";
            this.deleteDuplicatesBtn.Size = new System.Drawing.Size(144, 26);
            this.deleteDuplicatesBtn.TabIndex = 2;
            this.deleteDuplicatesBtn.Text = "Delete duplicates";
            this.deleteDuplicatesBtn.UseVisualStyleBackColor = true;
            this.deleteDuplicatesBtn.Click += new System.EventHandler(this.deleteDuplicatesBtn_Click);
            // 
            // deleteProgressBar
            // 
            this.deleteProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProgressBar.Location = new System.Drawing.Point(12, 40);
            this.deleteProgressBar.Minimum = 1;
            this.deleteProgressBar.Name = "deleteProgressBar";
            this.deleteProgressBar.Size = new System.Drawing.Size(585, 23);
            this.deleteProgressBar.Step = 1;
            this.deleteProgressBar.TabIndex = 3;
            this.deleteProgressBar.Value = 1;
            this.deleteProgressBar.Visible = false;
            // 
            // DuplicateRemove
            // 
            this.AcceptButton = this.deleteDuplicatesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 75);
            this.Controls.Add(this.deleteProgressBar);
            this.Controls.Add(this.deleteDuplicatesBtn);
            this.Controls.Add(this.changeDirBtn);
            this.Controls.Add(this.dirTxtbox);
            this.MinimumSize = new System.Drawing.Size(625, 114);
            this.Name = "DuplicateRemove";
            this.ShowIcon = false;
            this.Text = "FIlesDuplicateRemover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirTxtbox;
        private System.Windows.Forms.Button changeDirBtn;
        private System.Windows.Forms.Button deleteDuplicatesBtn;
        private System.Windows.Forms.ProgressBar deleteProgressBar;
    }
}

