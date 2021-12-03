namespace FoodRescueForm
{
    partial class AdminForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.childpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageUserBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.addRestBtn = new System.Windows.Forms.Button();
            this.showRestBtn = new System.Windows.Forms.Button();
            this.showUsersBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Maroon;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 92);
            this.topPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.childpanel);
            this.botPanel.Controls.Add(this.panel1);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botPanel.Location = new System.Drawing.Point(0, 92);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(800, 358);
            this.botPanel.TabIndex = 1;
            // 
            // childpanel
            // 
            this.childpanel.BackColor = System.Drawing.Color.White;
            this.childpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childpanel.Location = new System.Drawing.Point(0, 33);
            this.childpanel.Name = "childpanel";
            this.childpanel.Size = new System.Drawing.Size(800, 325);
            this.childpanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.manageUserBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.addRestBtn);
            this.panel1.Controls.Add(this.showRestBtn);
            this.panel1.Controls.Add(this.showUsersBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 1;
            // 
            // manageUserBtn
            // 
            this.manageUserBtn.FlatAppearance.BorderSize = 0;
            this.manageUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUserBtn.ForeColor = System.Drawing.Color.Maroon;
            this.manageUserBtn.Location = new System.Drawing.Point(482, 6);
            this.manageUserBtn.Name = "manageUserBtn";
            this.manageUserBtn.Size = new System.Drawing.Size(113, 23);
            this.manageUserBtn.TabIndex = 5;
            this.manageUserBtn.Text = "Manage users";
            this.manageUserBtn.UseVisualStyleBackColor = true;
            this.manageUserBtn.Click += new System.EventHandler(this.manageUserBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Maroon;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(722, 6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "SIGN OUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // addRestBtn
            // 
            this.addRestBtn.FlatAppearance.BorderSize = 0;
            this.addRestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRestBtn.ForeColor = System.Drawing.Color.Maroon;
            this.addRestBtn.Location = new System.Drawing.Point(363, 6);
            this.addRestBtn.Name = "addRestBtn";
            this.addRestBtn.Size = new System.Drawing.Size(113, 23);
            this.addRestBtn.TabIndex = 3;
            this.addRestBtn.Text = "Add restaurant";
            this.addRestBtn.UseVisualStyleBackColor = true;
            this.addRestBtn.Click += new System.EventHandler(this.addRestBtn_Click);
            // 
            // showRestBtn
            // 
            this.showRestBtn.FlatAppearance.BorderSize = 0;
            this.showRestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRestBtn.ForeColor = System.Drawing.Color.Maroon;
            this.showRestBtn.Location = new System.Drawing.Point(226, 6);
            this.showRestBtn.Name = "showRestBtn";
            this.showRestBtn.Size = new System.Drawing.Size(131, 23);
            this.showRestBtn.TabIndex = 2;
            this.showRestBtn.Text = "Show all restaurants";
            this.showRestBtn.UseVisualStyleBackColor = true;
            this.showRestBtn.Click += new System.EventHandler(this.showRestBtn_Click);
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showUsersBtn.FlatAppearance.BorderSize = 0;
            this.showUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showUsersBtn.ForeColor = System.Drawing.Color.Maroon;
            this.showUsersBtn.Location = new System.Drawing.Point(113, 7);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(107, 23);
            this.showUsersBtn.TabIndex = 1;
            this.showUsersBtn.Text = "Show all users";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            this.showUsersBtn.Click += new System.EventHandler(this.showUsersBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.Maroon;
            this.resetBtn.Location = new System.Drawing.Point(3, 7);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(104, 23);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset database";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.botPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button addRestBtn;
        private System.Windows.Forms.Button showRestBtn;
        private System.Windows.Forms.Button showUsersBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button manageUserBtn;
        private System.Windows.Forms.Panel childpanel;
    }
}