
namespace SteamForms
{
    partial class GameShopForm
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
            this.gameShopActionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Магазин игр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameShopActionLabel
            // 
            this.gameShopActionLabel.AutoSize = true;
            this.gameShopActionLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameShopActionLabel.Location = new System.Drawing.Point(12, 46);
            this.gameShopActionLabel.Name = "gameShopActionLabel";
            this.gameShopActionLabel.Size = new System.Drawing.Size(360, 37);
            this.gameShopActionLabel.TabIndex = 7;
            this.gameShopActionLabel.Text = "Выберите игру для покупки";
            this.gameShopActionLabel.Click += new System.EventHandler(this.gameShopActionLabel_Click);
            // 
            // GameShopForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.gameShopActionLabel);
            this.Controls.Add(this.label1);
            this.Name = "GameShopForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameShopForm1";
            this.Load += new System.EventHandler(this.GameShopForm1_Load);
            this.Shown += new System.EventHandler(this.GameShopForm1_Shown);
            this.SizeChanged += new System.EventHandler(this.GameShopForm1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameShopActionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}