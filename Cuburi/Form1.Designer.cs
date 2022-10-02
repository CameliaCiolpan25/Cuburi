namespace Cuburi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.eticheta = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dimensiune = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inSpate = new System.Windows.Forms.ToolStripButton();
            this.inFata = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(0, 43);
            this.p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(1487, 682);
            this.p.TabIndex = 4;
            this.p.TabStop = false;
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Paint);
            this.p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
            this.p.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_MouseMove);
            this.p.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.eticheta,
            this.toolStripLabel1,
            this.dimensiune,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.inSpate,
            this.inFata});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1507, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(89, 36);
            this.toolStripLabel2.Text = "Etichetă";
            // 
            // eticheta
            // 
            this.eticheta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eticheta.Name = "eticheta";
            this.eticheta.Size = new System.Drawing.Size(132, 39);
            this.eticheta.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 36);
            this.toolStripLabel1.Text = "Dimensiune";
            // 
            // dimensiune
            // 
            this.dimensiune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dimensiune.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.dimensiune.Name = "dimensiune";
            this.dimensiune.Size = new System.Drawing.Size(99, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "adaugă";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // inSpate
            // 
            this.inSpate.Checked = true;
            this.inSpate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inSpate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inSpate.DoubleClickEnabled = true;
            this.inSpate.Image = ((System.Drawing.Image)(resources.GetObject("inSpate.Image")));
            this.inSpate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inSpate.Name = "inSpate";
            this.inSpate.Size = new System.Drawing.Size(36, 36);
            this.inSpate.Text = "toolStripButton2";
            this.inSpate.ToolTipText = "trimite în spate";
            this.inSpate.Click += new System.EventHandler(this.inSpate_Click);
            // 
            // inFata
            // 
            this.inFata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inFata.Image = ((System.Drawing.Image)(resources.GetObject("inFata.Image")));
            this.inFata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inFata.Name = "inFata";
            this.inFata.Size = new System.Drawing.Size(36, 36);
            this.inFata.Text = "toolStripButton3";
            this.inFata.ToolTipText = "adu în față";
            this.inFata.Click += new System.EventHandler(this.inFata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 743);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cuburi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox dimensiune;
        private System.Windows.Forms.ToolStripButton inSpate;
        private System.Windows.Forms.ToolStripButton inFata;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox eticheta;
    }
}

