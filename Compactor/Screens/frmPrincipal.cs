using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Compactor.Screens
{
    public partial class frmPrincipal : Form
    {
        FileInfo[] archive;
        string fileName;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchArchivesPath();
        }
        private void SearchArchivesPath()
        { 
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            txtPath.Text = folderBrowser.SelectedPath;

            ltbArchives.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
            archive = dir.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach (FileInfo item in archive)
            {
               // Retira o diretório informado inicialmente
               fileName = item.FullName.Replace(dir.FullName, "").Remove(0, 1);
               ltbArchives.Items.Add(fileName);
               lblArchivesQtt.Text = "Total: " + ltbArchives.Items.Count;
            }
            if (ltbArchives.Items.Count > 0)
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            ltbArchives.DataSource = null;
            txtPath.Clear();
            chkDirectory.Checked = false;
            chkEraseOriginals.Checked = false;
            chkUnique.Checked = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Preparando Para Compactar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MessageBox.Show("Deseja realmente compactar os arquivos deste diretório?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Processing();
                    Cursor.Current = Cursors.WaitCursor;
                    
                    if(chkUnique.Checked)
                    using (ZipArchive zip = ZipFile.Open($"{txtPath.Text}.zip", ZipArchiveMode.Create))
                    {
                        foreach (FileInfo files in archive)
                        {
                            zip.CreateEntry(files.Name);
                        }
                    }
                    else
                        foreach (FileInfo files in archive)
                        {
                            using (ZipArchive zip = ZipFile.Open($"{files.Name}.zip", ZipArchiveMode.Create))
                            {
                                zip.CreateEntry(files.Name);
                            }
                        }
                }
            }
            EndProcess();
        }
        private void Processing() 
        {
            Cursor.Current = Cursors.WaitCursor;
            lblProcessing.Visible = true;
            btnStart.Enabled = false;
            this.Enabled = false;
        }
        private void EndProcess()
        {
            Cursor.Current = Cursors.Default;
            lblProcessing.Visible = false;
            btnStart.Enabled = false;
            this.Enabled = true;
        }
    }
}
