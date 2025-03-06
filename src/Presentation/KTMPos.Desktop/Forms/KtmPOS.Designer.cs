namespace KTMPos.Desktop.Forms
{
    partial class KtmPOS
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
            menuStrip1 = new MenuStrip();
            inventoryManagementToolStripMenuItem = new ToolStripMenuItem();
            catagoryToolStripMenuItem = new ToolStripMenuItem();
            subCategoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            supplierPurchaseToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            pOSToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            reportingToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            revenueReportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventoryManagementToolStripMenuItem, supplierPurchaseToolStripMenuItem, pOSToolStripMenuItem, reportingToolStripMenuItem, helpToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(737, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventoryManagementToolStripMenuItem
            // 
            inventoryManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catagoryToolStripMenuItem, subCategoryToolStripMenuItem, productToolStripMenuItem });
            inventoryManagementToolStripMenuItem.Name = "inventoryManagementToolStripMenuItem";
            inventoryManagementToolStripMenuItem.Size = new Size(143, 20);
            inventoryManagementToolStripMenuItem.Text = "Inventory Management";
            // 
            // catagoryToolStripMenuItem
            // 
            catagoryToolStripMenuItem.Name = "catagoryToolStripMenuItem";
            catagoryToolStripMenuItem.Size = new Size(180, 22);
            catagoryToolStripMenuItem.Text = "Category";
            catagoryToolStripMenuItem.Click += catagoryToolStripMenuItem_Click;
            // 
            // subCategoryToolStripMenuItem
            // 
            subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            subCategoryToolStripMenuItem.Size = new Size(180, 22);
            subCategoryToolStripMenuItem.Text = "Sub Category";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(180, 22);
            productToolStripMenuItem.Text = "Product";
            // 
            // supplierPurchaseToolStripMenuItem
            // 
            supplierPurchaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplierToolStripMenuItem, purchaseToolStripMenuItem });
            supplierPurchaseToolStripMenuItem.Name = "supplierPurchaseToolStripMenuItem";
            supplierPurchaseToolStripMenuItem.Size = new Size(136, 20);
            supplierPurchaseToolStripMenuItem.Text = "Supplier and Purchase";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(122, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(122, 22);
            purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // pOSToolStripMenuItem
            // 
            pOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salesToolStripMenuItem });
            pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            pOSToolStripMenuItem.Size = new Size(41, 20);
            pOSToolStripMenuItem.Text = "POS";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(100, 22);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // reportingToolStripMenuItem
            // 
            reportingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salesReportToolStripMenuItem, revenueReportToolStripMenuItem });
            reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            reportingToolStripMenuItem.Size = new Size(71, 20);
            reportingToolStripMenuItem.Text = "Reporting";
            // 
            // salesReportToolStripMenuItem
            // 
            salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            salesReportToolStripMenuItem.Size = new Size(157, 22);
            salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new Size(157, 22);
            revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // KtmPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "KtmPOS";
            Text = "KtmPOS";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventoryManagementToolStripMenuItem;
        private ToolStripMenuItem catagoryToolStripMenuItem;
        private ToolStripMenuItem subCategoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem supplierPurchaseToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem pOSToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem reportingToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private ToolStripMenuItem revenueReportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}



