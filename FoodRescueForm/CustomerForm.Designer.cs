namespace FoodRescueForm
{
    partial class CustomerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.showoubhtmealBtn = new System.Windows.Forms.Button();
            this.buyAmealBtn = new System.Windows.Forms.Button();
            this.availiblePacksBtn = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.selectMealBtn = new System.Windows.Forms.Button();
            this.categorymeatBtn = new System.Windows.Forms.Button();
            this.categoryfishBtn = new System.Windows.Forms.Button();
            this.categoryveggieBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "                          ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.signoutBtn);
            this.panel2.Controls.Add(this.showoubhtmealBtn);
            this.panel2.Controls.Add(this.buyAmealBtn);
            this.panel2.Controls.Add(this.availiblePacksBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 358);
            this.panel2.TabIndex = 1;
            // 
            // signoutBtn
            // 
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signoutBtn.ForeColor = System.Drawing.Color.Gray;
            this.signoutBtn.Location = new System.Drawing.Point(36, 266);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(144, 52);
            this.signoutBtn.TabIndex = 3;
            this.signoutBtn.Text = "SIGN OUT";
            this.signoutBtn.UseVisualStyleBackColor = true;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // showoubhtmealBtn
            // 
            this.showoubhtmealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showoubhtmealBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showoubhtmealBtn.ForeColor = System.Drawing.Color.Gray;
            this.showoubhtmealBtn.Location = new System.Drawing.Point(36, 194);
            this.showoubhtmealBtn.Name = "showoubhtmealBtn";
            this.showoubhtmealBtn.Size = new System.Drawing.Size(144, 52);
            this.showoubhtmealBtn.TabIndex = 2;
            this.showoubhtmealBtn.Text = "SHOW MY BOUGHT MEALS";
            this.showoubhtmealBtn.UseVisualStyleBackColor = true;
            this.showoubhtmealBtn.Click += new System.EventHandler(this.showoubhtmealBtn_Click);
            // 
            // buyAmealBtn
            // 
            this.buyAmealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyAmealBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buyAmealBtn.ForeColor = System.Drawing.Color.Gray;
            this.buyAmealBtn.Location = new System.Drawing.Point(36, 118);
            this.buyAmealBtn.Name = "buyAmealBtn";
            this.buyAmealBtn.Size = new System.Drawing.Size(144, 52);
            this.buyAmealBtn.TabIndex = 1;
            this.buyAmealBtn.Text = "BUY A FOODBOX";
            this.buyAmealBtn.UseVisualStyleBackColor = true;
            this.buyAmealBtn.Click += new System.EventHandler(this.buyAmealBtn_Click);
            // 
            // availiblePacksBtn
            // 
            this.availiblePacksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availiblePacksBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availiblePacksBtn.ForeColor = System.Drawing.Color.Gray;
            this.availiblePacksBtn.Location = new System.Drawing.Point(36, 45);
            this.availiblePacksBtn.Name = "availiblePacksBtn";
            this.availiblePacksBtn.Size = new System.Drawing.Size(144, 52);
            this.availiblePacksBtn.TabIndex = 0;
            this.availiblePacksBtn.Text = "LOAD AVAILABLE BOXES";
            this.availiblePacksBtn.UseVisualStyleBackColor = true;
            this.availiblePacksBtn.Click += new System.EventHandler(this.availiblePacksBtn_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.White;
            this.categoryLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.ForeColor = System.Drawing.Color.Gray;
            this.categoryLabel.Location = new System.Drawing.Point(253, 149);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(157, 23);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "                     ";
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.BackColor = System.Drawing.Color.White;
            this.choiceLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choiceLabel.ForeColor = System.Drawing.Color.Gray;
            this.choiceLabel.Location = new System.Drawing.Point(268, 106);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(252, 28);
            this.choiceLabel.TabIndex = 6;
            this.choiceLabel.Text = "                              ";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.Gray;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(291, 249);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(391, 146);
            this.listBox2.TabIndex = 7;
            // 
            // selectMealBtn
            // 
            this.selectMealBtn.BackColor = System.Drawing.Color.White;
            this.selectMealBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectMealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMealBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectMealBtn.ForeColor = System.Drawing.Color.Gray;
            this.selectMealBtn.Location = new System.Drawing.Point(397, 401);
            this.selectMealBtn.Name = "selectMealBtn";
            this.selectMealBtn.Size = new System.Drawing.Size(172, 34);
            this.selectMealBtn.TabIndex = 9;
            this.selectMealBtn.Text = "SELECT MEAL";
            this.selectMealBtn.UseVisualStyleBackColor = false;
            this.selectMealBtn.Click += new System.EventHandler(this.selectMealBtn_Click);
            // 
            // categorymeatBtn
            // 
            this.categorymeatBtn.BackColor = System.Drawing.Color.White;
            this.categorymeatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categorymeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorymeatBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorymeatBtn.Location = new System.Drawing.Point(291, 200);
            this.categorymeatBtn.Name = "categorymeatBtn";
            this.categorymeatBtn.Size = new System.Drawing.Size(112, 30);
            this.categorymeatBtn.TabIndex = 10;
            this.categorymeatBtn.Text = "MEAT";
            this.categorymeatBtn.UseVisualStyleBackColor = false;
            this.categorymeatBtn.Click += new System.EventHandler(this.categorymeatBtn_Click);
            // 
            // categoryfishBtn
            // 
            this.categoryfishBtn.BackColor = System.Drawing.Color.White;
            this.categoryfishBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoryfishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryfishBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryfishBtn.Location = new System.Drawing.Point(424, 200);
            this.categoryfishBtn.Name = "categoryfishBtn";
            this.categoryfishBtn.Size = new System.Drawing.Size(112, 30);
            this.categoryfishBtn.TabIndex = 11;
            this.categoryfishBtn.Text = "FISH";
            this.categoryfishBtn.UseVisualStyleBackColor = false;
            this.categoryfishBtn.Click += new System.EventHandler(this.categoryfishBtn_Click);
            // 
            // categoryveggieBtn
            // 
            this.categoryveggieBtn.BackColor = System.Drawing.Color.White;
            this.categoryveggieBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoryveggieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryveggieBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryveggieBtn.Location = new System.Drawing.Point(570, 200);
            this.categoryveggieBtn.Name = "categoryveggieBtn";
            this.categoryveggieBtn.Size = new System.Drawing.Size(112, 30);
            this.categoryveggieBtn.TabIndex = 12;
            this.categoryveggieBtn.Text = "FISH";
            this.categoryveggieBtn.UseVisualStyleBackColor = false;
            this.categoryveggieBtn.Click += new System.EventHandler(this.categoryveggieBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryveggieBtn);
            this.Controls.Add(this.categoryfishBtn);
            this.Controls.Add(this.categorymeatBtn);
            this.Controls.Add(this.selectMealBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signoutBtn;
        private System.Windows.Forms.Button showoubhtmealBtn;
        private System.Windows.Forms.Button buyAmealBtn;
        private System.Windows.Forms.Button availiblePacksBtn;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button selectMealBtn;
        private System.Windows.Forms.Button categorymeatBtn;
        private System.Windows.Forms.Button categoryfishBtn;
        private System.Windows.Forms.Button categoryveggieBtn;
    }
}