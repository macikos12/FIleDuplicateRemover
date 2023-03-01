using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;

namespace FIleDuplicateRemover
{
    public partial class DuplicateRemove : Form
    {
        public DuplicateRemove()
        {
            InitializeComponent();
        }

        private void changeDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dirTxtbox.Text = dialog.SelectedPath;
            }
        }

        private void deleteDuplicatesBtn_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(dirTxtbox.Text);
            string[] hashes = new string[files.Length];
            for(int i  = 0; i < files.Length; i++)
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(files[i]))
                    {
                        hashes[i] = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
        }
    }
}
