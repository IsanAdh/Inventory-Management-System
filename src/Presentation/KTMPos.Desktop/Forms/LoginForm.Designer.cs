namespace KTMPos.Desktop.Forms
{
    partial class LoginForm
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(85, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(185, 79);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(85, 137);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(185, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(187, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 33);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_ClickAsync;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 204);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 33);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}
