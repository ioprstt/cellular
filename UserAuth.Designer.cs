
namespace cellular
{
    partial class UserAuth
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вход в личный кабинет";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(62, 80);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(211, 20);
            this.textBoxLogin.TabIndex = 15;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(84, 129);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(155, 33);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Введите номер телефона";
            // 
            // UserAuth
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "UserAuth";
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
    }
}