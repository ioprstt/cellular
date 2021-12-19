
namespace cellular
{
    partial class PhoneNumberForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTariff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProviderPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRegistrationDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabelCreateClient = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateTariff = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(130, 13);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(349, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(131, 48);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(143, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тариф";
            // 
            // comboBoxTariff
            // 
            this.comboBoxTariff.FormattingEnabled = true;
            this.comboBoxTariff.Location = new System.Drawing.Point(131, 88);
            this.comboBoxTariff.Name = "comboBoxTariff";
            this.comboBoxTariff.Size = new System.Drawing.Size(348, 21);
            this.comboBoxTariff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата регистрации";
            // 
            // dateTimePickerRegistrationDate
            // 
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(131, 125);
            this.dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            this.dateTimePickerRegistrationDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRegistrationDate.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(215, 214);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProviderPhoneNumber
            // 
            this.errorProviderPhoneNumber.ContainerControl = this;
            // 
            // errorProviderRegistrationDate
            // 
            this.errorProviderRegistrationDate.ContainerControl = this;
            // 
            // linkLabelCreateClient
            // 
            this.linkLabelCreateClient.AutoSize = true;
            this.linkLabelCreateClient.Location = new System.Drawing.Point(16, 169);
            this.linkLabelCreateClient.Name = "linkLabelCreateClient";
            this.linkLabelCreateClient.Size = new System.Drawing.Size(93, 13);
            this.linkLabelCreateClient.TabIndex = 9;
            this.linkLabelCreateClient.TabStop = true;
            this.linkLabelCreateClient.Text = "Создать клиента";
            this.linkLabelCreateClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateClient_LinkClicked);
            // 
            // linkLabelCreateTariff
            // 
            this.linkLabelCreateTariff.AutoSize = true;
            this.linkLabelCreateTariff.Location = new System.Drawing.Point(16, 193);
            this.linkLabelCreateTariff.Name = "linkLabelCreateTariff";
            this.linkLabelCreateTariff.Size = new System.Drawing.Size(83, 13);
            this.linkLabelCreateTariff.TabIndex = 10;
            this.linkLabelCreateTariff.TabStop = true;
            this.linkLabelCreateTariff.Text = "Создать тариф";
            this.linkLabelCreateTariff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateTariff_LinkClicked);
            // 
            // PhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 249);
            this.Controls.Add(this.linkLabelCreateTariff);
            this.Controls.Add(this.linkLabelCreateClient);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateTimePickerRegistrationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTariff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label1);
            this.Name = "PhoneNumberForm";
            this.Text = "Номер телефона";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistrationDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTariff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationDate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ErrorProvider errorProviderPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderRegistrationDate;
        private System.Windows.Forms.LinkLabel linkLabelCreateTariff;
        private System.Windows.Forms.LinkLabel linkLabelCreateClient;
    }
}