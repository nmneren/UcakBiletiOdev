
namespace OdevUcakBiletAlma
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
            this.cmb_nereden = new System.Windows.Forms.ComboBox();
            this.cmb_nereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.dateTimePicker_gidis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_donus = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_yon = new System.Windows.Forms.CheckBox();
            this.cmb_bilet_turu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_satın_al = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_biletler = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_nereden
            // 
            this.cmb_nereden.FormattingEnabled = true;
            this.cmb_nereden.Location = new System.Drawing.Point(28, 55);
            this.cmb_nereden.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_nereden.Name = "cmb_nereden";
            this.cmb_nereden.Size = new System.Drawing.Size(221, 24);
            this.cmb_nereden.TabIndex = 0;
            this.cmb_nereden.SelectedIndexChanged += new System.EventHandler(this.cmb_nereden_SelectedIndexChanged);
            // 
            // cmb_nereye
            // 
            this.cmb_nereye.FormattingEnabled = true;
            this.cmb_nereye.Location = new System.Drawing.Point(301, 55);
            this.cmb_nereye.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_nereye.Name = "cmb_nereye";
            this.cmb_nereye.Size = new System.Drawing.Size(221, 24);
            this.cmb_nereye.TabIndex = 1;
            this.cmb_nereye.SelectedIndexChanged += new System.EventHandler(this.cmb_nereye_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(300, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye";
            // 
            // btn_degistir
            // 
            this.btn_degistir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_degistir.Location = new System.Drawing.Point(257, 54);
            this.btn_degistir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(36, 24);
            this.btn_degistir.TabIndex = 5;
            this.btn_degistir.Text = "⇆";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // dateTimePicker_gidis
            // 
            this.dateTimePicker_gidis.Location = new System.Drawing.Point(28, 109);
            this.dateTimePicker_gidis.Name = "dateTimePicker_gidis";
            this.dateTimePicker_gidis.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker_gidis.TabIndex = 6;
            // 
            // dateTimePicker_donus
            // 
            this.dateTimePicker_donus.Location = new System.Drawing.Point(301, 108);
            this.dateTimePicker_donus.Name = "dateTimePicker_donus";
            this.dateTimePicker_donus.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker_donus.TabIndex = 7;
            this.dateTimePicker_donus.ValueChanged += new System.EventHandler(this.dateTimePicker_donus_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gidiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(300, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dönüş Tarihi";
            // 
            // checkBox_yon
            // 
            this.checkBox_yon.AutoSize = true;
            this.checkBox_yon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_yon.Location = new System.Drawing.Point(457, 86);
            this.checkBox_yon.Name = "checkBox_yon";
            this.checkBox_yon.Size = new System.Drawing.Size(65, 19);
            this.checkBox_yon.TabIndex = 10;
            this.checkBox_yon.Text = "Tek Yön";
            this.checkBox_yon.UseVisualStyleBackColor = true;
            this.checkBox_yon.CheckedChanged += new System.EventHandler(this.checkBox_yon_CheckedChanged);
            // 
            // cmb_bilet_turu
            // 
            this.cmb_bilet_turu.FormattingEnabled = true;
            this.cmb_bilet_turu.Items.AddRange(new object[] {
            "Ekonomi",
            "Premium",
            "Busines"});
            this.cmb_bilet_turu.Location = new System.Drawing.Point(301, 167);
            this.cmb_bilet_turu.Name = "cmb_bilet_turu";
            this.cmb_bilet_turu.Size = new System.Drawing.Size(135, 24);
            this.cmb_bilet_turu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(300, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bilet Türü";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(442, 168);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(438, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kişi Sayısı";
            // 
            // btn_satın_al
            // 
            this.btn_satın_al.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satın_al.Location = new System.Drawing.Point(301, 200);
            this.btn_satın_al.Name = "btn_satın_al";
            this.btn_satın_al.Size = new System.Drawing.Size(221, 36);
            this.btn_satın_al.TabIndex = 16;
            this.btn_satın_al.Text = "Bilet Satın Al";
            this.btn_satın_al.UseVisualStyleBackColor = true;
            this.btn_satın_al.Click += new System.EventHandler(this.btn_satın_al_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(28, 167);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(221, 22);
            this.txt_ad.TabIndex = 17;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(28, 214);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(221, 22);
            this.txt_tel.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ad Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefon";
            // 
            // listBox_biletler
            // 
            this.listBox_biletler.FormattingEnabled = true;
            this.listBox_biletler.ItemHeight = 16;
            this.listBox_biletler.Location = new System.Drawing.Point(570, 54);
            this.listBox_biletler.Name = "listBox_biletler";
            this.listBox_biletler.Size = new System.Drawing.Size(720, 180);
            this.listBox_biletler.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(566, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Alınan Biletler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 278);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_biletler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.btn_satın_al);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_bilet_turu);
            this.Controls.Add(this.checkBox_yon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_donus);
            this.Controls.Add(this.dateTimePicker_gidis);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_nereye);
            this.Controls.Add(this.cmb_nereden);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_nereden;
        private System.Windows.Forms.ComboBox cmb_nereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gidis;
        private System.Windows.Forms.DateTimePicker dateTimePicker_donus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_yon;
        private System.Windows.Forms.ComboBox cmb_bilet_turu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_satın_al;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_biletler;
        private System.Windows.Forms.Label label9;
    }
}

