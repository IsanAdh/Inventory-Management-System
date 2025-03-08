using KTMPos.BAL.Services.CategoryServices;
using KTMPos.Common.Constants;
using KTMPos.Common.Dto;

namespace KTMPos.Desktop.Forms.ChildForms.InventoryModule
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;
        private int _userId;
        private int _categoryId;
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
            _categoryId = 0;
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
            if (!String.IsNullOrEmpty(name))
            {
                var categoryInsert = new CategoryInsertDto
                {
                    Name = name,
                    CreatedBy = _userId,
                };
                await _categoryService.SaveAsync(categoryInsert);
                await OnSuccessAsync("saved");
            }
        }

        private async Task OnSuccessAsync(string label)
        {
            await LoadAllCategoriesAsync();
            MessageBox.Show($"Category {label} Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetControl();
        }

        private async Task LoadCategoryGridAsync()
        {
            dvgCategory.AutoGenerateColumns = false;
            dvgCategory.ReadOnly = true;
            dvgCategory.RowHeadersVisible = false;
            dvgCategory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = Constant.Sn,
                HeaderText = "S.N.",
            });
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
            dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "CreatedByColumn",
                HeaderText = "Created By",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(CategoryReadDto.CreatedBy),
            }); dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "CreatedDateColumn",
                HeaderText = "Created Date",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(CategoryReadDto.CreatedDate),
            });
            dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "LastModifiedByColumn",
                HeaderText = "Last Modified By",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(CategoryReadDto.LastModifiedBy),
            });
            dvgCategory.Columns.Add(new DataGridViewColumn
            {
                Name = "LastModifiedDateColumn",
                HeaderText = "last Modified Date",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 200,
                DataPropertyName = nameof(CategoryReadDto.LastModifiedDate),
            });

            await LoadAllCategoriesAsync();

        }

        private void UpdateSerialNumber()
        {
            for (int i = 0; i < dvgCategory.Rows.Count; i++)
            {
                dvgCategory.Rows[i].Cells[Constant.Sn].Value = i + 1;
            }
        }

        private async Task LoadAllCategoriesAsync()
        {
            dvgCategory.DataSource = await _categoryService.GetAllAsync();
            UpdateSerialNumber();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            //pattern matching code . paila MdiParent ho ki haina check garcha ani ho bhane cast pani garcha 
            if (MdiParent is KtmPOS mainForm)
            {
                _userId = mainForm.GetUserId;
            }
            await LoadCategoryGridAsync();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_categoryId > 0)
            {
                string name = txtCategoryName.Text.Trim();
                if (!String.IsNullOrEmpty(name))
                {
                    var categoryUpdate = new CategoryUpdateDto
                    {
                        Id = _categoryId,
                        Name = name,
                        CreatedBy=_userId,

                    };
                    await _categoryService.UpdateAsync(categoryUpdate);
                    await OnSuccessAsync("updated");
                }
            }
            else
            {
                MessageBox.Show("No category selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_categoryId > 0)
            {
                await _categoryService.DeleteAsync(_categoryId);
                await OnSuccessAsync("deleted");
            }
            else
            {
                MessageBox.Show("No category selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _categoryId=(int)dvgCategory.CurrentRow.Cells["IdColumn"].Value;
            txtCategoryName.Text = dvgCategory.CurrentRow.Cells["NameColumn"].Value.ToString();
        }
    }


}
