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
using Microsoft.Extensions.Options;

namespace FoodRescueForm
{
    public partial class AdminShowRestaurants : Form
    {
        private DbContextOptions options;
        public AdminShowRestaurants(DbContextOptions options)
        {
            this.options = options;
            InitializeComponent();
        }

        private void AdminShowRestaurants_Load(object sender, EventArgs e)

        {
            UserBackend userBackend = new UserBackend(options);
            var restaurants = userBackend.GetRestaurants();
            restaurantsListBox.Items.Clear();

            foreach (var rest in restaurants)
            {
                restaurantsListBox.Items.Add($"Restaurant ID: {rest.Id}  ||  Name: {rest.Name} || Phonenumber: " + (string.IsNullOrEmpty(rest.Phonenumber)? "No number registered": rest.Phonenumber));
            }

        }
    }
}
