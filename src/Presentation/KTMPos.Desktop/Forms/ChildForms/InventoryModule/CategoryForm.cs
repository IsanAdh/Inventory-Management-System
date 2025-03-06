using KTMPos.BAL.Services.CategoryServices;
using KTMPos.Common.Dto;

namespace KTMPos.Desktop.Forms.ChildForms.InventoryModule
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;
        public CategoryForm(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
            InitializeFormComponent();
        }

        private void InitializeFormComponent()
        {
            txtCategoryName.Focus();
            txtCategoryName.TabIndex = 0;
            btnSave.TabIndex = 1;
            btnCancel.TabIndex = 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void ResetControl()
        {
            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();

            if (String.IsNullOrEmpty(name))
            {
                lblCategoryNameError.Visible = true;
            }
            else
            {
                lblCategoryNameError.Visible = false;
            }
            if (String.IsNullOrEmpty(name))
            {
                return;
            }
            var categoryWrite = new CategoryWriteDto
            {
                Name = name,
            };
            await _categoryService.SaveAsync(categoryWrite);
            await LoadAllCategoriesAsync();
            MessageBox.Show("Category saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetControl();
        }
        private async Task LoadCategoryGridAsync()
        {
            dvgCategory.AutoGenerateColumns = false;
            dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "IdColumn",
                HeaderText = "Id",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(CategoryReadDto.Id),
            });
            dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "NameColumn",
                HeaderText = "Name",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(CategoryReadDto.Name),
            });
            await LoadAllCategoriesAsync();
        }

        private async Task LoadAllCategoriesAsync()
        {
            dvgCategory.DataSource = await _categoryService.GetAllAsync();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            await LoadCategoryGridAsync();
        }
    }


}
