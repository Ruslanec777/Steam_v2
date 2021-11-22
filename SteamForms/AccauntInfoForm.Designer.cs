
namespace SteamForms
{
    partial class AccauntInfoForm
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
            this.accountInfolabel = new System.Windows.Forms.Label();
            this.regSexComboBox = new System.Windows.Forms.ComboBox();
            this.RegPasswordTB = new System.Windows.Forms.TextBox();
            this.RegPatronymicTB = new System.Windows.Forms.TextBox();
            this.RegSurnameTB = new System.Windows.Forms.TextBox();
            this.RegNicNameTB = new System.Windows.Forms.TextBox();
            this.RegAgeTB = new System.Windows.Forms.TextBox();
            this.RegLoginTB = new System.Windows.Forms.TextBox();
            this.RegNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accountInfolabel
            // 
            this.accountInfolabel.AutoSize = true;
            this.accountInfolabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountInfolabel.Location = new System.Drawing.Point(169, 9);
            this.accountInfolabel.Name = "accountInfolabel";
            this.accountInfolabel.Size = new System.Drawing.Size(233, 37);
            this.accountInfolabel.TabIndex = 19;
            this.accountInfolabel.Text = "Данные Аккаунта";
            this.accountInfolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // regSexComboBox
            // 
            this.regSexComboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regSexComboBox.FormattingEnabled = true;
            this.regSexComboBox.Location = new System.Drawing.Point(97, 253);
            this.regSexComboBox.Name = "regSexComboBox";
            this.regSexComboBox.Size = new System.Drawing.Size(342, 45);
            this.regSexComboBox.TabIndex = 27;
            // 
            // RegPasswordTB
            // 
            this.RegPasswordTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPasswordTB.Location = new System.Drawing.Point(97, 400);
            this.RegPasswordTB.Name = "RegPasswordTB";
            this.RegPasswordTB.PlaceholderText = "Пароль";
            this.RegPasswordTB.Size = new System.Drawing.Size(342, 43);
            this.RegPasswordTB.TabIndex = 26;
            this.RegPasswordTB.UseSystemPasswordChar = true;
            // 
            // RegPatronymicTB
            // 
            this.RegPatronymicTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPatronymicTB.Location = new System.Drawing.Point(97, 106);
            this.RegPatronymicTB.Name = "RegPatronymicTB";
            this.RegPatronymicTB.PlaceholderText = "Отчество";
            this.RegPatronymicTB.Size = new System.Drawing.Size(342, 43);
            this.RegPatronymicTB.TabIndex = 25;
            // 
            // RegSurnameTB
            // 
            this.RegSurnameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegSurnameTB.Location = new System.Drawing.Point(97, 155);
            this.RegSurnameTB.Name = "RegSurnameTB";
            this.RegSurnameTB.PlaceholderText = "Фамилия";
            this.RegSurnameTB.Size = new System.Drawing.Size(342, 43);
            this.RegSurnameTB.TabIndex = 24;
            // 
            // RegNicNameTB
            // 
            this.RegNicNameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegNicNameTB.Location = new System.Drawing.Point(97, 204);
            this.RegNicNameTB.Name = "RegNicNameTB";
            this.RegNicNameTB.PlaceholderText = "Ник";
            this.RegNicNameTB.Size = new System.Drawing.Size(342, 43);
            this.RegNicNameTB.TabIndex = 23;
            // 
            // RegAgeTB
            // 
            this.RegAgeTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegAgeTB.Location = new System.Drawing.Point(97, 302);
            this.RegAgeTB.Name = "RegAgeTB";
            this.RegAgeTB.PlaceholderText = "Возраст";
            this.RegAgeTB.Size = new System.Drawing.Size(342, 43);
            this.RegAgeTB.TabIndex = 22;
            // 
            // RegLoginTB
            // 
            this.RegLoginTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegLoginTB.Location = new System.Drawing.Point(97, 351);
            this.RegLoginTB.Name = "RegLoginTB";
            this.RegLoginTB.PlaceholderText = "Логин";
            this.RegLoginTB.Size = new System.Drawing.Size(342, 43);
            this.RegLoginTB.TabIndex = 21;
            // 
            // RegNameTB
            // 
            this.RegNameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegNameTB.Location = new System.Drawing.Point(97, 57);
            this.RegNameTB.Name = "RegNameTB";
            this.RegNameTB.PlaceholderText = "Имя";
            this.RegNameTB.Size = new System.Drawing.Size(342, 43);
            this.RegNameTB.TabIndex = 20;
            // 
            // AccauntInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 800);
            this.Controls.Add(this.accountInfolabel);
            this.Controls.Add(this.regSexComboBox);
            this.Controls.Add(this.RegPasswordTB);
            this.Controls.Add(this.RegPatronymicTB);
            this.Controls.Add(this.RegSurnameTB);
            this.Controls.Add(this.RegNicNameTB);
            this.Controls.Add(this.RegAgeTB);
            this.Controls.Add(this.RegLoginTB);
            this.Controls.Add(this.RegNameTB);
            this.Name = "AccauntInfoForm";
            this.Text = "AccauntInfoForm";
            this.Load += new System.EventHandler(this.AccauntInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountInfolabel;
        private System.Windows.Forms.ComboBox regSexComboBox;
        private System.Windows.Forms.TextBox RegPasswordTB;
        private System.Windows.Forms.TextBox RegPatronymicTB;
        private System.Windows.Forms.TextBox RegSurnameTB;
        private System.Windows.Forms.TextBox RegNicNameTB;
        private System.Windows.Forms.TextBox RegAgeTB;
        private System.Windows.Forms.TextBox RegLoginTB;
        private System.Windows.Forms.TextBox RegNameTB;
    }
}