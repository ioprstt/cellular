
namespace cellular
{
    partial class CallsForPhoneNumberForm
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
            this.tabControlCalls = new System.Windows.Forms.TabControl();
            this.tabPageOutgoing = new System.Windows.Forms.TabPage();
            this.dataGridViewOutgoing = new System.Windows.Forms.DataGridView();
            this.tabPageIncoming = new System.Windows.Forms.TabPage();
            this.dataGridViewIncoming = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCalls.SuspendLayout();
            this.tabPageOutgoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutgoing)).BeginInit();
            this.tabPageIncoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncoming)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCalls
            // 
            this.tabControlCalls.Controls.Add(this.tabPageOutgoing);
            this.tabControlCalls.Controls.Add(this.tabPageIncoming);
            this.tabControlCalls.Location = new System.Drawing.Point(5, 4);
            this.tabControlCalls.Name = "tabControlCalls";
            this.tabControlCalls.SelectedIndex = 0;
            this.tabControlCalls.Size = new System.Drawing.Size(727, 329);
            this.tabControlCalls.TabIndex = 18;
            // 
            // tabPageOutgoing
            // 
            this.tabPageOutgoing.Controls.Add(this.dataGridViewOutgoing);
            this.tabPageOutgoing.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutgoing.Name = "tabPageOutgoing";
            this.tabPageOutgoing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutgoing.Size = new System.Drawing.Size(719, 303);
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
            this.dataGridViewOutgoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutgoing.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOutgoing.Name = "dataGridViewOutgoing";
            this.dataGridViewOutgoing.RowTemplate.Height = 25;
            this.dataGridViewOutgoing.Size = new System.Drawing.Size(713, 297);
            this.dataGridViewOutgoing.TabIndex = 0;
            // 
            // tabPageIncoming
            // 
            this.tabPageIncoming.Controls.Add(this.dataGridViewIncoming);
            this.tabPageIncoming.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncoming.Name = "tabPageIncoming";
            this.tabPageIncoming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncoming.Size = new System.Drawing.Size(719, 303);
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
            this.dataGridViewIncoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncoming.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIncoming.Name = "dataGridViewIncoming";
            this.dataGridViewIncoming.RowTemplate.Height = 25;
            this.dataGridViewIncoming.Size = new System.Drawing.Size(713, 297);
            this.dataGridViewIncoming.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(330, 342);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.Num.DataPropertyName = "IncomingPhoneNumber";
            this.Num.HeaderText = "Звонок на номер";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 150;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Продолжительность, сек";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 200;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Звонок от номера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Продолжительность, сек";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // CallsForPhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 377);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.tabControlCalls);
            this.Name = "CallsForPhoneNumberForm";
            this.Text = "Звонки клиента";
            this.tabControlCalls.ResumeLayout(false);
            this.tabPageOutgoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutgoing)).EndInit();
            this.tabPageIncoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncoming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCalls;
        private System.Windows.Forms.TabPage tabPageOutgoing;
        private System.Windows.Forms.DataGridView dataGridViewOutgoing;
        private System.Windows.Forms.TabPage tabPageIncoming;
        private System.Windows.Forms.DataGridView dataGridViewIncoming;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}