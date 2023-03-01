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
using System.Threading;

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
            if (dirTxtbox.Text == "")
            {
                return;
            }
            /*I wanted to make a label tak communicates to user what was happening at the moment, 
              but label text was changing after all loops when it wasn't needed. 
              Can soeone tell me why?*/
            deleteDuplicatesBtn.Visible = false;
            deleteProgressBar.Visible = true;
            string[] files = Directory.GetFiles(dirTxtbox.Text);
            string[] hashes = new string[files.Length];
            deleteProgressBar.Maximum = files.Length;
            for (int i  = 0; i < files.Length; i++)
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(files[i]))
                    {
                        hashes[i] = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                        deleteProgressBar.PerformStep();
                    }
                }
            }
            deleteProgressBar.Value = 1;
            int[,] foundDuplicates = new int[files.Length, 2];
            int counter = 0;
            for(int i = 0; i < hashes.Length; i++)
            {
                for(int j = 0; j < hashes.Length; j++)
                {
                    if (i != j && hashes[i] == hashes[j])
                    {
                        foundDuplicates[counter, 0] = i;
                        foundDuplicates[counter, 1] = j;
                        counter++;
                    }
                    deleteProgressBar.PerformStep();
                }
            }

            deleteDuplicatesBtn.Visible = true;
            deleteProgressBar.Visible = false;
        }
    }
}
