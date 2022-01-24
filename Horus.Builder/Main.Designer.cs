namespace Builder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_build = new System.Windows.Forms.Button();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_slct_malware = new System.Windows.Forms.Button();
            this.btn_slct_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.str_save_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.str_malware = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_horus = new System.Windows.Forms.Label();
            this.lbl_horus_info = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_build);
            this.groupBox1.Controls.Add(this.txt_sname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Location = new System.Drawing.Point(8, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Builder Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Name:";
            // 
            // btn_build
            // 
            this.btn_build.Location = new System.Drawing.Point(304, 29);
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(82, 47);
            this.btn_build.TabIndex = 2;
            this.btn_build.Text = "Build";
            this.btn_build.UseVisualStyleBackColor = true;
            this.btn_build.Click += new System.EventHandler(this.Btn_build_Click);
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(96, 52);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(82, 20);
            this.txt_sname.TabIndex = 3;
            this.txt_sname.Text = "susp.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote URL:";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(95, 29);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(199, 20);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "http://localhost/test/updates.txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_convert);
            this.groupBox2.Controls.Add(this.btn_slct_malware);
            this.groupBox2.Controls.Add(this.btn_slct_save);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.str_save_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.str_malware);
            this.groupBox2.Location = new System.Drawing.Point(8, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converter ( for library )";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(304, 18);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(78, 46);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.Btn_convert_Click);
            // 
            // btn_slct_malware
            // 
            this.btn_slct_malware.Location = new System.Drawing.Point(275, 18);
            this.btn_slct_malware.Name = "btn_slct_malware";
            this.btn_slct_malware.Size = new System.Drawing.Size(26, 21);
            this.btn_slct_malware.TabIndex = 6;
            this.btn_slct_malware.Text = "...";
            this.btn_slct_malware.UseVisualStyleBackColor = true;
            this.btn_slct_malware.Click += new System.EventHandler(this.Btn_slct_malware_Click);
            // 
            // btn_slct_save
            // 
            this.btn_slct_save.Location = new System.Drawing.Point(275, 42);
            this.btn_slct_save.Name = "btn_slct_save";
            this.btn_slct_save.Size = new System.Drawing.Size(26, 21);
            this.btn_slct_save.TabIndex = 5;
            this.btn_slct_save.Text = "...";
            this.btn_slct_save.UseVisualStyleBackColor = true;
            this.btn_slct_save.Click += new System.EventHandler(this.Btn_slct_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save Name:";
            // 
            // str_save_txt
            // 
            this.str_save_txt.Location = new System.Drawing.Point(95, 43);
            this.str_save_txt.Name = "str_save_txt";
            this.str_save_txt.Size = new System.Drawing.Size(174, 20);
            this.str_save_txt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Library:";
            // 
            // str_malware
            // 
            this.str_malware.Location = new System.Drawing.Point(95, 19);
            this.str_malware.Name = "str_malware";
            this.str_malware.Size = new System.Drawing.Size(174, 20);
            this.str_malware.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_horus
            // 
            this.lbl_horus.AutoSize = true;
            this.lbl_horus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horus.Location = new System.Drawing.Point(145, 140);
            this.lbl_horus.Name = "lbl_horus";
            this.lbl_horus.Size = new System.Drawing.Size(98, 33);
            this.lbl_horus.TabIndex = 5;
            this.lbl_horus.Text = "Horus";
            // 
            // lbl_horus_info
            // 
            this.lbl_horus_info.AutoSize = true;
            this.lbl_horus_info.Location = new System.Drawing.Point(74, 176);
            this.lbl_horus_info.Name = "lbl_horus_info";
            this.lbl_horus_info.Size = new System.Drawing.Size(247, 13);
            this.lbl_horus_info.TabIndex = 6;
            this.lbl_horus_info.Text = "[H] orus [O] bfuscate [R] emote [U] pdate [S] ystem";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbl_horus_info);
            this.groupBox3.Controls.Add(this.lbl_horus);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 202);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horus v1.5.2 Builder | by Antidote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_build;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_slct_malware;
        private System.Windows.Forms.Button btn_slct_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox str_save_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox str_malware;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_horus;
        private System.Windows.Forms.Label lbl_horus_info;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

