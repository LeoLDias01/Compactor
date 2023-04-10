namespace Compactor.Screens
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblTitlePath = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.ltbFiles = new System.Windows.Forms.ListBox();
            this.chkUnique = new System.Windows.Forms.CheckBox();
            this.chkEraseOriginals = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFilesQtt = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(700, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 33);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(280, 74);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(414, 23);
            this.txtPath.TabIndex = 6;
            // 
            // lblTitlePath
            // 
            this.lblTitlePath.AutoSize = true;
            this.lblTitlePath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePath.ForeColor = System.Drawing.Color.White;
            this.lblTitlePath.Location = new System.Drawing.Point(28, 74);
            this.lblTitlePath.Name = "lblTitlePath";
            this.lblTitlePath.Size = new System.Drawing.Size(246, 21);
            this.lblTitlePath.TabIndex = 5;
            this.lblTitlePath.Text = "Localize a pasta com os arquivos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 65);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Compactor Pro";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(333, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(82, 56);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 9;
            this.pcbLogo.TabStop = false;
            // 
            // ltbFiles
            // 
            this.ltbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbFiles.FormattingEnabled = true;
            this.ltbFiles.Location = new System.Drawing.Point(32, 107);
            this.ltbFiles.Name = "ltbFiles";
            this.ltbFiles.Size = new System.Drawing.Size(706, 147);
            this.ltbFiles.TabIndex = 10;
            // 
            // chkUnique
            // 
            this.chkUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUnique.AutoSize = true;
            this.chkUnique.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnique.ForeColor = System.Drawing.Color.White;
            this.chkUnique.Location = new System.Drawing.Point(32, 291);
            this.chkUnique.Name = "chkUnique";
            this.chkUnique.Size = new System.Drawing.Size(102, 19);
            this.chkUnique.TabIndex = 11;
            this.chkUnique.Text = "Arquivo Único";
            this.chkUnique.UseVisualStyleBackColor = true;
            // 
            // chkEraseOriginals
            // 
            this.chkEraseOriginals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEraseOriginals.AutoSize = true;
            this.chkEraseOriginals.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEraseOriginals.ForeColor = System.Drawing.Color.White;
            this.chkEraseOriginals.Location = new System.Drawing.Point(32, 316);
            this.chkEraseOriginals.Name = "chkEraseOriginals";
            this.chkEraseOriginals.Size = new System.Drawing.Size(160, 19);
            this.chkEraseOriginals.TabIndex = 13;
            this.chkEraseOriginals.Text = "Apagar arquivos originais";
            this.chkEraseOriginals.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(541, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 33);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Processar";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnErase
            // 
            this.btnErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErase.BackColor = System.Drawing.Color.White;
            this.btnErase.FlatAppearance.BorderSize = 2;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(540, 316);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(197, 33);
            this.btnErase.TabIndex = 15;
            this.btnErase.Text = "Limpar";
            this.btnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(692, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 46);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFilesQtt
            // 
            this.lblFilesQtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilesQtt.AutoSize = true;
            this.lblFilesQtt.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesQtt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesQtt.ForeColor = System.Drawing.Color.White;
            this.lblFilesQtt.Location = new System.Drawing.Point(28, 257);
            this.lblFilesQtt.Name = "lblFilesQtt";
            this.lblFilesQtt.Size = new System.Drawing.Size(62, 21);
            this.lblFilesQtt.TabIndex = 17;
            this.lblFilesQtt.Text = "Total: 0";
            // 
            // lblProcessing
            // 
            this.lblProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblProcessing.ForeColor = System.Drawing.Color.White;
            this.lblProcessing.Location = new System.Drawing.Point(474, 25);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(152, 30);
            this.lblProcessing.TabIndex = 18;
            this.lblProcessing.Text = "Processando...";
            this.lblProcessing.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Created by: Leonardo Leal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(749, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.lblFilesQtt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkEraseOriginals);
            this.Controls.Add(this.chkUnique);
            this.Controls.Add(this.ltbFiles);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblTitlePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Compactor Pro ";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblTitlePath;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.ListBox ltbFiles;
        private System.Windows.Forms.CheckBox chkUnique;
        private System.Windows.Forms.CheckBox chkEraseOriginals;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFilesQtt;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label label1;
    }
}