
namespace gender_equality_app
{
    partial class RegisterForm
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
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.emailaddress = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.firstname.Location = new System.Drawing.Point(191, 89);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(164, 22);
            this.firstname.TabIndex = 200;
            this.firstname.Text = "first name";
            this.firstname.TextChanged += new System.EventHandler(this.RegisterForm_Load);
            this.firstname.Enter += new System.EventHandler(this.firstname_Enter);
            this.firstname.Leave += new System.EventHandler(this.firstname_Leave);
            // 
            // lastname
            // 
            this.lastname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lastname.Location = new System.Drawing.Point(392, 89);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(164, 22);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "last name";
            this.lastname.Enter += new System.EventHandler(this.lastname_Enter);
            this.lastname.Leave += new System.EventHandler(this.lastname_Leave);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(191, 306);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(365, 39);
            this.createbutton.TabIndex = 2;
            this.createbutton.Text = "create account";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // emailaddress
            // 
            this.emailaddress.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailaddress.Location = new System.Drawing.Point(191, 135);
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(365, 22);
            this.emailaddress.TabIndex = 3;
            this.emailaddress.Text = "email address";
            this.emailaddress.TextChanged += new System.EventHandler(this.emailaddress_TextChanged);
            this.emailaddress.Enter += new System.EventHandler(this.emailaddress_Enter);
            this.emailaddress.Leave += new System.EventHandler(this.emailaddress_Leave);
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.username.Location = new System.Drawing.Point(191, 173);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(365, 22);
            this.username.TabIndex = 4;
            this.username.Text = "username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Location = new System.Drawing.Point(191, 216);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(365, 22);
            this.password.TabIndex = 6;
            this.password.Text = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // confirmpassword
            // 
            this.confirmpassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmpassword.Location = new System.Drawing.Point(191, 253);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(365, 22);
            this.confirmpassword.TabIndex = 7;
            this.confirmpassword.Text = "confirm password";
            this.confirmpassword.UseSystemPasswordChar = true;
            this.confirmpassword.Enter += new System.EventHandler(this.confirmpassword_Enter);
            this.confirmpassword.Leave += new System.EventHandler(this.confirmpassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "label1";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.emailaddress);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.TextBox emailaddress;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.Label label1;
    }
}