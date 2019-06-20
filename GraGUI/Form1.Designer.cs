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
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.LabelWynik = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxSprawdz = new System.Windows.Forms.TextBox();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.WylosowanaLiczba = new System.Windows.Forms.Label();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.labelIle = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.textBoxDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOd);
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
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(81, 91);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(109, 20);
            this.textBoxDo.TabIndex = 3;
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
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(81, 40);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(109, 20);
            this.textBoxOd.TabIndex = 1;
            this.textBoxOd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // LabelWynik
            // 
            this.LabelWynik.AutoSize = true;
            this.LabelWynik.ForeColor = System.Drawing.Color.Red;
            this.LabelWynik.Location = new System.Drawing.Point(117, 325);
            this.LabelWynik.Name = "LabelWynik";
            this.LabelWynik.Size = new System.Drawing.Size(50, 13);
            this.LabelWynik.TabIndex = 3;
            this.LabelWynik.Text = "Za mało!";
            this.LabelWynik.Visible = false;
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
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
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
            // WylosowanaLiczba
            // 
            this.WylosowanaLiczba.AutoSize = true;
            this.WylosowanaLiczba.Location = new System.Drawing.Point(35, 212);
            this.WylosowanaLiczba.Name = "WylosowanaLiczba";
            this.WylosowanaLiczba.Size = new System.Drawing.Size(35, 13);
            this.WylosowanaLiczba.TabIndex = 10;
            this.WylosowanaLiczba.Text = "label3";
            this.WylosowanaLiczba.Visible = false;
            // 
            // buttonAgain
            // 
            this.buttonAgain.Location = new System.Drawing.Point(100, 415);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(102, 23);
            this.buttonAgain.TabIndex = 11;
            this.buttonAgain.Text = "Jeszcze raz?";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Visible = false;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // labelIle
            // 
            this.labelIle.AutoSize = true;
            this.labelIle.Location = new System.Drawing.Point(117, 376);
            this.labelIle.Name = "labelIle";
            this.labelIle.Size = new System.Drawing.Size(35, 13);
            this.labelIle.TabIndex = 12;
            this.labelIle.Text = "label3";
            this.labelIle.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.labelIle);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.WylosowanaLiczba);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.buttonWyjscie);
            this.Controls.Add(this.textBoxSprawdz);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.LabelWynik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Za dużo za mało.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label LabelWynik;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxSprawdz;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label WylosowanaLiczba;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Label labelIle;
    }
}

