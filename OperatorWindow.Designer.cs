﻿
namespace cellular
{
    partial class OperatorWindow
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
            this.linkLabelCreateClient = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelCreatePhone = new System.Windows.Forms.LinkLabel();
            this.linkLabelRemoveClient = new System.Windows.Forms.LinkLabel();
            this.linkLabelRemovePhone = new System.Windows.Forms.LinkLabel();
            this.linkLabelGetClientPassport = new System.Windows.Forms.LinkLabel();
            this.linkLabelGetCalls = new System.Windows.Forms.LinkLabel();
            this.linkLabelGetClientPhones = new System.Windows.Forms.LinkLabel();
            this.linkLabelChangePassport = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelCreateClient
            // 
            this.linkLabelCreateClient.AutoSize = true;
            this.linkLabelCreateClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelCreateClient.Location = new System.Drawing.Point(12, 58);
            this.linkLabelCreateClient.Name = "linkLabelCreateClient";
            this.linkLabelCreateClient.Size = new System.Drawing.Size(196, 32);
            this.linkLabelCreateClient.TabIndex = 0;
            this.linkLabelCreateClient.TabStop = true;
            this.linkLabelCreateClient.Text = "Создать клиента";
            this.linkLabelCreateClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateClient_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Рабочая панель оператора";
            // 
            // linkLabelCreatePhone
            // 
            this.linkLabelCreatePhone.AutoSize = true;
            this.linkLabelCreatePhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelCreatePhone.Location = new System.Drawing.Point(12, 314);
            this.linkLabelCreatePhone.Name = "linkLabelCreatePhone";
            this.linkLabelCreatePhone.Size = new System.Drawing.Size(180, 32);
            this.linkLabelCreatePhone.TabIndex = 15;
            this.linkLabelCreatePhone.TabStop = true;
            this.linkLabelCreatePhone.Text = "Создать номер";
            this.linkLabelCreatePhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreatePhone_LinkClicked);
            // 
            // linkLabelRemoveClient
            // 
            this.linkLabelRemoveClient.AutoSize = true;
            this.linkLabelRemoveClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRemoveClient.Location = new System.Drawing.Point(12, 104);
            this.linkLabelRemoveClient.Name = "linkLabelRemoveClient";
            this.linkLabelRemoveClient.Size = new System.Drawing.Size(197, 32);
            this.linkLabelRemoveClient.TabIndex = 16;
            this.linkLabelRemoveClient.TabStop = true;
            this.linkLabelRemoveClient.Text = "Удалить клиента";
            this.linkLabelRemoveClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRemoveClient_LinkClicked);
            // 
            // linkLabelRemovePhone
            // 
            this.linkLabelRemovePhone.AutoSize = true;
            this.linkLabelRemovePhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRemovePhone.Location = new System.Drawing.Point(11, 355);
            this.linkLabelRemovePhone.Name = "linkLabelRemovePhone";
            this.linkLabelRemovePhone.Size = new System.Drawing.Size(181, 32);
            this.linkLabelRemovePhone.TabIndex = 17;
            this.linkLabelRemovePhone.TabStop = true;
            this.linkLabelRemovePhone.Text = "Удалить номер";
            this.linkLabelRemovePhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRemovePhone_LinkClicked);
            // 
            // linkLabelGetClientPassport
            // 
            this.linkLabelGetClientPassport.AutoSize = true;
            this.linkLabelGetClientPassport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGetClientPassport.Location = new System.Drawing.Point(12, 153);
            this.linkLabelGetClientPassport.Name = "linkLabelGetClientPassport";
            this.linkLabelGetClientPassport.Size = new System.Drawing.Size(445, 32);
            this.linkLabelGetClientPassport.TabIndex = 18;
            this.linkLabelGetClientPassport.TabStop = true;
            this.linkLabelGetClientPassport.Text = "Получить паспортные данные клиента";
            this.linkLabelGetClientPassport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetClientPassport_LinkClicked);
            // 
            // linkLabelGetCalls
            // 
            this.linkLabelGetCalls.AutoSize = true;
            this.linkLabelGetCalls.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGetCalls.Location = new System.Drawing.Point(12, 398);
            this.linkLabelGetCalls.Name = "linkLabelGetCalls";
            this.linkLabelGetCalls.Size = new System.Drawing.Size(437, 32);
            this.linkLabelGetCalls.TabIndex = 19;
            this.linkLabelGetCalls.TabStop = true;
            this.linkLabelGetCalls.Text = "Получить список звонков для номера";
            this.linkLabelGetCalls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetCalls_LinkClicked);
            // 
            // linkLabelGetClientPhones
            // 
            this.linkLabelGetClientPhones.AutoSize = true;
            this.linkLabelGetClientPhones.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGetClientPhones.Location = new System.Drawing.Point(11, 243);
            this.linkLabelGetClientPhones.Name = "linkLabelGetClientPhones";
            this.linkLabelGetClientPhones.Size = new System.Drawing.Size(404, 32);
            this.linkLabelGetClientPhones.TabIndex = 20;
            this.linkLabelGetClientPhones.TabStop = true;
            this.linkLabelGetClientPhones.Text = "Получить список номеров клиента";
            this.linkLabelGetClientPhones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetClientPhones_LinkClicked);
            // 
            // linkLabelChangePassport
            // 
            this.linkLabelChangePassport.AutoSize = true;
            this.linkLabelChangePassport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelChangePassport.Location = new System.Drawing.Point(12, 201);
            this.linkLabelChangePassport.Name = "linkLabelChangePassport";
            this.linkLabelChangePassport.Size = new System.Drawing.Size(448, 32);
            this.linkLabelChangePassport.TabIndex = 21;
            this.linkLabelChangePassport.TabStop = true;
            this.linkLabelChangePassport.Text = "Обновить паспортные данные клиента";
            this.linkLabelChangePassport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePassport_LinkClicked);
            // 
            // OperatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelChangePassport);
            this.Controls.Add(this.linkLabelGetClientPhones);
            this.Controls.Add(this.linkLabelGetCalls);
            this.Controls.Add(this.linkLabelGetClientPassport);
            this.Controls.Add(this.linkLabelRemovePhone);
            this.Controls.Add(this.linkLabelRemoveClient);
            this.Controls.Add(this.linkLabelCreatePhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCreateClient);
            this.Name = "OperatorWindow";
            this.Text = "Панель оператора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCreateClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelCreatePhone;
        private System.Windows.Forms.LinkLabel linkLabelRemoveClient;
        private System.Windows.Forms.LinkLabel linkLabelRemovePhone;
        private System.Windows.Forms.LinkLabel linkLabelGetClientPassport;
        private System.Windows.Forms.LinkLabel linkLabelGetCalls;
        private System.Windows.Forms.LinkLabel linkLabelGetClientPhones;
        private System.Windows.Forms.LinkLabel linkLabelChangePassport;
    }
}