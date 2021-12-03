using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Model;
using MainProgramForm;
using Microsoft.EntityFrameworkCore;

namespace FoodRescueForm
{
    public partial class AdminForm : Form
    {
        private Form form;
        private DbContextOptions options;
        public AdminForm(User user, DbContextOptions options)
        {
            this.options = options;
            InitializeComponent();
            label2.Text = Helper.GreetAdmin();
        }

        private void OpenChildForm(Form childForm)
        {
            if (form != null)
            {
                form.Close();
            }

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childpanel.Controls.Add(childForm);
            childpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form = new FoodRescueForm();
            form.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form = new FoodRescueForm();
            form.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AdminResetDatabase());
            
        }

        private void showUsersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminShowUsers(options));

        }

        private void showRestBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminShowRestaurants(options));
        }

        private void addRestBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAddRestaurant(options));
        }

        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not today");
        }
    }
}
