namespace GraGUI
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.LabelZaDuzo = new System.Windows.Forms.Label();
            this.LabelZaMalo = new System.Windows.Forms.Label();
            this.LabelTrafiles = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxSprawdz = new System.Windows.Forms.TextBox();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonZakoncz = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.TemporaryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonWylosuj);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Losowanie";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zakres do";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zakres od";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(203, 66);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 0;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // LabelZaDuzo
            // 
            this.LabelZaDuzo.AutoSize = true;
            this.LabelZaDuzo.ForeColor = System.Drawing.Color.Red;
            this.LabelZaDuzo.Location = new System.Drawing.Point(32, 325);
            this.LabelZaDuzo.Name = "LabelZaDuzo";
            this.LabelZaDuzo.Size = new System.Drawing.Size(49, 13);
            this.LabelZaDuzo.TabIndex = 2;
            this.LabelZaDuzo.Text = "Za dużo!";
            this.LabelZaDuzo.Visible = false;
            // 
            // LabelZaMalo
            // 
            this.LabelZaMalo.AutoSize = true;
            this.LabelZaMalo.ForeColor = System.Drawing.Color.Red;
            this.LabelZaMalo.Location = new System.Drawing.Point(117, 325);
            this.LabelZaMalo.Name = "LabelZaMalo";
            this.LabelZaMalo.Size = new System.Drawing.Size(50, 13);
            this.LabelZaMalo.TabIndex = 3;
            this.LabelZaMalo.Text = "Za mało!";
            this.LabelZaMalo.Visible = false;
            // 
            // LabelTrafiles
            // 
            this.LabelTrafiles.AutoSize = true;
            this.LabelTrafiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelTrafiles.Location = new System.Drawing.Point(212, 325);
            this.LabelTrafiles.Name = "LabelTrafiles";
            this.LabelTrafiles.Size = new System.Drawing.Size(78, 13);
            this.LabelTrafiles.TabIndex = 4;
            this.LabelTrafiles.Text = "Brawo, trafiłeś!";
            this.LabelTrafiles.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(215, 238);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 5;
            this.buttonSprawdz.Text = "Sprawdź.";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Visible = false;
            // 
            // textBoxSprawdz
            // 
            this.textBoxSprawdz.Location = new System.Drawing.Point(93, 241);
            this.textBoxSprawdz.Name = "textBoxSprawdz";
            this.textBoxSprawdz.Size = new System.Drawing.Size(109, 20);
            this.textBoxSprawdz.TabIndex = 6;
            this.textBoxSprawdz.Visible = false;
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Location = new System.Drawing.Point(220, 13);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(75, 23);
            this.buttonWyjscie.TabIndex = 7;
            this.buttonWyjscie.Text = "Wyjście.";
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // buttonZakoncz
            // 
            this.buttonZakoncz.Location = new System.Drawing.Point(120, 393);
            this.buttonZakoncz.Name = "buttonZakoncz";
            this.buttonZakoncz.Size = new System.Drawing.Size(75, 23);
            this.buttonZakoncz.TabIndex = 8;
            this.buttonZakoncz.Text = "Zakończ.";
            this.buttonZakoncz.UseVisualStyleBackColor = true;
            this.buttonZakoncz.Visible = false;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(32, 289);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(35, 13);
            this.errorMsg.TabIndex = 9;
            this.errorMsg.Text = "label3";
            this.errorMsg.Visible = false;
            this.errorMsg.Click += new System.EventHandler(this.errorMsg_Click);
            // 
            // TemporaryLabel
            // 
            this.TemporaryLabel.AutoSize = true;
            this.TemporaryLabel.Location = new System.Drawing.Point(35, 212);
            this.TemporaryLabel.Name = "TemporaryLabel";
            this.TemporaryLabel.Size = new System.Drawing.Size(35, 13);
            this.TemporaryLabel.TabIndex = 10;
            this.TemporaryLabel.Text = "label3";
            this.TemporaryLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.TemporaryLabel);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.buttonZakoncz);
            this.Controls.Add(this.buttonWyjscie);
            this.Controls.Add(this.textBoxSprawdz);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.LabelTrafiles);
            this.Controls.Add(this.LabelZaMalo);
            this.Controls.Add(this.LabelZaDuzo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label LabelZaDuzo;
        private System.Windows.Forms.Label LabelZaMalo;
        private System.Windows.Forms.Label LabelTrafiles;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxSprawdz;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonZakoncz;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label TemporaryLabel;
    }
}

