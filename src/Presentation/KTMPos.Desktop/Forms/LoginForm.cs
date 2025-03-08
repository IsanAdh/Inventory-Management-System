using KTMPos.BAL.Services.Login;
using KTMPos.Common.Enums;
using KTMPos.Desktop.Utilities;
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

            var result = await _loginServices.LoginAsync(userName, password);
            if(result.Status==Status.Success)
            {
                int userId = result.Data.Select(x => x.Id).FirstOrDefault();
                if (userId > 0)
                {
                    var ktmForm = _serviceProvider.GetRequiredService<KtmPOS>();
                    ktmForm.SetUserId(userId);
                    ktmForm.Show();
                    this.Hide();
                } 
            }
            else
            {
                DialogMessage.ShowFailureAlert("Invalid Login","Invalid Username or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
