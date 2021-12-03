namespace FoodRescueForm
{
    partial class FoodRescueForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodRescueForm));
            this.childformPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.rightLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.forgotpwBtn = new System.Windows.Forms.Button();
            this.signinPanel2 = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.eyepicturebox = new System.Windows.Forms.PictureBox();
            this.signinPanel1 = new System.Windows.Forms.Panel();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernamePicture = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.namesLabel = new System.Windows.Forms.Label();
            this.developbylabel = new System.Windows.Forms.Label();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childformPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.signinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepicturebox)).BeginInit();
            this.signinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // childformPanel
            // 
            this.childformPanel.Controls.Add(this.rightPanel);
            this.childformPanel.Controls.Add(this.leftPanel);
            this.childformPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childformPanel.Location = new System.Drawing.Point(0, 0);
            this.childformPanel.Name = "childformPanel";
            this.childformPanel.Size = new System.Drawing.Size(750, 530);
            this.childformPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.exitButton);
            this.rightPanel.Controls.Add(this.rightLabel);
            this.rightPanel.Controls.Add(this.loginBtn);
            this.rightPanel.Controls.Add(this.forgotpwBtn);
            this.rightPanel.Controls.Add(this.signinPanel2);
            this.rightPanel.Controls.Add(this.signinPanel1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(450, 530);
            this.rightPanel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(411, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightLabel.ForeColor = System.Drawing.Color.Indigo;
            this.rightLabel.Location = new System.Drawing.Point(104, 117);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(235, 27);
            this.rightLabel.TabIndex = 4;
            this.rightLabel.Text = "Sign in to your account";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Indigo;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(17, 322);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(149, 45);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotpwBtn
            // 
            this.forgotpwBtn.BackColor = System.Drawing.Color.White;
            this.forgotpwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotpwBtn.ForeColor = System.Drawing.Color.Indigo;
            this.forgotpwBtn.Location = new System.Drawing.Point(220, 322);
            this.forgotpwBtn.Name = "forgotpwBtn";
            this.forgotpwBtn.Size = new System.Drawing.Size(149, 45);
            this.forgotpwBtn.TabIndex = 8;
            this.forgotpwBtn.Text = "Forgot Password?";
            this.forgotpwBtn.UseVisualStyleBackColor = false;
            this.forgotpwBtn.Click += new System.EventHandler(this.forgotpwBtn_Click);
            // 
            // signinPanel2
            // 
            this.signinPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.signinPanel2.Controls.Add(this.passwordTextbox);
            this.signinPanel2.Controls.Add(this.pictureBox2);
            this.signinPanel2.Controls.Add(this.eyepicturebox);
            this.signinPanel2.Location = new System.Drawing.Point(6, 258);
            this.signinPanel2.Name = "signinPanel2";
            this.signinPanel2.Size = new System.Drawing.Size(441, 40);
            this.signinPanel2.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextbox.Location = new System.Drawing.Point(53, 12);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(346, 19);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.UseSystemPasswordChar = true;
            this.passwordTextbox.Click += new System.EventHandler(this.passwordTextbox_Click);
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextbox_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // eyepicturebox
            // 
            this.eyepicturebox.Image = ((System.Drawing.Image)(resources.GetObject("eyepicturebox.Image")));
            this.eyepicturebox.Location = new System.Drawing.Point(405, 4);
            this.eyepicturebox.Name = "eyepicturebox";
            this.eyepicturebox.Size = new System.Drawing.Size(30, 33);
            this.eyepicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyepicturebox.TabIndex = 7;
            this.eyepicturebox.TabStop = false;
            this.eyepicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eyepicturebox_MouseDown);
            this.eyepicturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.eyepicturebox_MouseUp);
            // 
            // signinPanel1
            // 
            this.signinPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.signinPanel1.Controls.Add(this.usernameTextbox);
            this.signinPanel1.Controls.Add(this.usernamePicture);
            this.signinPanel1.Location = new System.Drawing.Point(3, 189);
            this.signinPanel1.Name = "signinPanel1";
            this.signinPanel1.Size = new System.Drawing.Size(441, 40);
            this.signinPanel1.TabIndex = 5;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextbox.Location = new System.Drawing.Point(56, 10);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(379, 19);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.Click += new System.EventHandler(this.usernameTextbox_Click);
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // usernamePicture
            // 
            this.usernamePicture.Image = ((System.Drawing.Image)(resources.GetObject("usernamePicture.Image")));
            this.usernamePicture.Location = new System.Drawing.Point(3, 3);
            this.usernamePicture.Name = "usernamePicture";
            this.usernamePicture.Size = new System.Drawing.Size(47, 33);
            this.usernamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernamePicture.TabIndex = 4;
            this.usernamePicture.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Indigo;
            this.leftPanel.Controls.Add(this.namesLabel);
            this.leftPanel.Controls.Add(this.developbylabel);
            this.leftPanel.Controls.Add(this.labelSignIn);
            this.leftPanel.Controls.Add(this.welcomeLabel);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 530);
            this.leftPanel.TabIndex = 1;
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namesLabel.Location = new System.Drawing.Point(12, 507);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(147, 14);
            this.namesLabel.TabIndex = 3;
            this.namesLabel.Text = "Ronni, Natalie and Shkelqim";
            // 
            // developbylabel
            // 
            this.developbylabel.AutoSize = true;
            this.developbylabel.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.developbylabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.developbylabel.Location = new System.Drawing.Point(12, 485);
            this.developbylabel.Name = "developbylabel";
            this.developbylabel.Size = new System.Drawing.Size(73, 14);
            this.developbylabel.TabIndex = 2;
            this.developbylabel.Text = "Developed by";
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSignIn.Location = new System.Drawing.Point(29, 237);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(265, 27);
            this.labelSignIn.TabIndex = 1;
            this.labelSignIn.Text = "Please sign in to continue";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(51, 189);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(207, 27);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to our app";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FoodRescueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.childformPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodRescueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodRescueForm";
            this.Enter += new System.EventHandler(this.FoodRescueForm_Enter);
            this.childformPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.signinPanel2.ResumeLayout(false);
            this.signinPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepicturebox)).EndInit();
            this.signinPanel1.ResumeLayout(false);
            this.signinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel childformPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.Label developbylabel;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button forgotpwBtn;
        private System.Windows.Forms.Panel signinPanel2;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox eyepicturebox;
        private System.Windows.Forms.Panel signinPanel1;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.PictureBox usernamePicture;
    }
}
