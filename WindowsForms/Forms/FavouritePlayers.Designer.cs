namespace WindowsForms.Forms
{
    partial class FavouritePlayers
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
            this.panelOtherPlayers = new System.Windows.Forms.Panel();
            this.lbAllPlayers = new System.Windows.Forms.Label();
            this.lbFavouritePlayers = new System.Windows.Forms.Label();
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelOtherPlayers
            // 
            this.panelOtherPlayers.AllowDrop = true;
            this.panelOtherPlayers.Location = new System.Drawing.Point(95, 161);
            this.panelOtherPlayers.Name = "panelOtherPlayers";
            this.panelOtherPlayers.Size = new System.Drawing.Size(355, 302);
            this.panelOtherPlayers.TabIndex = 0;
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.AutoSize = true;
            this.lbAllPlayers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAllPlayers.Location = new System.Drawing.Point(95, 130);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.Size = new System.Drawing.Size(112, 28);
            this.lbAllPlayers.TabIndex = 0;
            this.lbAllPlayers.Text = "All players";
            // 
            // lbFavouritePlayers
            // 
            this.lbFavouritePlayers.AutoSize = true;
            this.lbFavouritePlayers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFavouritePlayers.Location = new System.Drawing.Point(642, 130);
            this.lbFavouritePlayers.Name = "lbFavouritePlayers";
            this.lbFavouritePlayers.Size = new System.Drawing.Size(174, 28);
            this.lbFavouritePlayers.TabIndex = 1;
            this.lbFavouritePlayers.Text = "Favourite players";
            // 
            // panelFavorites
            // 
            this.panelFavorites.AllowDrop = true;
            this.panelFavorites.Location = new System.Drawing.Point(642, 161);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(355, 302);
            this.panelFavorites.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(363, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select 3 favorite players";
            // 
            // FavouritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1113, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFavouritePlayers);
            this.Controls.Add(this.panelFavorites);
            this.Controls.Add(this.lbAllPlayers);
            this.Controls.Add(this.panelOtherPlayers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavouritePlayers";
            this.Text = "Favourite Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelOtherPlayers;
        private Label lbAllPlayers;
        private Label lbFavouritePlayers;
        private Panel panelFavorites;
        private Label label2;
    }
}