
namespace SteamForms
{
    partial class BalancForm
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
            this.balancMenuRemoveManeyBtn = new System.Windows.Forms.Button();
            this.balancMenuLabel = new System.Windows.Forms.Label();
            this.balancMenuAddManeyBtn = new System.Windows.Forms.Button();
            this.balancMenuIdNicNamelabel = new System.Windows.Forms.Label();
            this.balancMenuMAneyForAddTB = new System.Windows.Forms.TextBox();
            this.balancMenuBalInfLabel = new System.Windows.Forms.Label();
            this.balancMenuUserInfolabel = new System.Windows.Forms.Label();
            this.balancMenuBalancLabel = new System.Windows.Forms.Label();
            this.balancMenuMAneyForRemoveTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // balancMenuRemoveManeyBtn
            // 
            this.balancMenuRemoveManeyBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuRemoveManeyBtn.Location = new System.Drawing.Point(76, 348);
            this.balancMenuRemoveManeyBtn.Name = "balancMenuRemoveManeyBtn";
            this.balancMenuRemoveManeyBtn.Size = new System.Drawing.Size(392, 43);
            this.balancMenuRemoveManeyBtn.TabIndex = 18;
            this.balancMenuRemoveManeyBtn.Text = "Вывести деньги ";
            this.balancMenuRemoveManeyBtn.UseVisualStyleBackColor = true;
            this.balancMenuRemoveManeyBtn.Click += new System.EventHandler(this.balancMenuRemoveManeyBtn_Click);
            // 
            // balancMenuLabel
            // 
            this.balancMenuLabel.AutoSize = true;
            this.balancMenuLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuLabel.Location = new System.Drawing.Point(76, 9);
            this.balancMenuLabel.Name = "balancMenuLabel";
            this.balancMenuLabel.Size = new System.Drawing.Size(376, 37);
            this.balancMenuLabel.TabIndex = 13;
            this.balancMenuLabel.Text = "Меню Управления Балансом";
            // 
            // balancMenuAddManeyBtn
            // 
            this.balancMenuAddManeyBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuAddManeyBtn.Location = new System.Drawing.Point(76, 223);
            this.balancMenuAddManeyBtn.Name = "balancMenuAddManeyBtn";
            this.balancMenuAddManeyBtn.Size = new System.Drawing.Size(392, 43);
            this.balancMenuAddManeyBtn.TabIndex = 14;
            this.balancMenuAddManeyBtn.Text = "Внести сумму на баланс";
            this.balancMenuAddManeyBtn.UseVisualStyleBackColor = true;
            this.balancMenuAddManeyBtn.Click += new System.EventHandler(this.balancMenuAddManeyBtn_Click_1);
            // 
            // balancMenuIdNicNamelabel
            // 
            this.balancMenuIdNicNamelabel.AutoSize = true;
            this.balancMenuIdNicNamelabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuIdNicNamelabel.Location = new System.Drawing.Point(76, 83);
            this.balancMenuIdNicNamelabel.Name = "balancMenuIdNicNamelabel";
            this.balancMenuIdNicNamelabel.Size = new System.Drawing.Size(209, 37);
            this.balancMenuIdNicNamelabel.TabIndex = 19;
            this.balancMenuIdNicNamelabel.Text = "Id and NicName";
            // 
            // balancMenuMAneyForAddTB
            // 
            this.balancMenuMAneyForAddTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuMAneyForAddTB.Location = new System.Drawing.Point(76, 272);
            this.balancMenuMAneyForAddTB.Name = "balancMenuMAneyForAddTB";
            this.balancMenuMAneyForAddTB.PlaceholderText = " Сумма для зачисления ";
            this.balancMenuMAneyForAddTB.Size = new System.Drawing.Size(392, 43);
            this.balancMenuMAneyForAddTB.TabIndex = 20;
            this.balancMenuMAneyForAddTB.TextChanged += new System.EventHandler(this.balancMenuManeyForAddTB_TextChanged);
            // 
            // balancMenuBalInfLabel
            // 
            this.balancMenuBalInfLabel.AutoSize = true;
            this.balancMenuBalInfLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuBalInfLabel.Location = new System.Drawing.Point(76, 120);
            this.balancMenuBalInfLabel.Name = "balancMenuBalInfLabel";
            this.balancMenuBalInfLabel.Size = new System.Drawing.Size(222, 37);
            this.balancMenuBalInfLabel.TabIndex = 21;
            this.balancMenuBalInfLabel.Text = "Состояние счета";
            // 
            // balancMenuUserInfolabel
            // 
            this.balancMenuUserInfolabel.AutoSize = true;
            this.balancMenuUserInfolabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuUserInfolabel.Location = new System.Drawing.Point(76, 46);
            this.balancMenuUserInfolabel.Name = "balancMenuUserInfolabel";
            this.balancMenuUserInfolabel.Size = new System.Drawing.Size(181, 37);
            this.balancMenuUserInfolabel.TabIndex = 22;
            this.balancMenuUserInfolabel.Text = "Ползователь:";
            // 
            // balancMenuBalancLabel
            // 
            this.balancMenuBalancLabel.AutoSize = true;
            this.balancMenuBalancLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuBalancLabel.Location = new System.Drawing.Point(76, 157);
            this.balancMenuBalancLabel.Name = "balancMenuBalancLabel";
            this.balancMenuBalancLabel.Size = new System.Drawing.Size(215, 37);
            this.balancMenuBalancLabel.TabIndex = 23;
            this.balancMenuBalancLabel.Text = "Данные из кода";
            // 
            // balancMenuMAneyForRemoveTB
            // 
            this.balancMenuMAneyForRemoveTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balancMenuMAneyForRemoveTB.Location = new System.Drawing.Point(76, 397);
            this.balancMenuMAneyForRemoveTB.Name = "balancMenuMAneyForRemoveTB";
            this.balancMenuMAneyForRemoveTB.PlaceholderText = "Сумма списания с баланса";
            this.balancMenuMAneyForRemoveTB.Size = new System.Drawing.Size(392, 43);
            this.balancMenuMAneyForRemoveTB.TabIndex = 24;
            this.balancMenuMAneyForRemoveTB.TextChanged += new System.EventHandler(this.balancMenuMAneyForRemoveTB_TextChanged);
            // 
            // BalancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.balancMenuMAneyForRemoveTB);
            this.Controls.Add(this.balancMenuBalancLabel);
            this.Controls.Add(this.balancMenuUserInfolabel);
            this.Controls.Add(this.balancMenuBalInfLabel);
            this.Controls.Add(this.balancMenuMAneyForAddTB);
            this.Controls.Add(this.balancMenuIdNicNamelabel);
            this.Controls.Add(this.balancMenuRemoveManeyBtn);
            this.Controls.Add(this.balancMenuLabel);
            this.Controls.Add(this.balancMenuAddManeyBtn);
            this.Name = "BalancForm";
            this.Text = "BalancForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BalancForm_FormClosed);
            this.Load += new System.EventHandler(this.BalancForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button balancMenuRemoveManeyBtn;
        private System.Windows.Forms.Label balancMenuLabel;
        private System.Windows.Forms.Button balancMenuAddManeyBtn;
        private System.Windows.Forms.Label balancMenuIdNicNamelabel;
        private System.Windows.Forms.TextBox balancMenuMAneyForAddTB;
        private System.Windows.Forms.Label balancMenuBalInfLabel;
        private System.Windows.Forms.Label balancMenuUserInfolabel;
        private System.Windows.Forms.Label balancMenuBalancLabel;
        private System.Windows.Forms.TextBox balancMenuMAneyForRemoveTB;
    }
}