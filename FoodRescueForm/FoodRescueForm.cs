using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataLayer.Backend;
using DataLayer.Model;

namespace FoodRescueForm
{
    public partial class FoodRescueForm : Form
    {
        private DbContextOptions options;
        private Form currentChildForm;
        public FoodRescueForm()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");
            options = optionsBuilder.Options;
            Database database = new Database(options);
            database.PrepDatabase();
            database.SeedTestData();
            InitializeComponent();
            eyepicturebox.Hide();

        }
        private void OpenChildForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_Click(object sender, EventArgs e)
        {
            usernameTextbox.BackColor = Color.White;
            signinPanel1.BackColor = Color.White;

            signinPanel2.BackColor = SystemColors.Control;
            passwordTextbox.BackColor = SystemColors.Control;
        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            eyepicturebox.Show();
            passwordTextbox.BackColor = Color.White;
            signinPanel2.BackColor = Color.White;

            usernameTextbox.BackColor = SystemColors.Control;
            signinPanel1.BackColor = SystemColors.Control;
        }

        private void eyepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = false;
        }

        private void eyepicturebox_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void forgotpwBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot do this for you yet =(");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username/password is incorrect or user does not exist");
                passwordTextbox.Clear();
                return;
            }

            var restaurantBackend = new RestaurantBackend(options);
            Login login = new Login(options);
            User user = login.TryLogin(username, password);
            UserAcces check;
            if (user == null)
            {
                MessageBox.Show("Username/password is incorrect or user does not exist");
                passwordTextbox.Clear();
                return;

            }

            check = login.CheckUserAcces(user);


            switch (check)
            {
                case UserAcces.Admin:
                    OpenChildForm(new AdminForm(user, options));
                    break;
                case UserAcces.Manager:
                    var restaurant = restaurantBackend.GetRestaurant(user.Id);
                   OpenChildForm(new RestaurantForm(restaurant, options));
                    break;
                case UserAcces.Customer:
                   OpenChildForm(new CustomerForm(user, options));
                    break;
                default:
                    break;
            }
            //(login.CheckUserAcces(user) == UserAcces.Manager)

        }

        private void FoodRescueForm_Enter(object sender, EventArgs e)
        {
            loginBtn_Click(sender,e);
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }
    }

}


