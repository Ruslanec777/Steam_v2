
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
            this.mainMenuQuitFromAccBtn = new System.Windows.Forms.Button();
            this.MainMenuGameAreaBtn = new System.Windows.Forms.Button();
            this.mainMenuGameShopBtn = new System.Windows.Forms.Button();
            this.mainBalanceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuUserLabel
            // 
            this.mainMenuUserLabel.AutoSize = true;
            this.mainMenuUserLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuUserLabel.Location = new System.Drawing.Point(62, 9);
            this.mainMenuUserLabel.Name = "mainMenuUserLabel";
            this.mainMenuUserLabel.Size = new System.Drawing.Size(196, 37);
            this.mainMenuUserLabel.TabIndex = 6;
            this.mainMenuUserLabel.Text = "Главное меню";
            // 
            // mainAccInfoBtn
            // 
            this.mainAccInfoBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainAccInfoBtn.Location = new System.Drawing.Point(62, 49);
            this.mainAccInfoBtn.Name = "mainAccInfoBtn";
            this.mainAccInfoBtn.Size = new System.Drawing.Size(392, 43);
            this.mainAccInfoBtn.TabIndex = 8;
            this.mainAccInfoBtn.Text = "Информация об Аккаунте";
            this.mainAccInfoBtn.UseVisualStyleBackColor = true;
            this.mainAccInfoBtn.Click += new System.EventHandler(this.mainAccInfoBtn_Click);
            // 
            // mainMenuQuitFromAccBtn
            // 
            this.mainMenuQuitFromAccBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuQuitFromAccBtn.Location = new System.Drawing.Point(62, 245);
            this.mainMenuQuitFromAccBtn.Name = "mainMenuQuitFromAccBtn";
            this.mainMenuQuitFromAccBtn.Size = new System.Drawing.Size(392, 43);
            this.mainMenuQuitFromAccBtn.TabIndex = 9;
            this.mainMenuQuitFromAccBtn.Text = "Выйти из аккаунта";
            this.mainMenuQuitFromAccBtn.UseVisualStyleBackColor = true;
            this.mainMenuQuitFromAccBtn.Click += new System.EventHandler(this.mainMenuQuitFromAccBtn_Click);
            // 
            // MainMenuGameAreaBtn
            // 
            this.MainMenuGameAreaBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuGameAreaBtn.Location = new System.Drawing.Point(62, 196);
            this.MainMenuGameAreaBtn.Name = "MainMenuGameAreaBtn";
            this.MainMenuGameAreaBtn.Size = new System.Drawing.Size(392, 43);
            this.MainMenuGameAreaBtn.TabIndex = 10;
            this.MainMenuGameAreaBtn.Text = "Игровая зона";
            this.MainMenuGameAreaBtn.UseVisualStyleBackColor = true;
            this.MainMenuGameAreaBtn.Click += new System.EventHandler(this.MainMenuGameAreaBtn_Click);
            // 
            // mainMenuGameShopBtn
            // 
            this.mainMenuGameShopBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuGameShopBtn.Location = new System.Drawing.Point(62, 147);
            this.mainMenuGameShopBtn.Name = "mainMenuGameShopBtn";
            this.mainMenuGameShopBtn.Size = new System.Drawing.Size(392, 43);
            this.mainMenuGameShopBtn.TabIndex = 11;
            this.mainMenuGameShopBtn.Text = "Магазин Игр";
            this.mainMenuGameShopBtn.UseVisualStyleBackColor = true;
            this.mainMenuGameShopBtn.Click += new System.EventHandler(this.mainMenuGameShopBtn_Click);
            // 
            // mainBalanceBtn
            // 
            this.mainBalanceBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainBalanceBtn.Location = new System.Drawing.Point(62, 98);
            this.mainBalanceBtn.Name = "mainBalanceBtn";
            this.mainBalanceBtn.Size = new System.Drawing.Size(392, 43);
            this.mainBalanceBtn.TabIndex = 12;
            this.mainBalanceBtn.Text = "Управление счетом";
            this.mainBalanceBtn.UseVisualStyleBackColor = true;
            this.mainBalanceBtn.Click += new System.EventHandler(this.mainBalanceBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.mainBalanceBtn);
            this.Controls.Add(this.mainMenuGameShopBtn);
            this.Controls.Add(this.MainMenuGameAreaBtn);
            this.Controls.Add(this.mainMenuQuitFromAccBtn);
            this.Controls.Add(this.mainMenuUserLabel);
            this.Controls.Add(this.mainAccInfoBtn);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.Shown += new System.EventHandler(this.MainMenuForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainMenuForm_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuUserLabel;
        private System.Windows.Forms.Button mainAccInfoBtn;
        private System.Windows.Forms.Button mainMenuQuitFromAccBtn;
        private System.Windows.Forms.Button MainMenuGameAreaBtn;
        private System.Windows.Forms.Button mainMenuGameShopBtn;
        private System.Windows.Forms.Button mainBalanceBtn;
    }
}