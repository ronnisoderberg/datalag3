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
    public partial class RestaurantForm : Form
    {
        private Form form;
        private DbContextOptions options;
        private Restaurant restaurant;
        public RestaurantForm(Restaurant restaurant, DbContextOptions options)
        {
            this.restaurant = restaurant;
            this.options = options;
            InitializeComponent();
            label2.Text = Helper.GreetRestaurant(restaurant);
            addboxPanel.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form = new FoodRescueForm();
            this.Close();
            form.Show();
        }

        private void soldboxesBtn_Click(object sender, EventArgs e)
        {
            addboxPanel.Hide();
            var restaurantBackend = new RestaurantBackend(options);

            var soldboxes = restaurantBackend.GetSoldFoodpacks(restaurant.Id);
            listBox1.Items.Clear();
            listBox1.Items.Add("\t\t---------------SOLD BOXES-------------");
            //listBox1.DataSource = soldboxes;
            foreach (var VARIABLE in soldboxes)
            {
                listBox1.Items.Add($"ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}  ||  Sold at: {VARIABLE.Order.OrderDate.ToShortDateString()}");
            }
        }

        private void unsoldFoodpacks_Click(object sender, EventArgs e)
        {
            addboxPanel.Hide();
            var restaurantBackend = new RestaurantBackend(options);

            var unsoldboxes = restaurantBackend.GetUnSoldFoodpacks(restaurant.Id);

            listBox1.Items.Clear();
            listBox1.Items.Add("\t\t---------------UNSOLD BOXES-------------");
            foreach (var VARIABLE in unsoldboxes)
            {
                listBox1.Items.Add($"Foodpack ID: {VARIABLE.Id}  ||  Name: {VARIABLE.Description}  ||  Price: {VARIABLE.Price}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            addboxPanel.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int price = 0;
            DateTime expdate = dateTimePicker1.Value;
            int restaurant = this.restaurant.Id;
            if (!int.TryParse(priceTxtbox.Text, out price))
            {
                MessageBox.Show("The price that you entered is not valid. Try again");
                priceTxtbox.Clear();
                return;
            }
            if (string.IsNullOrEmpty(mealnameTxtbox.Text))
            {
                MessageBox.Show("The meal name that you entered is not valid. Try again");
                mealnameTxtbox.Clear();
                return;
            }
            string name = mealnameTxtbox.Text;

            if (categoryCombobox.Text == "Pick a category")
            {
                MessageBox.Show("The category that you picked is not valid. Try again");
                return;
            }
            string category = categoryCombobox.Text;
            RestaurantBackend restaurantBackend = new RestaurantBackend(options);
            restaurantBackend.AddFoodpack(price,expdate,name,restaurant,category);

            mealnameTxtbox.Clear();
            priceTxtbox.Clear();

            MessageBox.Show("Foodpack added!");

        }
    }
}
