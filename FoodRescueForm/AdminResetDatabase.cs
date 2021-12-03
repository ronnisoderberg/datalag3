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
using Microsoft.EntityFrameworkCore;

namespace FoodRescueForm
{
    public partial class AdminResetDatabase : Form
    {
        private string testConnectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext";
        private string liveConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackLiveDbContext";
        public AdminResetDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbContextOptionsBuilder op = new DbContextOptionsBuilder();
            op.UseSqlServer(testConnectionstring);
            DialogResult confirm = MessageBox.Show("Are you sure you want to reset the test database?",
                "DATABSE RESET", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Database database = new Database(op.Options);
                database.PrepDatabase();
                database.SeedTestData();
                MessageBox.Show("The test data has been succesfully reset.");
                this.Close();
            }

            if (confirm == DialogResult.No)
            {
                MessageBox.Show("The test data has not been reset");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbContextOptionsBuilder op = new DbContextOptionsBuilder();
            op.UseSqlServer(liveConnectionString);
            DialogResult confirm = MessageBox.Show("Are you sure you want to reset the live database?",
                "DATABASE RESET", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Database database = new Database(op.Options);
                database.PrepDatabase();
                database.SeedTestData();
                MessageBox.Show("The live data has been succesfully reset.");
                this.Close();
            }

            if (confirm == DialogResult.No)
            {
                MessageBox.Show("The live data has not been reset");
            }
        }
    }
}
