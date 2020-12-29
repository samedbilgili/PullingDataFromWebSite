
namespace kurcekme
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
            this.txtUsd = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHepsiburadaFiyatGetir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsd
            // 
            this.txtUsd.Location = new System.Drawing.Point(164, 45);
            this.txtUsd.Name = "txtUsd";
            this.txtUsd.Size = new System.Drawing.Size(100, 20);
            this.txtUsd.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(164, 83);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(206, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Verileri Getir";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USD";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(270, 45);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EURO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trendyol - İphone 12";
            // 
            // btnHepsiburadaFiyatGetir
            // 
            this.btnHepsiburadaFiyatGetir.Location = new System.Drawing.Point(164, 261);
            this.btnHepsiburadaFiyatGetir.Name = "btnHepsiburadaFiyatGetir";
            this.btnHepsiburadaFiyatGetir.Size = new System.Drawing.Size(206, 23);
            this.btnHepsiburadaFiyatGetir.TabIndex = 5;
            this.btnHepsiburadaFiyatGetir.Text = "Verileri Getir";
            this.btnHepsiburadaFiyatGetir.UseVisualStyleBackColor = true;
            this.btnHepsiburadaFiyatGetir.Click += new System.EventHandler(this.btnHepsiburadaFiyatGetir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hepsiburada - İphone 12";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(206, 231);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(66, 20);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "lblMesaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 351);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnHepsiburadaFiyatGetir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtUsd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsd;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHepsiburadaFiyatGetir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMesaj;
    }
}

