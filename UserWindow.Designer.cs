
namespace cellular
{
    partial class UserWindow
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
            this.labelGreeting = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelTariff = new System.Windows.Forms.Label();
            this.linkLabelShowCalls = new System.Windows.Forms.LinkLabel();
            this.linkLabelShowPrice = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Личный кабинет";
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelGreeting.Location = new System.Drawing.Point(10, 40);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(227, 32);
            this.labelGreeting.TabIndex = 14;
            this.labelGreeting.Text = "Добро пожаловать";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelPhone.Location = new System.Drawing.Point(10, 73);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(202, 32);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Номер телефона";
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelTariff.Location = new System.Drawing.Point(12, 104);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(84, 32);
            this.labelTariff.TabIndex = 19;
            this.labelTariff.Text = "Тариф";
            // 
            // linkLabelShowCalls
            // 
            this.linkLabelShowCalls.AutoSize = true;
            this.linkLabelShowCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.linkLabelShowCalls.Location = new System.Drawing.Point(11, 155);
            this.linkLabelShowCalls.Name = "linkLabelShowCalls";
            this.linkLabelShowCalls.Size = new System.Drawing.Size(241, 29);
            this.linkLabelShowCalls.TabIndex = 20;
            this.linkLabelShowCalls.TabStop = true;
            this.linkLabelShowCalls.Text = "Посмотреть звонки";
            this.linkLabelShowCalls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowCalls_LinkClicked);
            // 
            // linkLabelShowPrice
            // 
            this.linkLabelShowPrice.AutoSize = true;
            this.linkLabelShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.linkLabelShowPrice.Location = new System.Drawing.Point(13, 198);
            this.linkLabelShowPrice.Name = "linkLabelShowPrice";
            this.linkLabelShowPrice.Size = new System.Drawing.Size(378, 29);
            this.linkLabelShowPrice.TabIndex = 21;
            this.linkLabelShowPrice.TabStop = true;
            this.linkLabelShowPrice.Text = "Посмотреть расходы за период";
            this.linkLabelShowPrice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowPrice_LinkClicked);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 245);
            this.Controls.Add(this.linkLabelShowPrice);
            this.Controls.Add(this.linkLabelShowCalls);
            this.Controls.Add(this.labelTariff);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.label1);
            this.Name = "UserWindow";
            this.Text = "Личный кабинет";
            this.Shown += new System.EventHandler(this.UserWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.LinkLabel linkLabelShowCalls;
        private System.Windows.Forms.LinkLabel linkLabelShowPrice;
    }
}