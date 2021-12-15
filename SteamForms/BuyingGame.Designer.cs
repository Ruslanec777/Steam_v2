
namespace SteamForms
{
    partial class BuyingGame
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
            this.GamePictureBox = new System.Windows.Forms.PictureBox();
            this.RefuseBuyBtn = new System.Windows.Forms.Button();
            this.GameAddBasketBtn = new System.Windows.Forms.Button();
            this.GameNamelabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePictureBox
            // 
            this.GamePictureBox.Location = new System.Drawing.Point(25, 130);
            this.GamePictureBox.Name = "GamePictureBox";
            this.GamePictureBox.Size = new System.Drawing.Size(455, 279);
            this.GamePictureBox.TabIndex = 0;
            this.GamePictureBox.TabStop = false;
            // 
            // RefuseBuyBtn
            // 
            this.RefuseBuyBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefuseBuyBtn.Location = new System.Drawing.Point(25, 559);
            this.RefuseBuyBtn.Name = "RefuseBuyBtn";
            this.RefuseBuyBtn.Size = new System.Drawing.Size(455, 43);
            this.RefuseBuyBtn.TabIndex = 9;
            this.RefuseBuyBtn.Text = "Отказаться от покупки";
            this.RefuseBuyBtn.UseVisualStyleBackColor = true;
            this.RefuseBuyBtn.Click += new System.EventHandler(this.RefuseBuyBtn_Click);
            // 
            // GameAddBasketBtn
            // 
            this.GameAddBasketBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameAddBasketBtn.Location = new System.Drawing.Point(25, 484);
            this.GameAddBasketBtn.Name = "GameAddBasketBtn";
            this.GameAddBasketBtn.Size = new System.Drawing.Size(455, 43);
            this.GameAddBasketBtn.TabIndex = 10;
            this.GameAddBasketBtn.Text = "Добавить в корзину";
            this.GameAddBasketBtn.UseVisualStyleBackColor = true;
            this.GameAddBasketBtn.Click += new System.EventHandler(this.GameAddBasketBtn_Click);
            // 
            // GameNamelabel
            // 
            this.GameNamelabel.AutoSize = true;
            this.GameNamelabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameNamelabel.Location = new System.Drawing.Point(25, 13);
            this.GameNamelabel.Name = "GameNamelabel";
            this.GameNamelabel.Size = new System.Drawing.Size(271, 46);
            this.GameNamelabel.TabIndex = 11;
            this.GameNamelabel.Text = "Название игры";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pricelabel.ForeColor = System.Drawing.Color.Red;
            this.Pricelabel.Location = new System.Drawing.Point(25, 83);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(96, 37);
            this.Pricelabel.TabIndex = 12;
            this.Pricelabel.Text = "label1";
            // 
            // BuyingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.GameNamelabel);
            this.Controls.Add(this.GameAddBasketBtn);
            this.Controls.Add(this.RefuseBuyBtn);
            this.Controls.Add(this.GamePictureBox);
            this.Name = "BuyingGame";
            this.Text = "BuyingGame";
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GamePictureBox;
        private System.Windows.Forms.Button RefuseBuyBtn;
        private System.Windows.Forms.Button GameAddBasketBtn;
        private System.Windows.Forms.Label GameNamelabel;
        private System.Windows.Forms.Label Pricelabel;
    }
}