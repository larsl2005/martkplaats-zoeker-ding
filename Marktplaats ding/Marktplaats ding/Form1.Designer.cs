namespace Marktplaats_ding
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaxPrijs = new System.Windows.Forms.NumericUpDown();
            this.ZoekTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Afstand = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AntiekEnKunst = new System.Windows.Forms.CheckBox();
            this.AudioTvEnFoto = new System.Windows.Forms.CheckBox();
            this.Filters = new System.Windows.Forms.ComboBox();
            this.Filters2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Afstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Max prijs in euro\'s";
            // 
            // MaxPrijs
            // 
            this.MaxPrijs.Location = new System.Drawing.Point(113, 102);
            this.MaxPrijs.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaxPrijs.Name = "MaxPrijs";
            this.MaxPrijs.Size = new System.Drawing.Size(120, 20);
            this.MaxPrijs.TabIndex = 2;
            this.MaxPrijs.ValueChanged += new System.EventHandler(this.MaxPrijs_ValueChanged);
            // 
            // ZoekTerm
            // 
            this.ZoekTerm.Location = new System.Drawing.Point(96, 20);
            this.ZoekTerm.Name = "ZoekTerm";
            this.ZoekTerm.Size = new System.Drawing.Size(137, 20);
            this.ZoekTerm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoek term:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open marktplaats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Afstand
            // 
            this.Afstand.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Afstand.Location = new System.Drawing.Point(113, 129);
            this.Afstand.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.Afstand.Name = "Afstand";
            this.Afstand.Size = new System.Drawing.Size(120, 20);
            this.Afstand.TabIndex = 8;
            this.Afstand.ValueChanged += new System.EventHandler(this.Afstand_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max afstand (in km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*als Max afstand 0 is, is het alle aftanden";
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(113, 76);
            this.MinPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(120, 20);
            this.MinPrice.TabIndex = 13;
            this.MinPrice.ValueChanged += new System.EventHandler(this.MinPrice_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min prijs in euro\'s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(INDEV) V0.4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Filters: uit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AntiekEnKunst
            // 
            this.AntiekEnKunst.AutoSize = true;
            this.AntiekEnKunst.Location = new System.Drawing.Point(254, 109);
            this.AntiekEnKunst.Name = "AntiekEnKunst";
            this.AntiekEnKunst.Size = new System.Drawing.Size(100, 17);
            this.AntiekEnKunst.TabIndex = 16;
            this.AntiekEnKunst.Text = "Antiek en kunst";
            this.AntiekEnKunst.UseVisualStyleBackColor = true;
            // 
            // AudioTvEnFoto
            // 
            this.AudioTvEnFoto.AutoSize = true;
            this.AudioTvEnFoto.Location = new System.Drawing.Point(254, 132);
            this.AudioTvEnFoto.Name = "AudioTvEnFoto";
            this.AudioTvEnFoto.Size = new System.Drawing.Size(104, 17);
            this.AudioTvEnFoto.TabIndex = 17;
            this.AudioTvEnFoto.Text = "Audio, tv en foto";
            this.AudioTvEnFoto.UseVisualStyleBackColor = true;
            // 
            // Filters
            // 
            this.Filters.AllowDrop = true;
            this.Filters.FormattingEnabled = true;
            this.Filters.Location = new System.Drawing.Point(254, 20);
            this.Filters.MaxLength = 8;
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(121, 21);
            this.Filters.TabIndex = 18;
            this.Filters.Text = "{FILTERS}";
            this.Filters.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // Filters2
            // 
            this.Filters2.AllowDrop = true;
            this.Filters2.FormattingEnabled = true;
            this.Filters2.Location = new System.Drawing.Point(381, 20);
            this.Filters2.MaxLength = 8;
            this.Filters2.Name = "Filters2";
            this.Filters2.Size = new System.Drawing.Size(121, 21);
            this.Filters2.TabIndex = 19;
            this.Filters2.Text = "{FILTERS}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 263);
            this.Controls.Add(this.Filters2);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.AudioTvEnFoto);
            this.Controls.Add(this.AntiekEnKunst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Afstand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZoekTerm);
            this.Controls.Add(this.MaxPrijs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Afstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaxPrijs;
        private System.Windows.Forms.TextBox ZoekTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Afstand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MinPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox AntiekEnKunst;
        private System.Windows.Forms.CheckBox AudioTvEnFoto;
        private System.Windows.Forms.ComboBox Filters;
        private System.Windows.Forms.ComboBox Filters2;
    }
}

