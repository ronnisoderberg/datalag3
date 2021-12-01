namespace FoodPackSeller
{
    public partial class LoginForm : Form
    {
        private Form currentChildForm;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            menuLabel.Text = childForm.Text;
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignInForm());
        }
    }
}