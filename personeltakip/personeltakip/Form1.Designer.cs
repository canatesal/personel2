namespace personeltakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGiris = new Button();
            btnCikis = new Button();
            txtId = new TextBox();
            txtPw = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.LimeGreen;
            btnGiris.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGiris.ForeColor = Color.Transparent;
            btnGiris.Location = new Point(277, 303);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(135, 66);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += button1_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Red;
            btnCikis.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCikis.ForeColor = Color.Transparent;
            btnCikis.Location = new Point(433, 303);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(135, 66);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "ÇIKIŞ YAP";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += button2_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(325, 119);
            txtId.Name = "txtId";
            txtId.Size = new Size(222, 31);
            txtId.TabIndex = 2;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(325, 210);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(222, 31);
            txtPw.TabIndex = 3;
            txtPw.TextChanged += txtPw_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Italic);
            label1.Location = new Point(145, 119);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 4;
            label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Italic);
            label2.Location = new Point(221, 213);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 5;
            label2.Text = "ŞİFRE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 32);
            label3.Name = "label3";
            label3.Size = new Size(470, 35);
            label3.TabIndex = 6;
            label3.Text = "PERSONEL TAKİP SİSTEMİNE HOŞ GELDİNİZ";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Button btnCikis;
        private TextBox txtId;
        private TextBox txtPw;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
