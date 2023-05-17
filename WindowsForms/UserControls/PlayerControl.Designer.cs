namespace WindowsForms.UserControls
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbShirtNumber = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbCapitan = new System.Windows.Forms.Label();
            this.picFavorite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Location = new System.Drawing.Point(51, 43);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(38, 15);
            this.lbPlayerName.TabIndex = 0;
            this.lbPlayerName.Text = "label1";
            // 
            // lbShirtNumber
            // 
            this.lbShirtNumber.AutoSize = true;
            this.lbShirtNumber.Location = new System.Drawing.Point(51, 72);
            this.lbShirtNumber.Name = "lbShirtNumber";
            this.lbShirtNumber.Size = new System.Drawing.Size(38, 15);
            this.lbShirtNumber.TabIndex = 1;
            this.lbShirtNumber.Text = "label2";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(51, 102);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(38, 15);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "label3";
            // 
            // lbCapitan
            // 
            this.lbCapitan.AutoSize = true;
            this.lbCapitan.Location = new System.Drawing.Point(186, 102);
            this.lbCapitan.Name = "lbCapitan";
            this.lbCapitan.Size = new System.Drawing.Size(38, 15);
            this.lbCapitan.TabIndex = 4;
            this.lbCapitan.Text = "label5";
            // 
            // picFavorite
            // 
            this.picFavorite.Location = new System.Drawing.Point(188, 72);
            this.picFavorite.Name = "picFavorite";
            this.picFavorite.Size = new System.Drawing.Size(36, 21);
            this.picFavorite.TabIndex = 5;
            this.picFavorite.TabStop = false;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFavorite);
            this.Controls.Add(this.lbCapitan);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbShirtNumber);
            this.Controls.Add(this.lbPlayerName);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(361, 188);
            ((System.ComponentModel.ISupportInitialize)(this.picFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbPlayerName;
        private Label lbShirtNumber;
        private Label lbPosition;
        private Label lbCapitan;
        private PictureBox picFavorite;
    }
}
