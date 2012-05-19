namespace VisualBounds.Imaging.ColourRemover
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.picColour = new System.Windows.Forms.PictureBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).BeginInit();
            this.groupPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.btnSave);
            this.groupSettings.Controls.Add(this.txtHex);
            this.groupSettings.Controls.Add(this.picColour);
            this.groupSettings.Controls.Add(this.btnRevert);
            this.groupSettings.Controls.Add(this.btnRemove);
            this.groupSettings.Controls.Add(this.btnOpen);
            this.groupSettings.Controls.Add(this.txtOpen);
            this.groupSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSettings.Location = new System.Drawing.Point(0, 0);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(431, 74);
            this.groupSettings.TabIndex = 0;
            this.groupSettings.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(375, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(42, 44);
            this.txtHex.MaxLength = 6;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(61, 20);
            this.txtHex.TabIndex = 6;
            this.txtHex.Text = "FF00FF";
            this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            this.txtHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            // 
            // picColour
            // 
            this.picColour.BackColor = System.Drawing.Color.Magenta;
            this.picColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picColour.Location = new System.Drawing.Point(6, 38);
            this.picColour.Name = "picColour";
            this.picColour.Size = new System.Drawing.Size(30, 30);
            this.picColour.TabIndex = 5;
            this.picColour.TabStop = false;
            this.picColour.Click += new System.EventHandler(this.picColour_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.Enabled = false;
            this.btnRevert.Location = new System.Drawing.Point(253, 38);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(55, 30);
            this.btnRevert.TabIndex = 4;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(314, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(375, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(50, 20);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtOpen
            // 
            this.txtOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOpen.Location = new System.Drawing.Point(6, 12);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.ReadOnly = true;
            this.txtOpen.Size = new System.Drawing.Size(363, 20);
            this.txtOpen.TabIndex = 0;
            this.txtOpen.TextChanged += new System.EventHandler(this.txtOpen_TextChanged);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.picPreview);
            this.groupPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPreview.Location = new System.Drawing.Point(0, 74);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(431, 291);
            this.groupPreview.TabIndex = 1;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(3, 16);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(425, 272);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            this.picPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseDown);
            this.picPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseMove);
            this.picPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 365);
            this.Controls.Add(this.groupPreview);
            this.Controls.Add(this.groupSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Image Colour Remover";
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).EndInit();
            this.groupPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.PictureBox picColour;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnSave;
    }
}

