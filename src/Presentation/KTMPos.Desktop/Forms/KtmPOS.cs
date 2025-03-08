using KTMPos.Desktop.Forms.ChildForms.InventoryModule;
using Microsoft.Extensions.DependencyInjection;
using System.DirectoryServices;
using System.Runtime.CompilerServices;

namespace KTMPos.Desktop.Forms
{
    public partial class KtmPOS : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private int _userId = 0;
        public KtmPOS(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _serviceProvider = serviceProvider;
        }
        public void SetUserId(int userId)
        {
            _userId = userId;
        }
        public int GetUserId { get { return _userId; } }

        private void exitToolStripMenuItem_Clicl(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<CategoryForm>();
        }

        private void OpenChildForm<T>()
        {
            foreach (var children in MdiChildren)
            {
                children.Close();
            }
            //reference type maa cast garna ko laagi chai "as" keyword use gareko this is important remember this topic
            var childForm = _serviceProvider.GetRequiredService<T>() as Form;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.ControlBox = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }
    }
}
