
namespace cellular
{
    partial class AdminWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPagePassport = new System.Windows.Forms.TabPage();
            this.dgvAdminPassport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.dgvAdminClient = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePhoneNumber = new System.Windows.Forms.TabPage();
            this.dgvAdminPhoneNumber = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCall = new System.Windows.Forms.TabPage();
            this.dgvAdminCall = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdminUpdate = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabPagePassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPassport)).BeginInit();
            this.tabPageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminClient)).BeginInit();
            this.tabPagePhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPhoneNumber)).BeginInit();
            this.tabPageCall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCall)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(190, 305);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(167, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(363, 305);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(167, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPagePassport);
            this.tabControlAdmin.Controls.Add(this.tabPageClient);
            this.tabControlAdmin.Controls.Add(this.tabPagePhoneNumber);
            this.tabControlAdmin.Controls.Add(this.tabPageCall);
            this.tabControlAdmin.Location = new System.Drawing.Point(13, 13);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(775, 286);
            this.tabControlAdmin.TabIndex = 4;
            // 
            // tabPagePassport
            // 
            this.tabPagePassport.Controls.Add(this.dgvAdminPassport);
            this.tabPagePassport.Location = new System.Drawing.Point(4, 24);
            this.tabPagePassport.Name = "tabPagePassport";
            this.tabPagePassport.Size = new System.Drawing.Size(767, 258);
            this.tabPagePassport.TabIndex = 4;
            this.tabPagePassport.Text = "Паспорт";
            this.tabPagePassport.UseVisualStyleBackColor = true;
            // 
            // dgvAdminPassport
            // 
            this.dgvAdminPassport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPassport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvAdminPassport.Location = new System.Drawing.Point(3, 3);
            this.dgvAdminPassport.Name = "dgvAdminPassport";
            this.dgvAdminPassport.RowTemplate.Height = 25;
            this.dgvAdminPassport.Size = new System.Drawing.Size(761, 252);
            this.dgvAdminPassport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Series";
            this.Column2.HeaderText = "Серия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Num";
            this.Column3.HeaderText = "Номер";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateOfIssue";
            this.Column4.HeaderText = "Дата выдачи";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Surname";
            this.Column5.HeaderText = "Фамилия";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Имя";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Patronymic";
            this.Column7.HeaderText = "Отчество";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DateOfBirth";
            this.Column8.HeaderText = "Дата рождения";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Address";
            this.Column9.HeaderText = "Адрес регистрации";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.dgvAdminClient);
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(767, 258);
            this.tabPageClient.TabIndex = 1;
            this.tabPageClient.Text = "Клиент";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // dgvAdminClient
            // 
            this.dgvAdminClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11});
            this.dgvAdminClient.Location = new System.Drawing.Point(3, 3);
            this.dgvAdminClient.Name = "dgvAdminClient";
            this.dgvAdminClient.RowTemplate.Height = 25;
            this.dgvAdminClient.Size = new System.Drawing.Size(761, 252);
            this.dgvAdminClient.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Id";
            this.Column10.HeaderText = "ID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PassportId";
            this.Column11.HeaderText = "Паспорт";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // tabPagePhoneNumber
            // 
            this.tabPagePhoneNumber.Controls.Add(this.dgvAdminPhoneNumber);
            this.tabPagePhoneNumber.Location = new System.Drawing.Point(4, 24);
            this.tabPagePhoneNumber.Name = "tabPagePhoneNumber";
            this.tabPagePhoneNumber.Size = new System.Drawing.Size(767, 258);
            this.tabPagePhoneNumber.TabIndex = 2;
            this.tabPagePhoneNumber.Text = "Номер телефона";
            this.tabPagePhoneNumber.UseVisualStyleBackColor = true;
            // 
            // dgvAdminPhoneNumber
            // 
            this.dgvAdminPhoneNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPhoneNumber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvAdminPhoneNumber.Location = new System.Drawing.Point(3, 3);
            this.dgvAdminPhoneNumber.Name = "dgvAdminPhoneNumber";
            this.dgvAdminPhoneNumber.RowTemplate.Height = 25;
            this.dgvAdminPhoneNumber.Size = new System.Drawing.Size(761, 252);
            this.dgvAdminPhoneNumber.TabIndex = 0;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Id";
            this.Column12.HeaderText = "ID";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "ClientId";
            this.Column13.HeaderText = "Клиент";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Num";
            this.Column14.HeaderText = "Номер";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "RegistrationDate";
            this.Column15.HeaderText = "Дата регистрации";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // tabPageCall
            // 
            this.tabPageCall.Controls.Add(this.dgvAdminCall);
            this.tabPageCall.Location = new System.Drawing.Point(4, 24);
            this.tabPageCall.Name = "tabPageCall";
            this.tabPageCall.Size = new System.Drawing.Size(767, 258);
            this.tabPageCall.TabIndex = 3;
            this.tabPageCall.Text = "Вызовы";
            this.tabPageCall.UseVisualStyleBackColor = true;
            // 
            // dgvAdminCall
            // 
            this.dgvAdminCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminCall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dgvAdminCall.Location = new System.Drawing.Point(3, 3);
            this.dgvAdminCall.Name = "dgvAdminCall";
            this.dgvAdminCall.RowTemplate.Height = 25;
            this.dgvAdminCall.Size = new System.Drawing.Size(761, 252);
            this.dgvAdminCall.TabIndex = 0;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Id";
            this.Column16.HeaderText = "ID";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "OutgoingPhoneNumberId";
            this.Column17.HeaderText = "Исходящий номер";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "IncomingPhoneNumberId";
            this.Column18.HeaderText = "Входящий номер";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "StartTime";
            this.Column19.HeaderText = "Время начала";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "EndTime";
            this.Column20.HeaderText = "Время окончания";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // buttonAdminUpdate
            // 
            this.buttonAdminUpdate.Location = new System.Drawing.Point(617, 305);
            this.buttonAdminUpdate.Name = "buttonAdminUpdate";
            this.buttonAdminUpdate.Size = new System.Drawing.Size(167, 23);
            this.buttonAdminUpdate.TabIndex = 5;
            this.buttonAdminUpdate.Text = "Обновиь";
            this.buttonAdminUpdate.UseVisualStyleBackColor = true;
            this.buttonAdminUpdate.Click += new System.EventHandler(this.buttonAdminUpdate_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.buttonAdminUpdate);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.button1);
            this.Name = "AdminWindow";
            this.Text = "Панель администратора";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPagePassport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPassport)).EndInit();
            this.tabPageClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminClient)).EndInit();
            this.tabPagePhoneNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPhoneNumber)).EndInit();
            this.tabPageCall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPagePhoneNumber;
        private System.Windows.Forms.TabPage tabPageCall;
        private System.Windows.Forms.Button buttonAdminUpdate;
        private System.Windows.Forms.DataGridView dgvAdminClient;
        private System.Windows.Forms.DataGridView dgvAdminPhoneNumber;
        private System.Windows.Forms.DataGridView dgvAdminCall;
        private System.Windows.Forms.TabPage tabPagePassport;
        private System.Windows.Forms.DataGridView dgvAdminPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
    }
}