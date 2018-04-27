namespace WindowsFormsApplication11
{
    partial class EnterUser
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_login = new System.Windows.Forms.LinkLabel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 235);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(28, 295);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 13);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.TabStop = true;
            this.lbl_login.Text = "Log In";
            this.lbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_login_LinkClicked);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(33, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "name";
            // 
            // EnterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 326);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EnterUser";
            this.Text = "EnterUser";
            this.Load += new System.EventHandler(this.EnterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel lbl_login;
        private System.Windows.Forms.Label lbl_name;
    }
}