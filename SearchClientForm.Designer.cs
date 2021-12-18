
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
<<<<<<< HEAD
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
=======
>>>>>>> acb11c1 (ef6 and net472)
            this.radioButtonPassport = new System.Windows.Forms.RadioButton();
            this.textBoxPassportSeries = new System.Windows.Forms.TextBox();
            this.textBoxPassportNum = new System.Windows.Forms.TextBox();
            this.radioButtonPhoneNumber = new System.Windows.Forms.RadioButton();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
=======
            this.textBoxId = new System.Windows.Forms.TextBox();
>>>>>>> acb11c1 (ef6 and net472)
            this.SuspendLayout();
            // 
            // buttonSearchClientOK
            // 
<<<<<<< HEAD
            this.buttonSearchClientOK.Location = new System.Drawing.Point(168, 168);
            this.buttonSearchClientOK.Name = "buttonSearchClientOK";
            this.buttonSearchClientOK.Size = new System.Drawing.Size(75, 23);
=======
            this.buttonSearchClientOK.Location = new System.Drawing.Point(144, 146);
            this.buttonSearchClientOK.Name = "buttonSearchClientOK";
            this.buttonSearchClientOK.Size = new System.Drawing.Size(64, 20);
>>>>>>> acb11c1 (ef6 and net472)
            this.buttonSearchClientOK.TabIndex = 0;
            this.buttonSearchClientOK.Text = "ОК";
            this.buttonSearchClientOK.UseVisualStyleBackColor = true;
            this.buttonSearchClientOK.Click += new System.EventHandler(this.buttonSearchClientOK_Click);
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Checked = true;
<<<<<<< HEAD
            this.radioButtonId.Location = new System.Drawing.Point(12, 29);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(135, 19);
=======
            this.radioButtonId.Location = new System.Drawing.Point(10, 25);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(125, 17);
>>>>>>> acb11c1 (ef6 and net472)
            this.radioButtonId.TabIndex = 1;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "По идентификатору";
            this.radioButtonId.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(180, 29);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(218, 23);
            this.numericUpDownId.TabIndex = 2;
            // 
            // radioButtonPassport
            // 
            this.radioButtonPassport.AutoSize = true;
            this.radioButtonPassport.Location = new System.Drawing.Point(12, 76);
            this.radioButtonPassport.Name = "radioButtonPassport";
            this.radioButtonPassport.Size = new System.Drawing.Size(95, 19);
=======
            // radioButtonPassport
            // 
            this.radioButtonPassport.AutoSize = true;
            this.radioButtonPassport.Location = new System.Drawing.Point(10, 66);
            this.radioButtonPassport.Name = "radioButtonPassport";
            this.radioButtonPassport.Size = new System.Drawing.Size(88, 17);
>>>>>>> acb11c1 (ef6 and net472)
            this.radioButtonPassport.TabIndex = 3;
            this.radioButtonPassport.Text = "По паспорту";
            this.radioButtonPassport.UseVisualStyleBackColor = true;
            // 
            // textBoxPassportSeries
            // 
<<<<<<< HEAD
            this.textBoxPassportSeries.Location = new System.Drawing.Point(180, 71);
            this.textBoxPassportSeries.MaxLength = 4;
            this.textBoxPassportSeries.Name = "textBoxPassportSeries";
            this.textBoxPassportSeries.PlaceholderText = "Серия";
            this.textBoxPassportSeries.Size = new System.Drawing.Size(100, 23);
=======
            this.textBoxPassportSeries.Location = new System.Drawing.Point(154, 62);
            this.textBoxPassportSeries.MaxLength = 4;
            this.textBoxPassportSeries.Name = "textBoxPassportSeries";
            this.textBoxPassportSeries.Size = new System.Drawing.Size(86, 20);
>>>>>>> acb11c1 (ef6 and net472)
            this.textBoxPassportSeries.TabIndex = 4;
            // 
            // textBoxPassportNum
            // 
<<<<<<< HEAD
            this.textBoxPassportNum.Location = new System.Drawing.Point(298, 71);
            this.textBoxPassportNum.MaxLength = 6;
            this.textBoxPassportNum.Name = "textBoxPassportNum";
            this.textBoxPassportNum.PlaceholderText = "Номер";
            this.textBoxPassportNum.Size = new System.Drawing.Size(100, 23);
=======
            this.textBoxPassportNum.Location = new System.Drawing.Point(255, 62);
            this.textBoxPassportNum.MaxLength = 6;
            this.textBoxPassportNum.Name = "textBoxPassportNum";
            this.textBoxPassportNum.Size = new System.Drawing.Size(86, 20);
>>>>>>> acb11c1 (ef6 and net472)
            this.textBoxPassportNum.TabIndex = 5;
            // 
            // radioButtonPhoneNumber
            // 
            this.radioButtonPhoneNumber.AutoSize = true;
<<<<<<< HEAD
            this.radioButtonPhoneNumber.Location = new System.Drawing.Point(12, 123);
            this.radioButtonPhoneNumber.Name = "radioButtonPhoneNumber";
            this.radioButtonPhoneNumber.Size = new System.Drawing.Size(142, 19);
=======
            this.radioButtonPhoneNumber.Location = new System.Drawing.Point(10, 107);
            this.radioButtonPhoneNumber.Name = "radioButtonPhoneNumber";
            this.radioButtonPhoneNumber.Size = new System.Drawing.Size(131, 17);
>>>>>>> acb11c1 (ef6 and net472)
            this.radioButtonPhoneNumber.TabIndex = 6;
            this.radioButtonPhoneNumber.Text = "По номеру телефона";
            this.radioButtonPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneNumber
            // 
<<<<<<< HEAD
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(180, 118);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(218, 23);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // SearchClientForm
            // 
            this.AcceptButton = this.buttonSearchClientOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 203);
=======
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
>>>>>>> acb11c1 (ef6 and net472)
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.radioButtonPhoneNumber);
            this.Controls.Add(this.textBoxPassportNum);
            this.Controls.Add(this.textBoxPassportSeries);
            this.Controls.Add(this.radioButtonPassport);
<<<<<<< HEAD
            this.Controls.Add(this.numericUpDownId);
=======
>>>>>>> acb11c1 (ef6 and net472)
            this.Controls.Add(this.radioButtonId);
            this.Controls.Add(this.buttonSearchClientOK);
            this.Name = "SearchClientForm";
            this.Text = "Поиск клиента";
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
=======
>>>>>>> acb11c1 (ef6 and net472)
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchClientOK;
        private System.Windows.Forms.RadioButton radioButtonId;
<<<<<<< HEAD
        private System.Windows.Forms.NumericUpDown numericUpDownId;
=======
>>>>>>> acb11c1 (ef6 and net472)
        private System.Windows.Forms.RadioButton radioButtonPassport;
        private System.Windows.Forms.TextBox textBoxPassportSeries;
        private System.Windows.Forms.TextBox textBoxPassportNum;
        private System.Windows.Forms.RadioButton radioButtonPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
<<<<<<< HEAD
=======
        private System.Windows.Forms.TextBox textBoxId;
>>>>>>> acb11c1 (ef6 and net472)
    }
}