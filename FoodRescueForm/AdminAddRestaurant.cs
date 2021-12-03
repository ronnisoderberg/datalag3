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
using Microsoft.EntityFrameworkCore;

namespace FoodRescueForm
{
    public partial class AdminAddRestaurant : Form
    {
        private DbContextOptions options;
        public AdminAddRestaurant(DbContextOptions options)
        {
            this.options = options;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text;
            string phone = numbertextbox.Text;

            if (name == null || name == "")
            {
                MessageBox.Show("Invalid restaurant name, try again");
                return;
            }

            AdminBackend adminBackend = new AdminBackend(options);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this restaurant?", "Confirm",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                adminBackend.AddRestaurant(name, phone);
                nametextbox.Clear();
                numbertextbox.Clear();
                MessageBox.Show("Restaurant has been added!");

            }

            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Restaurant has not been added!");
                nametextbox.Clear();
                numbertextbox.Clear();
                return;
            }

        }
    }
}
