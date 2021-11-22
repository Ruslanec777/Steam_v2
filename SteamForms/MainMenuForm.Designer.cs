
namespace SteamForms
{
    partial class MainMenuForm
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
            this.mainMenuUserLabel = new System.Windows.Forms.Label();
            this.mainAccInfoBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuUserLabel
            // 
            this.mainMenuUserLabel.AutoSize = true;
            this.mainMenuUserLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuUserLabel.Location = new System.Drawing.Point(163, 9);
            this.mainMenuUserLabel.Name = "mainMenuUserLabel";
            this.mainMenuUserLabel.Size = new System.Drawing.Size(196, 37);
            this.mainMenuUserLabel.TabIndex = 6;
            this.mainMenuUserLabel.Text = "Главное меню";
            this.mainMenuUserLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            // 
            // mainAccInfoBtn
            // 
            this.mainAccInfoBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainAccInfoBtn.Location = new System.Drawing.Point(163, 49);
            this.mainAccInfoBtn.Name = "mainAccInfoBtn";
            this.mainAccInfoBtn.Size = new System.Drawing.Size(392, 43);
            this.mainAccInfoBtn.TabIndex = 8;
            this.mainAccInfoBtn.Text = "Информация об Аккаунте";
            this.mainAccInfoBtn.UseVisualStyleBackColor = true;
            this.mainAccInfoBtn.Click += new System.EventHandler(this.mainAccInfoBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(163, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(163, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Регистрация";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(163, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Регистрация";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(163, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 43);
            this.button5.TabIndex = 12;
            this.button5.Text = "Регистрация";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 743);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mainMenuUserLabel);
            this.Controls.Add(this.mainAccInfoBtn);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.Shown += new System.EventHandler(this.MainMenuForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuUserLabel;
        private System.Windows.Forms.Button mainAccInfoBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}