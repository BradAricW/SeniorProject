namespace EdgeLook1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.edgeLogo = new System.Windows.Forms.Label();
            this.sevenWonders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.eMailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edgeLogo
            // 
            this.edgeLogo.Image = ((System.Drawing.Image)(resources.GetObject("edgeLogo.Image")));
            this.edgeLogo.Location = new System.Drawing.Point(293, 335);
            this.edgeLogo.Name = "edgeLogo";
            this.edgeLogo.Size = new System.Drawing.Size(100, 65);
            this.edgeLogo.TabIndex = 9;
            // 
            // sevenWonders
            // 
            this.sevenWonders.Image = ((System.Drawing.Image)(resources.GetObject("sevenWonders.Image")));
            this.sevenWonders.Location = new System.Drawing.Point(399, 335);
            this.sevenWonders.Name = "sevenWonders";
            this.sevenWonders.Size = new System.Drawing.Size(111, 65);
            this.sevenWonders.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.eMailLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Location = new System.Drawing.Point(247, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 242);
            this.panel1.TabIndex = 10;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(121, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 24);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailLabel.ForeColor = System.Drawing.Color.White;
            this.eMailLabel.Location = new System.Drawing.Point(32, 76);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(45, 15);
            this.eMailLabel.TabIndex = 1;
            this.eMailLabel.Text = "Email: ";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(10, 113);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 15);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password: ";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(83, 75);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(180, 20);
            this.emailBox.TabIndex = 3;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(83, 112);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(180, 20);
            this.passBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(188, 150);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(183, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Create Account]";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edgeLogo);
            this.Controls.Add(this.sevenWonders);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label edgeLogo;
        private System.Windows.Forms.Label sevenWonders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}