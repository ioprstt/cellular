
namespace cellular
{
    partial class ClientForm
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
            this.comboBoxClientFormPassports = new System.Windows.Forms.ComboBox();
            this.buttonClientOK = new System.Windows.Forms.Button();
            this.linkLabelAddPassport = new System.Windows.Forms.LinkLabel();
            this.errorProviderPassport = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паспорт";
            // 
            // comboBoxClientFormPassports
            // 
            this.comboBoxClientFormPassports.FormattingEnabled = true;
            this.comboBoxClientFormPassports.Location = new System.Drawing.Point(75, 11);
            this.comboBoxClientFormPassports.Name = "comboBoxClientFormPassports";
            this.comboBoxClientFormPassports.Size = new System.Drawing.Size(499, 21);
            this.comboBoxClientFormPassports.TabIndex = 1;
            // 
            // buttonClientOK
            // 
            this.buttonClientOK.Location = new System.Drawing.Point(207, 90);
            this.buttonClientOK.Name = "buttonClientOK";
            this.buttonClientOK.Size = new System.Drawing.Size(149, 20);
            this.buttonClientOK.TabIndex = 19;
            this.buttonClientOK.Text = "OK";
            this.buttonClientOK.UseVisualStyleBackColor = true;
            this.buttonClientOK.Click += new System.EventHandler(this.buttonClientOK_Click);
            // 
            // linkLabelAddPassport
            // 
            this.linkLabelAddPassport.AutoSize = true;
            this.linkLabelAddPassport.Location = new System.Drawing.Point(11, 54);
            this.linkLabelAddPassport.Name = "linkLabelAddPassport";
            this.linkLabelAddPassport.Size = new System.Drawing.Size(101, 13);
            this.linkLabelAddPassport.TabIndex = 20;
            this.linkLabelAddPassport.TabStop = true;
            this.linkLabelAddPassport.Text = "Добавить паспорт";
            this.linkLabelAddPassport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddPassport_LinkClicked);
            // 
            // errorProviderPassport
            // 
            this.errorProviderPassport.ContainerControl = this;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 120);
            this.Controls.Add(this.linkLabelAddPassport);
            this.Controls.Add(this.buttonClientOK);
            this.Controls.Add(this.comboBoxClientFormPassports);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClientFormPassports;
        private System.Windows.Forms.Button buttonClientOK;
        private System.Windows.Forms.LinkLabel linkLabelAddPassport;
        private System.Windows.Forms.ErrorProvider errorProviderPassport;
    }
}