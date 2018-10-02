namespace ImageProcessing
{
    partial class frmMain
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
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibFiltered = new Emgu.CV.UI.ImageBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tlpInner = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblChosenFile = new System.Windows.Forms.Label();
            this.tlpOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFiltered)).BeginInit();
            this.tlpInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOuter.Controls.Add(this.ibOriginal, 0, 1);
            this.tlpOuter.Controls.Add(this.ibFiltered, 1, 1);
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 0);
            this.tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpOuter.Location = new System.Drawing.Point(0, 0);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOuter.Size = new System.Drawing.Size(924, 567);
            this.tlpOuter.TabIndex = 0;
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Enabled = false;
            this.ibOriginal.Location = new System.Drawing.Point(3, 50);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(456, 514);
            this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibFiltered
            // 
            this.ibFiltered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibFiltered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibFiltered.Enabled = false;
            this.ibFiltered.Location = new System.Drawing.Point(465, 50);
            this.ibFiltered.Name = "ibFiltered";
            this.ibFiltered.Size = new System.Drawing.Size(456, 514);
            this.ibFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFiltered.TabIndex = 2;
            this.ibFiltered.TabStop = false;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tlpInner
            // 
            this.tlpInner.AutoSize = true;
            this.tlpInner.ColumnCount = 2;
            this.tlpOuter.SetColumnSpan(this.tlpInner, 2);
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.Controls.Add(this.btnOpenFile, 0, 0);
            this.tlpInner.Controls.Add(this.lblChosenFile, 1, 0);
            this.tlpInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInner.Location = new System.Drawing.Point(3, 3);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 1;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInner.Size = new System.Drawing.Size(918, 41);
            this.tlpInner.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(107, 35);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblChosenFile
            // 
            this.lblChosenFile.AutoSize = true;
            this.lblChosenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChosenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenFile.Location = new System.Drawing.Point(116, 0);
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Size = new System.Drawing.Size(799, 41);
            this.lblChosenFile.TabIndex = 1;
            this.lblChosenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.tlpOuter);
            this.Name = "frmMain";
            this.Text = "ImageProcessing";
            this.tlpOuter.ResumeLayout(false);
            this.tlpOuter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFiltered)).EndInit();
            this.tlpInner.ResumeLayout(false);
            this.tlpInner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibFiltered;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblChosenFile;
    }
}

