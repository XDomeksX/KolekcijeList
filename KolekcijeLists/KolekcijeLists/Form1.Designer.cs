namespace Kolekcija_List
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
            this.LBLime = new System.Windows.Forms.Label();
            this.LBLrazred = new System.Windows.Forms.Label();
            this.LBLprezime = new System.Windows.Forms.Label();
            this.BTNunos = new System.Windows.Forms.Button();
            this.BTNobrada = new System.Windows.Forms.Button();
            this.BTNpregled = new System.Windows.Forms.Button();
            this.RTBispis = new System.Windows.Forms.RichTextBox();
            this.TXTime = new System.Windows.Forms.TextBox();
            this.TXTprezime = new System.Windows.Forms.TextBox();
            this.CMBrazred = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBLime
            // 
            this.LBLime.AutoSize = true;
            this.LBLime.Location = new System.Drawing.Point(35, 9);
            this.LBLime.Name = "LBLime";
            this.LBLime.Size = new System.Drawing.Size(27, 13);
            this.LBLime.TabIndex = 0;
            this.LBLime.Text = "Ime:";
            // 
            // LBLrazred
            // 
            this.LBLrazred.AutoSize = true;
            this.LBLrazred.Location = new System.Drawing.Point(18, 64);
            this.LBLrazred.Name = "LBLrazred";
            this.LBLrazred.Size = new System.Drawing.Size(44, 13);
            this.LBLrazred.TabIndex = 1;
            this.LBLrazred.Text = "Razred:";
            // 
            // LBLprezime
            // 
            this.LBLprezime.AutoSize = true;
            this.LBLprezime.Location = new System.Drawing.Point(15, 37);
            this.LBLprezime.Name = "LBLprezime";
            this.LBLprezime.Size = new System.Drawing.Size(47, 13);
            this.LBLprezime.TabIndex = 2;
            this.LBLprezime.Text = "Prezime:";
            // 
            // BTNunos
            // 
            this.BTNunos.Location = new System.Drawing.Point(360, 9);
            this.BTNunos.Name = "BTNunos";
            this.BTNunos.Size = new System.Drawing.Size(137, 72);
            this.BTNunos.TabIndex = 3;
            this.BTNunos.Text = "Unos";
            this.BTNunos.UseVisualStyleBackColor = true;
            this.BTNunos.Click += new System.EventHandler(this.BTNunos_Click);
            // 
            // BTNobrada
            // 
            this.BTNobrada.Location = new System.Drawing.Point(646, 9);
            this.BTNobrada.Name = "BTNobrada";
            this.BTNobrada.Size = new System.Drawing.Size(137, 72);
            this.BTNobrada.TabIndex = 4;
            this.BTNobrada.Text = "Obrada";
            this.BTNobrada.UseVisualStyleBackColor = true;
            this.BTNobrada.Click += new System.EventHandler(this.BTNobrada_Click);
            // 
            // BTNpregled
            // 
            this.BTNpregled.Location = new System.Drawing.Point(503, 9);
            this.BTNpregled.Name = "BTNpregled";
            this.BTNpregled.Size = new System.Drawing.Size(137, 72);
            this.BTNpregled.TabIndex = 5;
            this.BTNpregled.Text = "Pregled";
            this.BTNpregled.UseVisualStyleBackColor = true;
            this.BTNpregled.Click += new System.EventHandler(this.BTNpregled_Click);
            // 
            // RTBispis
            // 
            this.RTBispis.Location = new System.Drawing.Point(12, 87);
            this.RTBispis.Name = "RTBispis";
            this.RTBispis.Size = new System.Drawing.Size(776, 351);
            this.RTBispis.TabIndex = 6;
            this.RTBispis.Text = "";
            // 
            // TXTime
            // 
            this.TXTime.Location = new System.Drawing.Point(69, 9);
            this.TXTime.Name = "TXTime";
            this.TXTime.Size = new System.Drawing.Size(285, 20);
            this.TXTime.TabIndex = 7;
            // 
            // TXTprezime
            // 
            this.TXTprezime.Location = new System.Drawing.Point(69, 34);
            this.TXTprezime.Name = "TXTprezime";
            this.TXTprezime.Size = new System.Drawing.Size(285, 20);
            this.TXTprezime.TabIndex = 8;
            // 
            // CMBrazred
            // 
            this.CMBrazred.FormattingEnabled = true;
            this.CMBrazred.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4."});
            this.CMBrazred.Location = new System.Drawing.Point(69, 60);
            this.CMBrazred.Name = "CMBrazred";
            this.CMBrazred.Size = new System.Drawing.Size(285, 21);
            this.CMBrazred.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMBrazred);
            this.Controls.Add(this.TXTprezime);
            this.Controls.Add(this.TXTime);
            this.Controls.Add(this.RTBispis);
            this.Controls.Add(this.BTNpregled);
            this.Controls.Add(this.BTNobrada);
            this.Controls.Add(this.BTNunos);
            this.Controls.Add(this.LBLprezime);
            this.Controls.Add(this.LBLrazred);
            this.Controls.Add(this.LBLime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLime;
        private System.Windows.Forms.Label LBLrazred;
        private System.Windows.Forms.Label LBLprezime;
        private System.Windows.Forms.Button BTNunos;
        private System.Windows.Forms.Button BTNobrada;
        private System.Windows.Forms.Button BTNpregled;
        private System.Windows.Forms.RichTextBox RTBispis;
        private System.Windows.Forms.TextBox TXTime;
        private System.Windows.Forms.TextBox TXTprezime;
        private System.Windows.Forms.ComboBox CMBrazred;
    }
}

