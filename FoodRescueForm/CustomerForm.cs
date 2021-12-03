using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using MainProgramForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FoodRescueForm
{
    public partial class CustomerForm : Form
    {
        private Form form;
        private User user;
        private DbContextOptions options;
        public CustomerForm(User user, DbContextOptions options)
        {
            this.options = options;
            this.user = user;
            InitializeComponent();
            label2.Text = Helper.GreetCustomer(user);
            categoryfishBtn.Hide();
            categorymeatBtn.Hide();
            categoryveggieBtn.Hide();
            selectMealBtn.Hide();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            form = new FoodRescueForm();
            this.Close();
            form.Show();
        }

        private void availiblePacksBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            choiceLabel.Text = "Get available foodpacks to buy";
            categoryLabel.Text = "Please pick category";
            categoryfishBtn.Show();
            categorymeatBtn.Show();
            categoryveggieBtn.Show();
            selectMealBtn.Hide();
            //var unsoldbox = userBackend.GetFoodpackages();

        }

        private void buyAmealBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            selectMealBtn.Show();

        }

        private void showMealsBtn_Click(object sender, EventArgs e)
        {
        }

        private void categorymeatBtn_Click(object sender, EventArgs e)
        {
            string category = "meat";
            listBox2.Items.Clear();

            var userBackend = new UserBackend(options);

            var list = userBackend.GetFoodpackages(category);

            listBox2.Items.Add("-----------Available Foodpacks----------");
            listBox2.Items.Add("Category: Meat");

            if (list.Count > 0)
            {
                foreach (var VARIABLE in list)
                {
                    listBox2.Items.Add(
                        $"Foodpack ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}");

                }
            }
            else
            {
                listBox2.Items.Add("No foodpacks to show");
            }
        }

        private void categoryveggieBtn_Click(object sender, EventArgs e)
        {
            string category = "veggie";
            listBox2.Items.Clear();


            var userBackend = new UserBackend(options);

            var list = userBackend.GetFoodpackages(category);

            listBox2.Items.Add("-----------Available Foodpacks----------");
            listBox2.Items.Add("Category: Veggie");

            if (list.Count > 0)
            {
                foreach (var VARIABLE in list)
                {
                    listBox2.Items.Add(
                        $"Foodpack ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}");

                }
            }
            else
            {
                listBox2.Items.Add("No foodpacks to show");
            }
        }

        private void categoryfishBtn_Click(object sender, EventArgs e)
        {
            string category = "fish";
            listBox2.Items.Clear();

            var userBackend = new UserBackend(options);
          
            var list = userBackend.GetFoodpackages(category);
            listBox2.Items.Add("-----------Available Foodpacks----------");
            listBox2.Items.Add("Category: Fish");
            if (list.Count > 0)
            {
                foreach (var VARIABLE in list)
                {
                    listBox2.Items.Add(
                        $"Foodpack ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}");

                }
            }
            else
            {
                listBox2.Items.Add("No foodpacks to show");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void selectMealBtn_Click(object sender, EventArgs e)
        {
            selectMealBtn.Show();

            var selected = listBox2.SelectedItem.ToString();

            if (!selected.Any(char.IsDigit))
            {
                    MessageBox.Show("You did not pick a valid foodbox. Try again.");
                
            }


            var sub = selected.Substring(selected.IndexOf(':')+2);
            var sub2 = Convert.ToInt32(sub.Substring(0,sub.IndexOf(' ')));
            
            if (sub2 != null)
            {
                RestaurantBackend restaurantBackend = new RestaurantBackend(options);
                Foodpackage meal = null;
                using (var ctx = new FoodpackDbContext(options))
                {
                    meal = ctx.Foodpackages.FirstOrDefault(x => x.Id == sub2);
                };

                if (meal != null)
                {
                    List<Foodpackage> f = new List<Foodpackage>()
                    {
                        meal

                    };

                    restaurantBackend.BuyFoodpack(f, user);
                    MessageBox.Show("Thank you for your order!");
                    listBox2.Items.Clear();
                }

            }
        }

        private void showoubhtmealBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            categoryfishBtn.Hide();
            categorymeatBtn.Hide();
            categoryveggieBtn.Hide();
            selectMealBtn.Hide();

            var userBackend = new UserBackend(options);
            var list = userBackend.GetFoodpackagesForCostummer(user.Id);

            listBox2.Items.Add("-----------Foodpacks you have bought----------");

            if (list.Count > 0)
            {
                foreach (var VARIABLE in list)
                {
                    listBox2.Items.Add(
                        $"Foodpack ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}");

                }
            }
        }
    }
}
