namespace Asal_Sayı_Kontrolü_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_Ev_K = new System.Windows.Forms.CheckBox();
            this.checkBox_Arsa_S = new System.Windows.Forms.CheckBox();
            this.checkBox_Arsa_K = new System.Windows.Forms.CheckBox();
            this.checkBox_Ev_s = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(215, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gayrimenkul Komisyon Hesabı";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(186, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 304);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(26, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(159, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Komisyon Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış Tutarı";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(26, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox_Ev_K
            // 
            this.checkBox_Ev_K.AutoSize = true;
            this.checkBox_Ev_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox_Ev_K.Location = new System.Drawing.Point(13, 134);
            this.checkBox_Ev_K.Name = "checkBox_Ev_K";
            this.checkBox_Ev_K.Size = new System.Drawing.Size(139, 29);
            this.checkBox_Ev_K.TabIndex = 3;
            this.checkBox_Ev_K.Text = "Ev Kiralama";
            this.checkBox_Ev_K.UseVisualStyleBackColor = true;
            this.checkBox_Ev_K.CheckedChanged += new System.EventHandler(this.checkBox_Ev_K_CheckedChanged);
            // 
            // checkBox_Arsa_S
            // 
            this.checkBox_Arsa_S.AutoSize = true;
            this.checkBox_Arsa_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox_Arsa_S.Location = new System.Drawing.Point(12, 271);
            this.checkBox_Arsa_S.Name = "checkBox_Arsa_S";
            this.checkBox_Arsa_S.Size = new System.Drawing.Size(128, 29);
            this.checkBox_Arsa_S.TabIndex = 4;
            this.checkBox_Arsa_S.Text = "Arsa Satışı";
            this.checkBox_Arsa_S.UseVisualStyleBackColor = true;
            this.checkBox_Arsa_S.CheckedChanged += new System.EventHandler(this.checkBox_Arsa_S_CheckedChanged);
            // 
            // checkBox_Arsa_K
            // 
            this.checkBox_Arsa_K.AutoSize = true;
            this.checkBox_Arsa_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox_Arsa_K.Location = new System.Drawing.Point(13, 224);
            this.checkBox_Arsa_K.Name = "checkBox_Arsa_K";
            this.checkBox_Arsa_K.Size = new System.Drawing.Size(157, 29);
            this.checkBox_Arsa_K.TabIndex = 5;
            this.checkBox_Arsa_K.Text = "Arsa Kiralama";
            this.checkBox_Arsa_K.UseVisualStyleBackColor = true;
            this.checkBox_Arsa_K.CheckedChanged += new System.EventHandler(this.checkBox_Arsa_K_CheckedChanged);
            // 
            // checkBox_Ev_s
            // 
            this.checkBox_Ev_s.AutoSize = true;
            this.checkBox_Ev_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox_Ev_s.Location = new System.Drawing.Point(13, 176);
            this.checkBox_Ev_s.Name = "checkBox_Ev_s";
            this.checkBox_Ev_s.Size = new System.Drawing.Size(106, 29);
            this.checkBox_Ev_s.TabIndex = 6;
            this.checkBox_Ev_s.Text = "Ev satışı";
            this.checkBox_Ev_s.UseVisualStyleBackColor = true;
            this.checkBox_Ev_s.CheckedChanged += new System.EventHandler(this.checkBox_Ev_s_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gayrimenkul Türü Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_Ev_s);
            this.Controls.Add(this.checkBox_Arsa_K);
            this.Controls.Add(this.checkBox_Arsa_S);
            this.Controls.Add(this.checkBox_Ev_K);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlak Komisyon Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_Ev_K;
        private System.Windows.Forms.CheckBox checkBox_Arsa_S;
        private System.Windows.Forms.CheckBox checkBox_Arsa_K;
        private System.Windows.Forms.CheckBox checkBox_Ev_s;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

