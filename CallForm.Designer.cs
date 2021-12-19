
namespace cellular
{
    partial class CallForm
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
            this.comboBoxOutgoingPhoneNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxIncomingPhoneNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelCreatePhoneNumber = new System.Windows.Forms.LinkLabel();
            this.errorProviderOutgoingPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIncomingPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStartTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEndTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOutgoingPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIncomingPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEndTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходящий номер";
            // 
            // comboBoxOutgoingPhoneNumber
            // 
            this.comboBoxOutgoingPhoneNumber.FormattingEnabled = true;
            this.comboBoxOutgoingPhoneNumber.Location = new System.Drawing.Point(128, 9);
            this.comboBoxOutgoingPhoneNumber.Name = "comboBoxOutgoingPhoneNumber";
            this.comboBoxOutgoingPhoneNumber.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOutgoingPhoneNumber.TabIndex = 1;
            // 
            // comboBoxIncomingPhoneNumber
            // 
            this.comboBoxIncomingPhoneNumber.FormattingEnabled = true;
            this.comboBoxIncomingPhoneNumber.Location = new System.Drawing.Point(128, 49);
            this.comboBoxIncomingPhoneNumber.Name = "comboBoxIncomingPhoneNumber";
            this.comboBoxIncomingPhoneNumber.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIncomingPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Входящий номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время начала";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(128, 86);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartTime.TabIndex = 5;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(128, 119);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время окончания";
            // 
            // linkLabelCreatePhoneNumber
            // 
            this.linkLabelCreatePhoneNumber.AutoSize = true;
            this.linkLabelCreatePhoneNumber.Location = new System.Drawing.Point(15, 172);
            this.linkLabelCreatePhoneNumber.Name = "linkLabelCreatePhoneNumber";
            this.linkLabelCreatePhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.linkLabelCreatePhoneNumber.TabIndex = 8;
            this.linkLabelCreatePhoneNumber.TabStop = true;
            this.linkLabelCreatePhoneNumber.Text = "Создать номер";
            this.linkLabelCreatePhoneNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreatePhoneNumber_LinkClicked);
            // 
            // errorProviderOutgoingPhoneNumber
            // 
            this.errorProviderOutgoingPhoneNumber.ContainerControl = this;
            // 
            // errorProviderIncomingPhoneNumber
            // 
            this.errorProviderIncomingPhoneNumber.ContainerControl = this;
            // 
            // errorProviderStartTime
            // 
            this.errorProviderStartTime.ContainerControl = this;
            // 
            // errorProviderEndTime
            // 
            this.errorProviderEndTime.ContainerControl = this;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(143, 200);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 235);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.linkLabelCreatePhoneNumber);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIncomingPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOutgoingPhoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "CallForm";
            this.Text = "Вызов";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOutgoingPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIncomingPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEndTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOutgoingPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxIncomingPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelCreatePhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderOutgoingPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderIncomingPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderStartTime;
        private System.Windows.Forms.ErrorProvider errorProviderEndTime;
        private System.Windows.Forms.Button buttonOK;
    }
}