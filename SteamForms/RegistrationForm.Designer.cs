
namespace SteamForms
{
    partial class RegistrationForm
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
            this.RegBackBtn = new System.Windows.Forms.Button();
            this.RegNameTB = new System.Windows.Forms.TextBox();
            this.RegLoginTB = new System.Windows.Forms.TextBox();
            this.RegAgeTB = new System.Windows.Forms.TextBox();
            this.RegNicNameTB = new System.Windows.Forms.TextBox();
            this.RegSurnameTB = new System.Windows.Forms.TextBox();
            this.RegPatronymicTB = new System.Windows.Forms.TextBox();
            this.RegPasswordTB = new System.Windows.Forms.TextBox();
            this.regSexComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regTryRegistrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegBackBtn
            // 
            this.RegBackBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegBackBtn.Location = new System.Drawing.Point(97, 491);
            this.RegBackBtn.Name = "RegBackBtn";
            this.RegBackBtn.Size = new System.Drawing.Size(342, 43);
            this.RegBackBtn.TabIndex = 7;
            this.RegBackBtn.Text = "Вернуться к авторизации";
            this.RegBackBtn.UseVisualStyleBackColor = true;
            this.RegBackBtn.Click += new System.EventHandler(this.RegBackBtn_Click);
            // 
            // RegNameTB
            // 
            this.RegNameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegNameTB.Location = new System.Drawing.Point(97, 49);
            this.RegNameTB.Name = "RegNameTB";
            this.RegNameTB.PlaceholderText = "Имя";
            this.RegNameTB.Size = new System.Drawing.Size(342, 43);
            this.RegNameTB.TabIndex = 6;
            this.RegNameTB.TextChanged += new System.EventHandler(this.RegNameTB_TextChanged);
            // 
            // RegLoginTB
            // 
            this.RegLoginTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegLoginTB.Location = new System.Drawing.Point(97, 343);
            this.RegLoginTB.Name = "RegLoginTB";
            this.RegLoginTB.PlaceholderText = "Логин";
            this.RegLoginTB.Size = new System.Drawing.Size(342, 43);
            this.RegLoginTB.TabIndex = 9;
            this.RegLoginTB.TextChanged += new System.EventHandler(this.RegLoginTB_TextChanged);
            // 
            // RegAgeTB
            // 
            this.RegAgeTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegAgeTB.Location = new System.Drawing.Point(97, 294);
            this.RegAgeTB.Name = "RegAgeTB";
            this.RegAgeTB.PlaceholderText = "Возраст";
            this.RegAgeTB.Size = new System.Drawing.Size(342, 43);
            this.RegAgeTB.TabIndex = 12;
            this.RegAgeTB.TextChanged += new System.EventHandler(this.RegAgeTB_TextChanged);
            // 
            // RegNicNameTB
            // 
            this.RegNicNameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegNicNameTB.Location = new System.Drawing.Point(97, 196);
            this.RegNicNameTB.Name = "RegNicNameTB";
            this.RegNicNameTB.PlaceholderText = "Ник";
            this.RegNicNameTB.Size = new System.Drawing.Size(342, 43);
            this.RegNicNameTB.TabIndex = 14;
            // 
            // RegSurnameTB
            // 
            this.RegSurnameTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegSurnameTB.Location = new System.Drawing.Point(97, 147);
            this.RegSurnameTB.Name = "RegSurnameTB";
            this.RegSurnameTB.PlaceholderText = "Фамилия";
            this.RegSurnameTB.Size = new System.Drawing.Size(342, 43);
            this.RegSurnameTB.TabIndex = 15;
            // 
            // RegPatronymicTB
            // 
            this.RegPatronymicTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPatronymicTB.Location = new System.Drawing.Point(97, 98);
            this.RegPatronymicTB.Name = "RegPatronymicTB";
            this.RegPatronymicTB.PlaceholderText = "Отчество";
            this.RegPatronymicTB.Size = new System.Drawing.Size(342, 43);
            this.RegPatronymicTB.TabIndex = 16;
            // 
            // RegPasswordTB
            // 
            this.RegPasswordTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPasswordTB.Location = new System.Drawing.Point(97, 392);
            this.RegPasswordTB.Name = "RegPasswordTB";
            this.RegPasswordTB.PlaceholderText = "Пароль";
            this.RegPasswordTB.Size = new System.Drawing.Size(342, 43);
            this.RegPasswordTB.TabIndex = 17;
            this.RegPasswordTB.UseSystemPasswordChar = true;
            // 
            // regSexComboBox
            // 
            this.regSexComboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regSexComboBox.FormattingEnabled = true;
            this.regSexComboBox.Location = new System.Drawing.Point(97, 245);
            this.regSexComboBox.Name = "regSexComboBox";
            this.regSexComboBox.Size = new System.Drawing.Size(342, 45);
            this.regSexComboBox.TabIndex = 18;
            this.regSexComboBox.Text = "Мужской";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация";
            // 
            // regTryRegistrationBtn
            // 
            this.regTryRegistrationBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regTryRegistrationBtn.Location = new System.Drawing.Point(97, 442);
            this.regTryRegistrationBtn.Name = "regTryRegistrationBtn";
            this.regTryRegistrationBtn.Size = new System.Drawing.Size(342, 43);
            this.regTryRegistrationBtn.TabIndex = 19;
            this.regTryRegistrationBtn.Text = "Регистрируем Аккаунт";
            this.regTryRegistrationBtn.UseVisualStyleBackColor = true;
            this.regTryRegistrationBtn.Click += new System.EventHandler(this.regTryRegistrationBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.regTryRegistrationBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regSexComboBox);
            this.Controls.Add(this.RegPasswordTB);
            this.Controls.Add(this.RegPatronymicTB);
            this.Controls.Add(this.RegSurnameTB);
            this.Controls.Add(this.RegNicNameTB);
            this.Controls.Add(this.RegAgeTB);
            this.Controls.Add(this.RegLoginTB);
            this.Controls.Add(this.RegBackBtn);
            this.Controls.Add(this.RegNameTB);
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RegistrationForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegBackBtn;
        private System.Windows.Forms.TextBox RegNameTB;
        private System.Windows.Forms.TextBox RegLoginTB;
        private System.Windows.Forms.TextBox RegAgeTB;
        private System.Windows.Forms.TextBox RegNicNameTB;
        private System.Windows.Forms.TextBox RegSurnameTB;
        private System.Windows.Forms.TextBox RegPatronymicTB;
        private System.Windows.Forms.TextBox RegPasswordTB;
        private System.Windows.Forms.ComboBox regSexComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regTryRegistrationBtn;
    }
}