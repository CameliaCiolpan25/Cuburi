namespace WordSearchGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCuvinte = new System.Windows.Forms.TextBox();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.ListaCuvinte = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.Gata = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MeniuTipNivel = new System.Windows.Forms.ComboBox();
            this.SelecteazaInaltimea = new System.Windows.Forms.NumericUpDown();
            this.SelecteazaLatimea = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelecteazaInaltimea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecteazaLatimea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a word to add to the puzzle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Words:";
            // 
            // totalCuvinte
            // 
            this.totalCuvinte.Location = new System.Drawing.Point(107, 142);
            this.totalCuvinte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalCuvinte.Name = "totalCuvinte";
            this.totalCuvinte.ReadOnly = true;
            this.totalCuvinte.Size = new System.Drawing.Size(40, 22);
            this.totalCuvinte.TabIndex = 3;
            this.totalCuvinte.TabStop = false;
            // 
            // wordInput
            // 
            this.wordInput.Location = new System.Drawing.Point(23, 107);
            this.wordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordInput.Name = "wordInput";
            this.wordInput.Size = new System.Drawing.Size(216, 22);
            this.wordInput.TabIndex = 2;
            this.wordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordInput_KeyPress);
            // 
            // ListaCuvinte
            // 
            this.ListaCuvinte.ColumnWidth = 100;
            this.ListaCuvinte.FormattingEnabled = true;
            this.ListaCuvinte.ItemHeight = 16;
            this.ListaCuvinte.Location = new System.Drawing.Point(19, 166);
            this.ListaCuvinte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaCuvinte.Name = "ListaCuvinte";
            this.ListaCuvinte.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListaCuvinte.Size = new System.Drawing.Size(220, 244);
            this.ListaCuvinte.TabIndex = 5;
            this.ListaCuvinte.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(157, 139);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 28);
            this.addButton.TabIndex = 6;
            this.addButton.TabStop = false;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Gata
            // 
            this.Gata.Location = new System.Drawing.Point(141, 432);
            this.Gata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gata.Name = "Gata";
            this.Gata.Size = new System.Drawing.Size(100, 28);
            this.Gata.TabIndex = 7;
            this.Gata.Text = "Done";
            this.Gata.UseVisualStyleBackColor = true;
            this.Gata.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(20, 12);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(217, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(16, 432);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(100, 28);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // Titlu
            // 
            this.Titlu.Location = new System.Drawing.Point(55, 47);
            this.Titlu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(181, 22);
            this.Titlu.TabIndex = 1;
            this.Titlu.TextChanged += new System.EventHandler(this.puzzleTitle_TextChanged);
            this.Titlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puzzleTitle_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title:";
            // 
            // MeniuTipNivel
            // 
            this.MeniuTipNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MeniuTipNivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MeniuTipNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeniuTipNivel.FormattingEnabled = true;
            this.MeniuTipNivel.Items.AddRange(new object[] {
            "Kiddie",
            "Easy",
            "Normal"});
            this.MeniuTipNivel.Location = new System.Drawing.Point(49, 474);
            this.MeniuTipNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MeniuTipNivel.MaxDropDownItems = 3;
            this.MeniuTipNivel.Name = "MeniuTipNivel";
            this.MeniuTipNivel.Size = new System.Drawing.Size(160, 24);
            this.MeniuTipNivel.TabIndex = 12;
            // 
            // heightSelect
            // 
            this.SelecteazaInaltimea.Location = new System.Drawing.Point(80, 512);
            this.SelecteazaInaltimea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelecteazaInaltimea.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SelecteazaInaltimea.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SelecteazaInaltimea.Name = "SelecteazaInaltimea";
            this.SelecteazaInaltimea.Size = new System.Drawing.Size(44, 22);
            this.SelecteazaInaltimea.TabIndex = 13;
            this.SelecteazaInaltimea.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SelecteazaInaltimea.ValueChanged += new System.EventHandler(this.heightSelect_ValueChanged);
            // 
            // SelecteazaLatimea
            // 
            this.SelecteazaLatimea.Location = new System.Drawing.Point(188, 512);
            this.SelecteazaLatimea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelecteazaLatimea.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SelecteazaLatimea.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SelecteazaLatimea.Name = "SelecteazaLatimea";
            this.SelecteazaLatimea.Size = new System.Drawing.Size(44, 22);
            this.SelecteazaLatimea.TabIndex = 14;
            this.SelecteazaLatimea.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SelecteazaLatimea.ValueChanged += new System.EventHandler(this.widthSelect_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 516);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 516);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelecteazaLatimea);
            this.Controls.Add(this.SelecteazaInaltimea);
            this.Controls.Add(this.MeniuTipNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.Gata);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ListaCuvinte);
            this.Controls.Add(this.wordInput);
            this.Controls.Add(this.totalCuvinte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Enter Words";
            ((System.ComponentModel.ISupportInitialize)(this.SelecteazaInaltimea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecteazaLatimea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalCuvinte;
        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.ListBox ListaCuvinte;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button Gata;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox Titlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MeniuTipNivel;
        private System.Windows.Forms.NumericUpDown SelecteazaInaltimea;
        private System.Windows.Forms.NumericUpDown SelecteazaLatimea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

