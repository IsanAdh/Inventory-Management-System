using KTMPos.BAL.Services.Login;
using Microsoft.Extensions.DependencyInjection;

namespace KTMPos.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILoginServices _loginServices;
        public LoginForm(IServiceProvider serviceProvider,ILoginServices loginServices)
        {
            _serviceProvider = serviceProvider;
            _loginServices = loginServices;
            InitializeComponent();
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            this.AcceptButton = btnLogin;
            txtUserName.Focus();
            txtUserName.TabIndex = 1;
            txtPassword.TabIndex = 2;
            btnLogin.TabIndex = 3;
            btnCancel.TabIndex = 4;
            txtPassword.PasswordChar = '*';
            txtPassword.ShortcutsEnabled = false;
        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async Task LoginAsync()
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password is missing.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int userId = await _loginServices.LoginAsync(userName, password);
            if (userId>0)
            {
                var ktmForm = _serviceProvider.GetRequiredService<KtmPOS>();
                ktmForm.SetUserId(userId);
                ktmForm.Show();
                this.Hide();
                
            }



            txtUserName.Clear();
            txtPassword.Clear();
            this.Hide();


           // MessageBox.Show("Invalid username or password.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
