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
            this.ltbArchives = new System.Windows.Forms.ListBox();
            this.chkUnique = new System.Windows.Forms.CheckBox();
            this.chkDirectory = new System.Windows.Forms.CheckBox();
            this.chkEraseOriginals = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(751, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 33);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(280, 74);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(465, 23);
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
            // ltbArchives
            // 
            this.ltbArchives.FormattingEnabled = true;
            this.ltbArchives.Location = new System.Drawing.Point(32, 107);
            this.ltbArchives.Name = "ltbArchives";
            this.ltbArchives.Size = new System.Drawing.Size(757, 121);
            this.ltbArchives.TabIndex = 10;
            // 
            // chkUnique
            // 
            this.chkUnique.AutoSize = true;
            this.chkUnique.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnique.ForeColor = System.Drawing.Color.White;
            this.chkUnique.Location = new System.Drawing.Point(32, 244);
            this.chkUnique.Name = "chkUnique";
            this.chkUnique.Size = new System.Drawing.Size(102, 19);
            this.chkUnique.TabIndex = 11;
            this.chkUnique.Text = "Arquivo Único";
            this.chkUnique.UseVisualStyleBackColor = true;
            // 
            // chkDirectory
            // 
            this.chkDirectory.AutoSize = true;
            this.chkDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDirectory.ForeColor = System.Drawing.Color.White;
            this.chkDirectory.Location = new System.Drawing.Point(32, 269);
            this.chkDirectory.Name = "chkDirectory";
            this.chkDirectory.Size = new System.Drawing.Size(105, 19);
            this.chkDirectory.TabIndex = 12;
            this.chkDirectory.Text = "Criar subpastas";
            this.chkDirectory.UseVisualStyleBackColor = true;
            // 
            // chkEraseOriginals
            // 
            this.chkEraseOriginals.AutoSize = true;
            this.chkEraseOriginals.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEraseOriginals.ForeColor = System.Drawing.Color.White;
            this.chkEraseOriginals.Location = new System.Drawing.Point(32, 294);
            this.chkEraseOriginals.Name = "chkEraseOriginals";
            this.chkEraseOriginals.Size = new System.Drawing.Size(160, 19);
            this.chkEraseOriginals.TabIndex = 13;
            this.chkEraseOriginals.Text = "Apagar arquivos originais";
            this.chkEraseOriginals.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(591, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 33);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Processar";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(591, 280);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(197, 33);
            this.btnErase.TabIndex = 15;
            this.btnErase.Text = "Limpar";
            this.btnErase.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(743, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 46);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkEraseOriginals);
            this.Controls.Add(this.chkDirectory);
            this.Controls.Add(this.chkUnique);
            this.Controls.Add(this.ltbArchives);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblTitlePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
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
        private System.Windows.Forms.ListBox ltbArchives;
        private System.Windows.Forms.CheckBox chkUnique;
        private System.Windows.Forms.CheckBox chkDirectory;
        private System.Windows.Forms.CheckBox chkEraseOriginals;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit;
    }
}