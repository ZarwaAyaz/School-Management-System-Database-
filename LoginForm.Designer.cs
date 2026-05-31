namespace SchoolManagementSystem
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
            // Main Panel (Login Card)
            this.panelLoginCard = new Panel();
            
            // Logo Area
            this.lblLogoPlaceholder = new Label();
            
            // School Name
            this.lblSchoolName = new Label();
            this.lblWelcome = new Label();
            
            // Login Type Section
            this.panelLoginType = new Panel();
            this.lblSelectLoginType = new Label();
            this.rbAdmin = new RadioButton();
            this.rbPrincipal = new RadioButton();
            this.rbTeacher = new RadioButton();
            
            // Input Fields
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            
            // Buttons
            this.btnLogin = new Button();
            this.btnClear = new Button();
            
            // Footer
            this.lblFooter = new Label();

            // Suspend layout
            this.panelLoginCard.SuspendLayout();
            this.panelLoginType.SuspendLayout();
            this.SuspendLayout();

            // ========================================
            // panelLoginCard - Main Login Box
            // ========================================
            this.panelLoginCard.BackColor = Color.White;
            this.panelLoginCard.Location = new Point(140, 30);
            this.panelLoginCard.Size = new Size(420, 520);
            this.panelLoginCard.Controls.Add(this.lblLogoPlaceholder);
            this.panelLoginCard.Controls.Add(this.lblSchoolName);
            this.panelLoginCard.Controls.Add(this.lblWelcome);
            this.panelLoginCard.Controls.Add(this.panelLoginType);
            this.panelLoginCard.Controls.Add(this.lblUsername);
            this.panelLoginCard.Controls.Add(this.txtUsername);
            this.panelLoginCard.Controls.Add(this.lblPassword);
            this.panelLoginCard.Controls.Add(this.txtPassword);
            this.panelLoginCard.Controls.Add(this.btnLogin);
            this.panelLoginCard.Controls.Add(this.btnClear);

            // ========================================
            // lblLogoPlaceholder - School Logo Area
            // ========================================
            this.lblLogoPlaceholder.BackColor = Color.FromArgb(232, 244, 253);
            this.lblLogoPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            this.lblLogoPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblLogoPlaceholder.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblLogoPlaceholder.Location = new Point(160, 20);
            this.lblLogoPlaceholder.Size = new Size(100, 80);
            this.lblLogoPlaceholder.Text = "🏫\r\nSchool Logo";
            this.lblLogoPlaceholder.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // lblSchoolName - Main Heading
            // ========================================
            this.lblSchoolName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSchoolName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSchoolName.Location = new Point(20, 110);
            this.lblSchoolName.Size = new Size(380, 35);
            this.lblSchoolName.Text = "School Management System";
            this.lblSchoolName.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // lblWelcome - Tagline
            // ========================================
            this.lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblWelcome.ForeColor = Color.Gray;
            this.lblWelcome.Location = new Point(20, 145);
            this.lblWelcome.Size = new Size(380, 20);
            this.lblWelcome.Text = "Welcome! Please login to continue";
            this.lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // panelLoginType - Radio Button Container
            // ========================================
            this.panelLoginType.BackColor = Color.FromArgb(248, 249, 250);
            this.panelLoginType.Location = new Point(30, 180);
            this.panelLoginType.Size = new Size(360, 80);
            this.panelLoginType.Controls.Add(this.lblSelectLoginType);
            this.panelLoginType.Controls.Add(this.rbAdmin);
            this.panelLoginType.Controls.Add(this.rbPrincipal);
            this.panelLoginType.Controls.Add(this.rbTeacher);

            // ========================================
            // lblSelectLoginType
            // ========================================
            this.lblSelectLoginType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectLoginType.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblSelectLoginType.Location = new Point(10, 10);
            this.lblSelectLoginType.Size = new Size(150, 20);
            this.lblSelectLoginType.Text = "Select Login Type:";

            // ========================================
            // rbAdmin - Admin Radio Button
            // ========================================
            this.rbAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.rbAdmin.ForeColor = Color.FromArgb(44, 62, 80);
            this.rbAdmin.Location = new Point(20, 40);
            this.rbAdmin.Size = new Size(80, 25);
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.Checked = true;
            this.rbAdmin.TabIndex = 0;

            // ========================================
            // rbPrincipal - Principal Radio Button
            // ========================================
            this.rbPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.rbPrincipal.ForeColor = Color.FromArgb(44, 62, 80);
            this.rbPrincipal.Location = new Point(130, 40);
            this.rbPrincipal.Size = new Size(100, 25);
            this.rbPrincipal.Text = "Principal";
            this.rbPrincipal.TabIndex = 1;

            // ========================================
            // rbTeacher - Teacher Radio Button
            // ========================================
            this.rbTeacher.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.rbTeacher.ForeColor = Color.FromArgb(44, 62, 80);
            this.rbTeacher.Location = new Point(250, 40);
            this.rbTeacher.Size = new Size(90, 25);
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.TabIndex = 2;

            // ========================================
            // lblUsername
            // ========================================
            this.lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblUsername.Location = new Point(30, 275);
            this.lblUsername.Size = new Size(100, 20);
            this.lblUsername.Text = "Username";

            // ========================================
            // txtUsername
            // ========================================
            this.txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.txtUsername.Location = new Point(30, 298);
            this.txtUsername.Size = new Size(360, 32);
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.TabIndex = 3;

            // ========================================
            // lblPassword
            // ========================================
            this.lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPassword.Location = new Point(30, 345);
            this.lblPassword.Size = new Size(100, 20);
            this.lblPassword.Text = "Password";

            // ========================================
            // txtPassword
            // ========================================
            this.txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.txtPassword.Location = new Point(30, 368);
            this.txtPassword.Size = new Size(360, 32);
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.TabIndex = 4;

            // ========================================
            // btnLogin - Primary Button
            // ========================================
            this.btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(30, 420);
            this.btnLogin.Size = new Size(360, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // ========================================
            // btnClear - Secondary Button
            // ========================================
            this.btnClear.BackColor = Color.FromArgb(248, 249, 250);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.btnClear.ForeColor = Color.FromArgb(85, 85, 85);
            this.btnClear.Location = new Point(30, 468);
            this.btnClear.Size = new Size(360, 38);
            this.btnClear.Text = "Clear";
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // ========================================
            // lblFooter - Copyright Footer
            // ========================================
            this.lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.lblFooter.ForeColor = Color.White;
            this.lblFooter.Location = new Point(0, 565);
            this.lblFooter.Size = new Size(700, 25);
            this.lblFooter.Text = "© 2025 School Management System — All Rights Reserved";
            this.lblFooter.TextAlign = ContentAlignment.MiddleCenter;

            // ========================================
            // LoginForm - Main Form
            // ========================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(102, 126, 234);
            this.ClientSize = new Size(700, 600);
            this.Controls.Add(this.panelLoginCard);
            this.Controls.Add(this.lblFooter);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "School Management System - Login";

            // Resume layout
            this.panelLoginType.ResumeLayout(false);
            this.panelLoginCard.ResumeLayout(false);
            this.panelLoginCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Control Declarations
        private Panel panelLoginCard;
        private Label lblLogoPlaceholder;
        private Label lblSchoolName;
        private Label lblWelcome;
        private Panel panelLoginType;
        private Label lblSelectLoginType;
        private RadioButton rbAdmin;
        private RadioButton rbPrincipal;
        private RadioButton rbTeacher;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private Label lblFooter;
    }
}
