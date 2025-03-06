using KTMPos.Desktop.Forms.ChildForms.InventoryModule;
using Microsoft.Extensions.DependencyInjection;
using System.DirectoryServices;

namespace KTMPos.Desktop.Forms
{
    public partial class KtmPOS : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public KtmPOS(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _serviceProvider = serviceProvider;
        }

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
