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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lviewResults = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnWatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbQualities = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lboxEpisodes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetAllLinks = new System.Windows.Forms.Button();
            this.btnFinalEpisode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEpisode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetEpisode = new System.Windows.Forms.Button();
            this.txtLinksInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVuiGhe.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabVuiGhe.Controls.Add(this.panel4);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.lviewResults);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSearchBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(955, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 693);
            this.panel4.TabIndex = 13;
            // 
            // lviewResults
            // 
            this.lviewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviewResults.FullRowSelect = true;
            this.lviewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewResults.Location = new System.Drawing.Point(15, 98);
            this.lviewResults.MultiSelect = false;
            this.lviewResults.Name = "lviewResults";
            this.lviewResults.Size = new System.Drawing.Size(796, 355);
            this.lviewResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lviewResults.TabIndex = 4;
            this.lviewResults.UseCompatibleStateImageBehavior = false;
            this.lviewResults.View = System.Windows.Forms.View.Details;
            this.lviewResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviewResults_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(433, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(196, 61);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(130, 32);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(267, 38);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.lboxEpisodes);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 486);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWatch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbbQualities);
            this.panel3.Location = new System.Drawing.Point(203, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 124);
            this.panel3.TabIndex = 13;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(300, 41);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(172, 64);
            this.btnWatch.TabIndex = 2;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
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
            // cbbQualities
            // 
            this.cbbQualities.FormattingEnabled = true;
            this.cbbQualities.Location = new System.Drawing.Point(23, 55);
            this.cbbQualities.Name = "cbbQualities";
            this.cbbQualities.Size = new System.Drawing.Size(261, 39);
            this.cbbQualities.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(16, 361);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(169, 65);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lboxEpisodes
            // 
            this.lboxEpisodes.FormattingEnabled = true;
            this.lboxEpisodes.ItemHeight = 31;
            this.lboxEpisodes.Location = new System.Drawing.Point(16, 14);
            this.lboxEpisodes.Name = "lboxEpisodes";
            this.lboxEpisodes.ScrollAlwaysVisible = true;
            this.lboxEpisodes.Size = new System.Drawing.Size(881, 283);
            this.lboxEpisodes.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetAllLinks);
            this.panel1.Controls.Add(this.btnFinalEpisode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEpisode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGetEpisode);
            this.panel1.Controls.Add(this.txtLinksInput);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 202);
            this.panel1.TabIndex = 11;
            // 
            // btnGetAllLinks
            // 
            this.btnGetAllLinks.Location = new System.Drawing.Point(670, 19);
            this.btnGetAllLinks.Name = "btnGetAllLinks";
            this.btnGetAllLinks.Size = new System.Drawing.Size(233, 58);
            this.btnGetAllLinks.TabIndex = 15;
            this.btnGetAllLinks.Text = "Get All Links";
            this.btnGetAllLinks.UseVisualStyleBackColor = true;
            this.btnGetAllLinks.Click += new System.EventHandler(this.btnGetAllLinks_Click);
            // 
            // btnFinalEpisode
            // 
            this.btnFinalEpisode.Location = new System.Drawing.Point(554, 123);
            this.btnFinalEpisode.Name = "btnFinalEpisode";
            this.btnFinalEpisode.Size = new System.Drawing.Size(289, 58);
            this.btnFinalEpisode.TabIndex = 14;
            this.btnFinalEpisode.Text = "Get Final Episode";
            this.btnFinalEpisode.UseVisualStyleBackColor = true;
            this.btnFinalEpisode.Click += new System.EventHandler(this.btnFinalEpisode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Episode";
            // 
            // txtEpisode
            // 
            this.txtEpisode.Location = new System.Drawing.Point(141, 134);
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Size = new System.Drawing.Size(160, 38);
            this.txtEpisode.TabIndex = 12;
            this.txtEpisode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEpisode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Link";
            // 
            // btnGetEpisode
            // 
            this.btnGetEpisode.Location = new System.Drawing.Point(318, 123);
            this.btnGetEpisode.Name = "btnGetEpisode";
            this.btnGetEpisode.Size = new System.Drawing.Size(215, 58);
            this.btnGetEpisode.TabIndex = 10;
            this.btnGetEpisode.Text = "Get Episode";
            this.btnGetEpisode.UseVisualStyleBackColor = true;
            this.btnGetEpisode.Click += new System.EventHandler(this.btnGetEpisode_Click);
            // 
            // txtLinksInput
            // 
            this.txtLinksInput.Location = new System.Drawing.Point(90, 33);
            this.txtLinksInput.Name = "txtLinksInput";
            this.txtLinksInput.Size = new System.Drawing.Size(552, 38);
            this.txtLinksInput.TabIndex = 9;
            this.txtLinksInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinksInput_KeyPress);
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
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(699, 362);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(198, 64);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export Links";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnGetEpisode;
        private System.Windows.Forms.TextBox txtLinksInput;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lboxEpisodes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQualities;
        private System.Windows.Forms.Button btnFinalEpisode;
        private System.Windows.Forms.Button btnGetAllLinks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lviewResults;
        private System.Windows.Forms.Button btnExport;
    }
}

