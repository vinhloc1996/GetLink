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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetLink = new System.Windows.Forms.Button();
            this.txtLinksInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1827, 764);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.flowpnl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGetLink);
            this.tabPage1.Controls.Add(this.txtLinksInput);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1807, 706);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VuiGhe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(180, 42);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetLink
            // 
            this.btnGetLink.Location = new System.Drawing.Point(1158, 42);
            this.btnGetLink.Name = "btnGetLink";
            this.btnGetLink.Size = new System.Drawing.Size(253, 58);
            this.btnGetLink.TabIndex = 3;
            this.btnGetLink.Text = "Get Link";
            this.btnGetLink.UseVisualStyleBackColor = true;
            this.btnGetLink.Click += new System.EventHandler(this.btnGetLink_Click);
            // 
            // txtLinksInput
            // 
            this.txtLinksInput.Location = new System.Drawing.Point(433, 53);
            this.txtLinksInput.Name = "txtLinksInput";
            this.txtLinksInput.Size = new System.Drawing.Size(552, 38);
            this.txtLinksInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link";
            // 
            // flowpnl
            // 
            this.flowpnl.AutoScroll = true;
            this.flowpnl.Location = new System.Drawing.Point(7, 247);
            this.flowpnl.Name = "flowpnl";
            this.flowpnl.Size = new System.Drawing.Size(1794, 453);
            this.flowpnl.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 6;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLink;
        private System.Windows.Forms.TextBox txtLinksInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

