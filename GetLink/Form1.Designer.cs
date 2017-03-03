namespace GetLink
{
    partial class GetLink
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVuiGhe = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEpisode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetLink = new System.Windows.Forms.Button();
            this.txtLinksInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lboxEpisodes = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbQualities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVuiGhe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVuiGhe);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1827, 764);
            this.tabControl1.TabIndex = 2;
            // 
            // tabVuiGhe
            // 
            this.tabVuiGhe.Controls.Add(this.panel2);
            this.tabVuiGhe.Controls.Add(this.panel1);
            this.tabVuiGhe.Location = new System.Drawing.Point(10, 48);
            this.tabVuiGhe.Name = "tabVuiGhe";
            this.tabVuiGhe.Padding = new System.Windows.Forms.Padding(3);
            this.tabVuiGhe.Size = new System.Drawing.Size(1807, 706);
            this.tabVuiGhe.TabIndex = 0;
            this.tabVuiGhe.Text = "VuiGhe";
            this.tabVuiGhe.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1807, 706);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEpisode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGetLink);
            this.panel1.Controls.Add(this.txtLinksInput);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1795, 235);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Episode";
            // 
            // txtEpisode
            // 
            this.txtEpisode.Location = new System.Drawing.Point(1037, 97);
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Size = new System.Drawing.Size(160, 38);
            this.txtEpisode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Link";
            // 
            // btnGetLink
            // 
            this.btnGetLink.Location = new System.Drawing.Point(1414, 88);
            this.btnGetLink.Name = "btnGetLink";
            this.btnGetLink.Size = new System.Drawing.Size(253, 58);
            this.btnGetLink.TabIndex = 10;
            this.btnGetLink.Text = "Get Link";
            this.btnGetLink.UseVisualStyleBackColor = true;
            this.btnGetLink.Click += new System.EventHandler(this.btnGetLink_Click);
            // 
            // txtLinksInput
            // 
            this.txtLinksInput.Location = new System.Drawing.Point(202, 100);
            this.txtLinksInput.Name = "txtLinksInput";
            this.txtLinksInput.Size = new System.Drawing.Size(552, 38);
            this.txtLinksInput.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.lboxEpisodes);
            this.panel2.Location = new System.Drawing.Point(6, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1795, 441);
            this.panel2.TabIndex = 12;
            // 
            // lboxEpisodes
            // 
            this.lboxEpisodes.FormattingEnabled = true;
            this.lboxEpisodes.ItemHeight = 31;
            this.lboxEpisodes.Location = new System.Drawing.Point(16, 14);
            this.lboxEpisodes.Name = "lboxEpisodes";
            this.lboxEpisodes.ScrollAlwaysVisible = true;
            this.lboxEpisodes.Size = new System.Drawing.Size(1057, 407);
            this.lboxEpisodes.TabIndex = 11;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(1095, 173);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(169, 65);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWatch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbbQualities);
            this.panel3.Location = new System.Drawing.Point(1290, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 124);
            this.panel3.TabIndex = 13;
            // 
            // cbbQualities
            // 
            this.cbbQualities.FormattingEnabled = true;
            this.cbbQualities.Location = new System.Drawing.Point(23, 55);
            this.cbbQualities.Name = "cbbQualities";
            this.cbbQualities.Size = new System.Drawing.Size(261, 39);
            this.cbbQualities.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quality";
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(300, 46);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(172, 59);
            this.btnWatch.TabIndex = 2;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // GetLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1852, 789);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GetLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetLink";
            this.tabControl1.ResumeLayout(false);
            this.tabVuiGhe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVuiGhe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEpisode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLink;
        private System.Windows.Forms.TextBox txtLinksInput;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lboxEpisodes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQualities;
    }
}

