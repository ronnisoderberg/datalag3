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
    public partial class AdminShowUsers : Form
    {
        private DbContextOptions options;
        public AdminShowUsers(DbContextOptions options)
        {
            this.options = options;
            InitializeComponent();
        }

        private void AdminShowUsers_Load(object sender, EventArgs e)
        {
            AdminBackend adminBackend = new AdminBackend(options);
            var users = adminBackend.GetAllCostumers();
            usersListbox.Items.Clear();


            foreach (var user in users)
            {
             usersListbox.Items.Add($"User ID: {user.Id}  ||  Name: {user.Name} || Username: {user.Username}");
            }


        }
    }
}
