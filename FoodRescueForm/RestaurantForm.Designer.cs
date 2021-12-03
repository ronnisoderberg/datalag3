namespace FoodRescueForm
{
    partial class RestaurantForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addboxPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mealnameTxtbox = new System.Windows.Forms.TextBox();
            this.priceTxtbox = new System.Windows.Forms.TextBox();
            this.labelcategory = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelDatetime = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.unsoldFoodpacks = new System.Windows.Forms.Button();
            this.soldboxesBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addboxPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.addboxPanel);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(213, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 358);
            this.panel1.TabIndex = 1;
            // 
            // addboxPanel
            // 
            this.addboxPanel.BackColor = System.Drawing.Color.White;
            this.addboxPanel.Controls.Add(this.label3);
            this.addboxPanel.Controls.Add(this.categoryCombobox);
            this.addboxPanel.Controls.Add(this.button1);
            this.addboxPanel.Controls.Add(this.dateTimePicker1);
            this.addboxPanel.Controls.Add(this.mealnameTxtbox);
            this.addboxPanel.Controls.Add(this.priceTxtbox);
            this.addboxPanel.Controls.Add(this.labelcategory);
            this.addboxPanel.Controls.Add(this.labelname);
            this.addboxPanel.Controls.Add(this.labelDatetime);
            this.addboxPanel.Controls.Add(this.labelprice);
            this.addboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addboxPanel.Location = new System.Drawing.Point(0, 0);
            this.addboxPanel.Name = "addboxPanel";
            this.addboxPanel.Size = new System.Drawing.Size(587, 358);
            this.addboxPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(138, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add a foodpack";
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.Items.AddRange(new object[] {
            "Fish",
            "Meat",
            "Veggie"});
            this.categoryCombobox.Location = new System.Drawing.Point(171, 194);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(147, 23);
            this.categoryCombobox.TabIndex = 4;
            this.categoryCombobox.Text = "Pick a category";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(171, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "ADD PACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // mealnameTxtbox
            // 
            this.mealnameTxtbox.Location = new System.Drawing.Point(170, 86);
            this.mealnameTxtbox.Name = "mealnameTxtbox";
            this.mealnameTxtbox.Size = new System.Drawing.Size(167, 23);
            this.mealnameTxtbox.TabIndex = 1;
            // 
            // priceTxtbox
            // 
            this.priceTxtbox.Location = new System.Drawing.Point(171, 121);
            this.priceTxtbox.Name = "priceTxtbox";
            this.priceTxtbox.Size = new System.Drawing.Size(167, 23);
            this.priceTxtbox.TabIndex = 2;
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcategory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelcategory.Location = new System.Drawing.Point(78, 192);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(76, 21);
            this.labelcategory.TabIndex = 3;
            this.labelcategory.Text = "Category:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelname.Location = new System.Drawing.Point(77, 88);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(87, 21);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Meal name";
            // 
            // labelDatetime
            // 
            this.labelDatetime.AutoSize = true;
            this.labelDatetime.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatetime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelDatetime.Location = new System.Drawing.Point(77, 157);
            this.labelDatetime.Name = "labelDatetime";
            this.labelDatetime.Size = new System.Drawing.Size(88, 21);
            this.labelDatetime.TabIndex = 1;
            this.labelDatetime.Text = "Expire Date";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelprice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelprice.Location = new System.Drawing.Point(78, 123);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(44, 21);
            this.labelprice.TabIndex = 0;
            this.labelprice.Text = "Price";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 358);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.unsoldFoodpacks);
            this.panel2.Controls.Add(this.soldboxesBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 358);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(39, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "LOG OUT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(39, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADD FOODPACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // unsoldFoodpacks
            // 
            this.unsoldFoodpacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unsoldFoodpacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unsoldFoodpacks.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unsoldFoodpacks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.unsoldFoodpacks.Location = new System.Drawing.Point(39, 112);
            this.unsoldFoodpacks.Name = "unsoldFoodpacks";
            this.unsoldFoodpacks.Size = new System.Drawing.Size(128, 47);
            this.unsoldFoodpacks.TabIndex = 1;
            this.unsoldFoodpacks.Text = "UNSOLD FOODPACKS";
            this.unsoldFoodpacks.UseVisualStyleBackColor = true;
            this.unsoldFoodpacks.Click += new System.EventHandler(this.unsoldFoodpacks_Click);
            // 
            // soldboxesBtn
            // 
            this.soldboxesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soldboxesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldboxesBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soldboxesBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.soldboxesBtn.Location = new System.Drawing.Point(39, 37);
            this.soldboxesBtn.Name = "soldboxesBtn";
            this.soldboxesBtn.Size = new System.Drawing.Size(128, 47);
            this.soldboxesBtn.TabIndex = 0;
            this.soldboxesBtn.Text = "SOLD FOODPACKS";
            this.soldboxesBtn.UseVisualStyleBackColor = true;
            this.soldboxesBtn.Click += new System.EventHandler(this.soldboxesBtn_Click);
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.addboxPanel.ResumeLayout(false);
            this.addboxPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button unsoldFoodpacks;
        private System.Windows.Forms.Button soldboxesBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel addboxPanel;
        private System.Windows.Forms.TextBox mealnameTxtbox;
        private System.Windows.Forms.TextBox priceTxtbox;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelDatetime;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.Label label3;
    }
}