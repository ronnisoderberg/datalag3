namespace FoodRescueForm
{
    partial class AdminShowUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxPanel = new System.Windows.Forms.Panel();
            this.usersListbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.listboxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL USERS";
            // 
            // listboxPanel
            // 
            this.listboxPanel.Controls.Add(this.usersListbox);
            this.listboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxPanel.Location = new System.Drawing.Point(0, 66);
            this.listboxPanel.Name = "listboxPanel";
            this.listboxPanel.Size = new System.Drawing.Size(800, 384);
            this.listboxPanel.TabIndex = 2;
            // 
            // usersListbox
            // 
            this.usersListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersListbox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersListbox.ForeColor = System.Drawing.Color.Maroon;
            this.usersListbox.FormattingEnabled = true;
            this.usersListbox.ItemHeight = 21;
            this.usersListbox.Location = new System.Drawing.Point(0, 0);
            this.usersListbox.Name = "usersListbox";
            this.usersListbox.Size = new System.Drawing.Size(800, 384);
            this.usersListbox.TabIndex = 1;
            // 
            // AdminShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listboxPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminShowUsers";
            this.Text = "AdminShowUsers";
            this.Load += new System.EventHandler(this.AdminShowUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.listboxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listboxPanel;
        private System.Windows.Forms.ListBox usersListbox;
    }
}