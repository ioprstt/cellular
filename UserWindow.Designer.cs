
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
            this.tabControlCalls = new System.Windows.Forms.TabControl();
            this.tabPageOutgoing = new System.Windows.Forms.TabPage();
            this.dataGridViewOutgoing = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageIncoming = new System.Windows.Forms.TabPage();
            this.dataGridViewIncoming = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabControlCalls.SuspendLayout();
            this.tabPageOutgoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutgoing)).BeginInit();
            this.tabPageIncoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncoming)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Личный кабинет";
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGreeting.Location = new System.Drawing.Point(12, 41);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(226, 32);
            this.labelGreeting.TabIndex = 14;
            this.labelGreeting.Text = "Добро пожаловать";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(12, 73);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(201, 32);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Номер телефона";
            // 
            // tabControlCalls
            // 
            this.tabControlCalls.Controls.Add(this.tabPageOutgoing);
            this.tabControlCalls.Controls.Add(this.tabPageIncoming);
            this.tabControlCalls.Location = new System.Drawing.Point(13, 124);
            this.tabControlCalls.Name = "tabControlCalls";
            this.tabControlCalls.SelectedIndex = 0;
            this.tabControlCalls.Size = new System.Drawing.Size(775, 249);
            this.tabControlCalls.TabIndex = 17;
            // 
            // tabPageOutgoing
            // 
            this.tabPageOutgoing.Controls.Add(this.dataGridViewOutgoing);
            this.tabPageOutgoing.Location = new System.Drawing.Point(4, 24);
            this.tabPageOutgoing.Name = "tabPageOutgoing";
            this.tabPageOutgoing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutgoing.Size = new System.Drawing.Size(767, 221);
            this.tabPageOutgoing.TabIndex = 0;
            this.tabPageOutgoing.Text = "Исходящие";
            this.tabPageOutgoing.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOutgoing
            // 
            this.dataGridViewOutgoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutgoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Num,
            this.Duration});
            this.dataGridViewOutgoing.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOutgoing.Name = "dataGridViewOutgoing";
            this.dataGridViewOutgoing.RowTemplate.Height = 25;
            this.dataGridViewOutgoing.Size = new System.Drawing.Size(761, 215);
            this.dataGridViewOutgoing.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "StartTime";
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "OutgoingPhoneNumber";
            this.Num.HeaderText = "Номер";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 150;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Продолжительность";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 150;
            // 
            // tabPageIncoming
            // 
            this.tabPageIncoming.Controls.Add(this.dataGridViewIncoming);
            this.tabPageIncoming.Location = new System.Drawing.Point(4, 24);
            this.tabPageIncoming.Name = "tabPageIncoming";
            this.tabPageIncoming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncoming.Size = new System.Drawing.Size(767, 221);
            this.tabPageIncoming.TabIndex = 1;
            this.tabPageIncoming.Text = "Входящие";
            this.tabPageIncoming.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIncoming
            // 
            this.dataGridViewIncoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncoming.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewIncoming.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIncoming.Name = "dataGridViewIncoming";
            this.dataGridViewIncoming.RowTemplate.Height = 25;
            this.dataGridViewIncoming.Size = new System.Drawing.Size(761, 248);
            this.dataGridViewIncoming.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Время";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OutgoingPhoneNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(246, 379);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(302, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Обновить информацию";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.tabControlCalls);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.label1);
            this.Name = "UserWindow";
            this.Text = "Личный кабинет";
            this.Shown += new System.EventHandler(this.UserWindow_Shown);
            this.tabControlCalls.ResumeLayout(false);
            this.tabPageOutgoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutgoing)).EndInit();
            this.tabPageIncoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncoming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TabControl tabControlCalls;
        private System.Windows.Forms.TabPage tabPageOutgoing;
        private System.Windows.Forms.TabPage tabPageIncoming;
        private System.Windows.Forms.DataGridView dataGridViewOutgoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridView dataGridViewIncoming;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonUpdate;
    }
}