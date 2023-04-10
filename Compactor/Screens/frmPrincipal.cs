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
        #region ..:: Variables ::..

        FileInfo[] archive;
        string fileName;

        #endregion

        #region ..:: Constructor ::..
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchArchivesPath();
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            // Cleaning all fields

            ltbFiles.Items.Clear();
            txtPath.Clear();
            chkEraseOriginals.Checked = false;
            chkUnique.Checked = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Verifying path   
            if (txtPath.Text.Length > 0)
                return;

            if (MessageBox.Show("Preparando Para Compactar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MessageBox.Show("Deseja realmente compactar os arquivos deste diretório?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    FieldsActivation(labelProcessing: true, startButton: false, formEnable: false);

                    if (chkUnique.Checked)
                    {
                        // Taking folder path to create just one archive, then archives are added on zip file 
                        using (ZipArchive zip = ZipFile.Open($"{txtPath.Text}.zip", ZipArchiveMode.Create))
                        {
                            foreach (FileInfo files in archive)
                            {
                                zip.CreateEntry(files.Name);

                                // Deleting original files
                                if (chkEraseOriginals.Checked)
                                    File.Delete(files.FullName);
                            }
                        }
                    }
                    else
                    {
                        foreach (FileInfo files in archive)
                        {
                            // Generating zip file to all files 
                            using (ZipArchive zip = ZipFile.Open($"{files.DirectoryName}\\{files.Name.Remove(files.Name.Length - 4)}.zip", ZipArchiveMode.Create))
                            {
                                zip.CreateEntry(files.Name);
                            }
                            // Deleting original files
                            if (chkEraseOriginals.Checked)
                                File.Delete(files.FullName);
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            FieldsActivation(labelProcessing: true, startButton: false, formEnable: false);
        }
        #endregion

        #region ..:: General Methods ::..
        private void SearchArchivesPath()
        { 
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            txtPath.Text = folderBrowser.SelectedPath;

            ltbFiles.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
            archive = dir.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach (FileInfo item in archive)
            {
               // Show File name
               fileName = item.FullName.Replace(dir.FullName, "").Remove(0, 1);
               ltbFiles.Items.Add(fileName);
               lblFilesQtt.Text = "Total: " + ltbFiles.Items.Count;
            }
            if (ltbFiles.Items.Count > 0)
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }  
        // Enable/Disable Fields
        private void FieldsActivation(bool labelProcessing, bool startButton, bool formEnable) 
        {
            lblProcessing.Visible = true;
            btnStart.Enabled = false;
            this.Enabled = false;
        }

        #endregion
    }
}
