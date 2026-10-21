namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tələbəToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.əlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qiymətYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.göstərToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıxışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lstStats = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tələbəToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.çıxışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tələbəToolStripMenuItem
            // 
            this.tələbəToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.əlavəEtToolStripMenuItem,
            this.qiymətYazToolStripMenuItem});
            this.tələbəToolStripMenuItem.Name = "tələbəToolStripMenuItem";
            this.tələbəToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.tələbəToolStripMenuItem.Text = "Tələbə";
            // 
            // əlavəEtToolStripMenuItem
            // 
            this.əlavəEtToolStripMenuItem.Name = "əlavəEtToolStripMenuItem";
            this.əlavəEtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.əlavəEtToolStripMenuItem.Text = "Əlavə et";
            this.əlavəEtToolStripMenuItem.Click += new System.EventHandler(this.əlavəEtToolStripMenuItem_Click);
            // 
            // qiymətYazToolStripMenuItem
            // 
            this.qiymətYazToolStripMenuItem.Name = "qiymətYazToolStripMenuItem";
            this.qiymətYazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qiymətYazToolStripMenuItem.Text = "Qiymət yaz";
            this.qiymətYazToolStripMenuItem.Click += new System.EventHandler(this.qiymətYazToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.göstərToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // göstərToolStripMenuItem
            // 
            this.göstərToolStripMenuItem.Name = "göstərToolStripMenuItem";
            this.göstərToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.göstərToolStripMenuItem.Text = "Göstər";
            this.göstərToolStripMenuItem.Click += new System.EventHandler(this.göstərToolStripMenuItem_Click);
            // 
            // çıxışToolStripMenuItem
            // 
            this.çıxışToolStripMenuItem.Name = "çıxışToolStripMenuItem";
            this.çıxışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıxışToolStripMenuItem.Text = "Çıxış";
            this.çıxışToolStripMenuItem.Click += new System.EventHandler(this.çıxışToolStripMenuItem_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 72);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(13, 126);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(13, 176);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(13, 228);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(12, 276);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(12, 319);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tələbə kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fənn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Qiymət";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(197, 72);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(271, 84);
            this.lstStudents.TabIndex = 13;
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.ItemHeight = 16;
            this.lstStats.Location = new System.Drawing.Point(197, 189);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(271, 84);
            this.lstStats.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstStats);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tələbəToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem əlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qiymətYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem göstərToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem çıxışToolStripMenuItem;
    }
}

