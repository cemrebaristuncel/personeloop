
namespace oopornegi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.sskNoTxt = new System.Windows.Forms.TextBox();
            this.maasTxt = new System.Windows.Forms.TextBox();
            this.zamTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aciklamaLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekstraZamTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(59, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Tipleri";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(52, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Çalışan";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(182, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Müdür";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Red;
            this.radioButton3.Location = new System.Drawing.Point(305, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 30);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Satışçı";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(247, 110);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 20);
            this.adTxt.TabIndex = 1;
            // 
            // sskNoTxt
            // 
            this.sskNoTxt.Location = new System.Drawing.Point(247, 145);
            this.sskNoTxt.Name = "sskNoTxt";
            this.sskNoTxt.Size = new System.Drawing.Size(100, 20);
            this.sskNoTxt.TabIndex = 2;
            // 
            // maasTxt
            // 
            this.maasTxt.Location = new System.Drawing.Point(247, 183);
            this.maasTxt.Name = "maasTxt";
            this.maasTxt.Size = new System.Drawing.Size(100, 20);
            this.maasTxt.TabIndex = 3;
            // 
            // zamTxt
            // 
            this.zamTxt.Location = new System.Drawing.Point(247, 224);
            this.zamTxt.Name = "zamTxt";
            this.zamTxt.Size = new System.Drawing.Size(100, 20);
            this.zamTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(200, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(175, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SSK No";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(184, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(144, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zam Miktarı";
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ekleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleBtn.ForeColor = System.Drawing.Color.Black;
            this.ekleBtn.Location = new System.Drawing.Point(247, 302);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(100, 29);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(59, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Listesi";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Items.AddRange(new object[] {
            "SSK No / İsim / Maaş / Satış Sayısı (Satışçı İçin)",
            "---------------------------------------------------------------------------------" +
                "-------"});
            this.listBox1.Location = new System.Drawing.Point(0, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 238);
            this.listBox1.TabIndex = 0;
            // 
            // aciklamaLbl
            // 
            this.aciklamaLbl.AutoSize = true;
            this.aciklamaLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamaLbl.ForeColor = System.Drawing.Color.Red;
            this.aciklamaLbl.Location = new System.Drawing.Point(211, 343);
            this.aciklamaLbl.Name = "aciklamaLbl";
            this.aciklamaLbl.Size = new System.Drawing.Size(136, 24);
            this.aciklamaLbl.TabIndex = 11;
            this.aciklamaLbl.Text = "Açıklama Label";
            this.aciklamaLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(119, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departman Karı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // ekstraZamTxt
            // 
            this.ekstraZamTxt.Location = new System.Drawing.Point(247, 265);
            this.ekstraZamTxt.Name = "ekstraZamTxt";
            this.ekstraZamTxt.Size = new System.Drawing.Size(100, 20);
            this.ekstraZamTxt.TabIndex = 13;
            this.ekstraZamTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(555, 649);
            this.Controls.Add(this.ekstraZamTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aciklamaLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zamTxt);
            this.Controls.Add(this.maasTxt);
            this.Controls.Add(this.sskNoTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox sskNoTxt;
        private System.Windows.Forms.TextBox maasTxt;
        private System.Windows.Forms.TextBox zamTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label aciklamaLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ekstraZamTxt;
    }
}

