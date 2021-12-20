
namespace SteamForms
{
    partial class BasketForm
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
            this.BasketActionLbl = new System.Windows.Forms.Label();
            this.ByGamesBtn = new System.Windows.Forms.Button();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.deleteChosenBtn = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BasketActionLbl
            // 
            this.BasketActionLbl.AutoSize = true;
            this.BasketActionLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BasketActionLbl.Location = new System.Drawing.Point(21, 9);
            this.BasketActionLbl.Name = "BasketActionLbl";
            this.BasketActionLbl.Size = new System.Drawing.Size(410, 46);
            this.BasketActionLbl.TabIndex = 0;
            this.BasketActionLbl.Text = "Стоимость выбранных ";
            this.BasketActionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ByGamesBtn
            // 
            this.ByGamesBtn.AutoSize = true;
            this.ByGamesBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByGamesBtn.Location = new System.Drawing.Point(61, 470);
            this.ByGamesBtn.Name = "ByGamesBtn";
            this.ByGamesBtn.Size = new System.Drawing.Size(171, 56);
            this.ByGamesBtn.TabIndex = 2;
            this.ByGamesBtn.Text = "Купить";
            this.ByGamesBtn.UseVisualStyleBackColor = true;
            this.ByGamesBtn.Click += new System.EventHandler(this.ByGamesBtn_Click);
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceLbl.Location = new System.Drawing.Point(628, 9);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(262, 46);
            this.balanceLbl.TabIndex = 3;
            this.balanceLbl.Text = "Денег на счету";
            this.balanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteChosenBtn
            // 
            this.deleteChosenBtn.AutoSize = true;
            this.deleteChosenBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteChosenBtn.Location = new System.Drawing.Point(333, 470);
            this.deleteChosenBtn.Name = "deleteChosenBtn";
            this.deleteChosenBtn.Size = new System.Drawing.Size(171, 56);
            this.deleteChosenBtn.TabIndex = 4;
            this.deleteChosenBtn.Text = "Удалить";
            this.deleteChosenBtn.UseVisualStyleBackColor = true;
            this.deleteChosenBtn.Click += new System.EventHandler(this.deleteChosenBtn_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(21, 89);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(522, 308);
            this.checkedListBox.TabIndex = 5;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(695, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.deleteChosenBtn);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.ByGamesBtn);
            this.Controls.Add(this.BasketActionLbl);
            this.Name = "BasketForm";
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasketActionLbl;
        private System.Windows.Forms.Button ByGamesBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button deleteChosenBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}