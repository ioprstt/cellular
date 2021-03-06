
namespace cellular
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход в систему";
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Location = new System.Drawing.Point(107, 54);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(98, 17);
            this.radioButtonUser.TabIndex = 3;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Пользователь";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(107, 128);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(104, 17);
            this.radioButtonAdmin.TabIndex = 4;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Администратор";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(72, 164);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(155, 34);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Продолжить";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.Location = new System.Drawing.Point(107, 89);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(74, 17);
            this.radioButtonOperator.TabIndex = 6;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Оператор";
            this.radioButtonOperator.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 210);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.RadioButton radioButtonOperator;
    }
}