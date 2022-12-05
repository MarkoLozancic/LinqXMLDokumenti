namespace LinqXMLDokumenti
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(46, 22);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(185, 75);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(46, 135);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(185, 75);
            this.btnUcitaj.TabIndex = 1;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(46, 258);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(185, 75);
            this.btnFiltriraj.TabIndex = 2;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 451);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}

