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
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Afstand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Max prijs in euro\'s";
            // 
            // MaxPrijs
            // 
            this.MaxPrijs.Location = new System.Drawing.Point(112, 58);
            this.MaxPrijs.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaxPrijs.Name = "MaxPrijs";
            this.MaxPrijs.Size = new System.Drawing.Size(120, 20);
            this.MaxPrijs.TabIndex = 2;
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
            this.button1.Location = new System.Drawing.Point(12, 134);
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
            5,
            0,
            0,
            0});
            this.Afstand.Location = new System.Drawing.Point(112, 85);
            this.Afstand.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Afstand.Name = "Afstand";
            this.Afstand.Size = new System.Drawing.Size(120, 20);
            this.Afstand.TabIndex = 8;
            this.Afstand.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            //this.Afstand.ValueChanged += new System.EventHandler(this.Afstand_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max afstand (in km)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 175);
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
    }
}

