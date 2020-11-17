namespace AlfredApp
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
            this.tbxAreaMin = new System.Windows.Forms.TextBox();
            this.boxLocations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAreaMax = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxAreaMin
            // 
            this.tbxAreaMin.Location = new System.Drawing.Point(90, 77);
            this.tbxAreaMin.Name = "tbxAreaMin";
            this.tbxAreaMin.Size = new System.Drawing.Size(75, 22);
            this.tbxAreaMin.TabIndex = 1;
            this.tbxAreaMin.Text = "75";
            // 
            // boxLocations
            // 
            this.boxLocations.FormattingEnabled = true;
            this.boxLocations.Items.AddRange(new object[] {
            "ADALAR",
            "ARNAVUTKÖY",
            "ATAŞEHİR",
            "AVCILAR",
            "BAĞCILAR",
            "BAHÇELİEVLER",
            "BAKIRKÖY",
            "BAŞAKŞEHİR",
            "BAYRAMPAŞA",
            "BEŞİKTAŞ",
            "BEYKOZ",
            "BEYLİKDÜZÜ",
            "BEYOĞLU",
            "BÜYÜKÇEKMECE",
            "ÇATALCA",
            "ÇEKMEKÖY",
            "ESENLER",
            "ESENYURT",
            "EYÜPSULTAN",
            "FATİH",
            "GAZİOSMANPAŞA",
            "GÜNGÖREN",
            "KADIKÖY",
            "KAĞITHANE",
            "KARTAL",
            "KÜÇÜKÇEKMECE",
            "MALTEPE",
            "PENDİK",
            "SANCAKTEPE",
            "SARIYER",
            "SİLİVRİ",
            "SULTANBEYLİ",
            "SULTANGAZİ",
            "ŞİLE",
            "ŞİŞLİ",
            "TUZLA",
            "ÜMRANİYE",
            "ÜSKÜDAR",
            "ZEYTİNBURNU"});
            this.boxLocations.Location = new System.Drawing.Point(90, 33);
            this.boxLocations.Name = "boxLocations";
            this.boxLocations.Size = new System.Drawing.Size(175, 24);
            this.boxLocations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area(m2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // tbxAreaMax
            // 
            this.tbxAreaMax.Location = new System.Drawing.Point(190, 77);
            this.tbxAreaMax.Name = "tbxAreaMax";
            this.tbxAreaMax.Size = new System.Drawing.Size(75, 22);
            this.tbxAreaMax.TabIndex = 5;
            this.tbxAreaMax.Text = "150";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 16;
            this.lbxResults.Location = new System.Drawing.Point(90, 157);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(381, 260);
            this.lbxResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxAreaMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxLocations);
            this.Controls.Add(this.tbxAreaMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAreaMin;
        private System.Windows.Forms.ComboBox boxLocations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAreaMax;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxResults;
    }
}

