﻿
namespace SteamForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutorizationLabel = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.RegistrationTB = new System.Windows.Forms.TextBox();
            this.LoginingBtn = new System.Windows.Forms.Button();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutorizationLabel
            // 
            this.AutorizationLabel.AutoSize = true;
            this.AutorizationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutorizationLabel.Location = new System.Drawing.Point(63, 101);
            this.AutorizationLabel.Name = "AutorizationLabel";
            this.AutorizationLabel.Size = new System.Drawing.Size(179, 37);
            this.AutorizationLabel.TabIndex = 0;
            this.AutorizationLabel.Text = "Авторизация";
            this.AutorizationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTB.Location = new System.Drawing.Point(63, 141);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.PlaceholderText = "Логин";
            this.LoginTB.Size = new System.Drawing.Size(179, 43);
            this.LoginTB.TabIndex = 1;
            // 
            // RegistrationTB
            // 
            this.RegistrationTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationTB.Location = new System.Drawing.Point(63, 190);
            this.RegistrationTB.Name = "RegistrationTB";
            this.RegistrationTB.PlaceholderText = "Пароль";
            this.RegistrationTB.Size = new System.Drawing.Size(179, 43);
            this.RegistrationTB.TabIndex = 2;
            // 
            // LoginingBtn
            // 
            this.LoginingBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginingBtn.Location = new System.Drawing.Point(63, 240);
            this.LoginingBtn.Name = "LoginingBtn";
            this.LoginingBtn.Size = new System.Drawing.Size(179, 43);
            this.LoginingBtn.TabIndex = 3;
            this.LoginingBtn.Text = "Войти";
            this.LoginingBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationBtn.Location = new System.Drawing.Point(63, 289);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(179, 43);
            this.RegistrationBtn.TabIndex = 4;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 481);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.LoginingBtn);
            this.Controls.Add(this.RegistrationTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.AutorizationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AutorizationLabel;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox RegistrationTB;
        private System.Windows.Forms.Button LoginingBtn;
        private System.Windows.Forms.Button RegistrationBtn;
    }
}

