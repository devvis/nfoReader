namespace nfoReader
{
    partial class mainWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWnd));
            this.nfoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nfoBox
            // 
            this.nfoBox.AllowDrop = true;
            this.nfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nfoBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.nfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nfoBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nfoBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfoBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nfoBox.Location = new System.Drawing.Point(1, 0);
            this.nfoBox.Name = "nfoBox";
            this.nfoBox.Size = new System.Drawing.Size(572, 774);
            this.nfoBox.TabIndex = 0;
            this.nfoBox.Text = "";
            this.nfoBox.WordWrap = false;
            this.nfoBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.nfoBox_DragDrop);
            this.nfoBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.nfoBox_DragEnter);
            // 
            // mainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(574, 775);
            this.Controls.Add(this.nfoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 2000);
            this.MinimumSize = new System.Drawing.Size(590, 38);
            this.Name = "mainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dvz nfo viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox nfoBox;
    }
}

