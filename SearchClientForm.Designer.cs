
namespace cellular
{
    partial class SearchClientForm
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
            this.buttonSearchClientOK = new System.Windows.Forms.Button();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonPassport = new System.Windows.Forms.RadioButton();
            this.textBoxPassportSeries = new System.Windows.Forms.TextBox();
            this.textBoxPassportNum = new System.Windows.Forms.TextBox();
            this.radioButtonPhoneNumber = new System.Windows.Forms.RadioButton();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearchClientOK
            // 
            this.buttonSearchClientOK.Location = new System.Drawing.Point(144, 146);
            this.buttonSearchClientOK.Name = "buttonSearchClientOK";
            this.buttonSearchClientOK.Size = new System.Drawing.Size(64, 20);
            this.buttonSearchClientOK.TabIndex = 0;
            this.buttonSearchClientOK.Text = "ОК";
            this.buttonSearchClientOK.UseVisualStyleBackColor = true;
            this.buttonSearchClientOK.Click += new System.EventHandler(this.buttonSearchClientOK_Click);
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Checked = true;
            this.radioButtonId.Location = new System.Drawing.Point(10, 25);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(125, 17);
            this.radioButtonId.TabIndex = 1;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "По идентификатору";
            this.radioButtonId.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassport
            // 
            this.radioButtonPassport.AutoSize = true;
            this.radioButtonPassport.Location = new System.Drawing.Point(10, 66);
            this.radioButtonPassport.Name = "radioButtonPassport";
            this.radioButtonPassport.Size = new System.Drawing.Size(88, 17);
            this.radioButtonPassport.TabIndex = 3;
            this.radioButtonPassport.Text = "По паспорту";
            this.radioButtonPassport.UseVisualStyleBackColor = true;
            // 
            // textBoxPassportSeries
            // 
            this.textBoxPassportSeries.Location = new System.Drawing.Point(154, 62);
            this.textBoxPassportSeries.MaxLength = 4;
            this.textBoxPassportSeries.Name = "textBoxPassportSeries";
            this.textBoxPassportSeries.Size = new System.Drawing.Size(86, 20);
            this.textBoxPassportSeries.TabIndex = 4;
            // 
            // textBoxPassportNum
            // 
            this.textBoxPassportNum.Location = new System.Drawing.Point(255, 62);
            this.textBoxPassportNum.MaxLength = 6;
            this.textBoxPassportNum.Name = "textBoxPassportNum";
            this.textBoxPassportNum.Size = new System.Drawing.Size(86, 20);
            this.textBoxPassportNum.TabIndex = 5;
            // 
            // radioButtonPhoneNumber
            // 
            this.radioButtonPhoneNumber.AutoSize = true;
            this.radioButtonPhoneNumber.Location = new System.Drawing.Point(10, 107);
            this.radioButtonPhoneNumber.Name = "radioButtonPhoneNumber";
            this.radioButtonPhoneNumber.Size = new System.Drawing.Size(131, 17);
            this.radioButtonPhoneNumber.TabIndex = 6;
            this.radioButtonPhoneNumber.Text = "По номеру телефона";
            this.radioButtonPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(154, 102);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(187, 20);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(154, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(187, 20);
            this.textBoxId.TabIndex = 8;
            // 
            // SearchClientForm
            // 
            this.AcceptButton = this.buttonSearchClientOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 176);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.radioButtonPhoneNumber);
            this.Controls.Add(this.textBoxPassportNum);
            this.Controls.Add(this.textBoxPassportSeries);
            this.Controls.Add(this.radioButtonPassport);
            this.Controls.Add(this.radioButtonId);
            this.Controls.Add(this.buttonSearchClientOK);
            this.Name = "SearchClientForm";
            this.Text = "Поиск клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchClientOK;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonPassport;
        private System.Windows.Forms.TextBox textBoxPassportSeries;
        private System.Windows.Forms.TextBox textBoxPassportNum;
        private System.Windows.Forms.RadioButton radioButtonPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxId;
    }
}