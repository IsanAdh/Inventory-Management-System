namespace KTMPos.Desktop.Forms.ChildForms.InventoryModule
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategoryHeader = new Label();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            dvgCategory = new DataGridView();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnDelete = new Button();
            btnCancel = new Button();
            lblCategoryNameError = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgCategory).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryHeader
            // 
            lblCategoryHeader.Anchor = AnchorStyles.Top;
            lblCategoryHeader.AutoSize = true;
            lblCategoryHeader.Location = new Point(413, 7);
            lblCategoryHeader.Name = "lblCategoryHeader";
            lblCategoryHeader.Size = new Size(129, 15);
            lblCategoryHeader.TabIndex = 0;
            lblCategoryHeader.Text = "Category Management";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(24, 38);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(42, 15);
            lblCategoryName.TabIndex = 1;
            lblCategoryName.Text = "Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(75, 37);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(174, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(29, 76);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save (F2)";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(902, 4);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit (F10)";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dvgCategory
            // 
            dvgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCategory.Location = new Point(29, 137);
            dvgCategory.Margin = new Padding(3, 2, 3, 2);
            dvgCategory.Name = "dvgCategory";
            dvgCategory.RowHeadersWidth = 51;
            dvgCategory.Size = new Size(965, 229);
            dvgCategory.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 17);
            btnUpdate.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(861, 112);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(132, 23);
            txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(809, 115);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 17);
            btnDelete.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(367, 76);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel (F3)";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCategoryNameError
            // 
            lblCategoryNameError.AutoSize = true;
            lblCategoryNameError.ForeColor = Color.Red;
            lblCategoryNameError.Location = new Point(255, 40);
            lblCategoryNameError.Name = "lblCategoryNameError";
            lblCategoryNameError.Size = new Size(97, 15);
            lblCategoryNameError.TabIndex = 11;
            lblCategoryNameError.Text = "Name is required";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 369);
            Controls.Add(lblCategoryNameError);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(dvgCategory);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtCategoryName);
            Controls.Add(lblSearch);
            Controls.Add(lblCategoryName);
            Controls.Add(lblCategoryHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryForm";
            Text = "Category";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryHeader;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Button btnSave;
        private Button btnExit;
        private DataGridView dvgCategory;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblCategoryNameError;
    }
}