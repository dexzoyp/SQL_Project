
namespace SQL_Project
{
    partial class Startup
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
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.button_log = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.check_showpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(32, 36);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(174, 29);
            this.user_name.TabIndex = 0;
            // 
            // user_password
            // 
            this.user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_password.Location = new System.Drawing.Point(32, 80);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(174, 29);
            this.user_password.TabIndex = 1;
            this.user_password.UseSystemPasswordChar = true;
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(32, 165);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(174, 39);
            this.button_log.TabIndex = 2;
            this.button_log.Text = "Login";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_login);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(32, 210);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(174, 39);
            this.button_reg.TabIndex = 3;
            this.button_reg.Text = "Register";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_register);
            // 
            // check_showpassword
            // 
            this.check_showpassword.AutoSize = true;
            this.check_showpassword.Location = new System.Drawing.Point(32, 115);
            this.check_showpassword.Name = "check_showpassword";
            this.check_showpassword.Size = new System.Drawing.Size(102, 17);
            this.check_showpassword.TabIndex = 4;
            this.check_showpassword.Text = "Show Password";
            this.check_showpassword.UseVisualStyleBackColor = true;
            this.check_showpassword.CheckedChanged += new System.EventHandler(this.check_showpassword_CheckedChanged);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.check_showpassword);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.CheckBox check_showpassword;
    }
}

