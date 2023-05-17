namespace WindowsForms.Forms
{
    partial class SettingsFormTest
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
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatia = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbWomen = new System.Windows.Forms.RadioButton();
            this.rbMen = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.gbLanguage.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbEnglish);
            this.gbLanguage.Controls.Add(this.rbCroatia);
            this.gbLanguage.Location = new System.Drawing.Point(76, 143);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(200, 100);
            this.gbLanguage.TabIndex = 0;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Language";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(22, 56);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(63, 19);
            this.rbEnglish.TabIndex = 1;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatia
            // 
            this.rbCroatia.AutoSize = true;
            this.rbCroatia.Checked = true;
            this.rbCroatia.Location = new System.Drawing.Point(22, 25);
            this.rbCroatia.Name = "rbCroatia";
            this.rbCroatia.Size = new System.Drawing.Size(70, 19);
            this.rbCroatia.TabIndex = 0;
            this.rbCroatia.TabStop = true;
            this.rbCroatia.Text = "Croatian";
            this.rbCroatia.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbWomen);
            this.gbGender.Controls.Add(this.rbMen);
            this.gbGender.Location = new System.Drawing.Point(470, 143);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 100);
            this.gbGender.TabIndex = 1;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbWomen
            // 
            this.rbWomen.AutoSize = true;
            this.rbWomen.Location = new System.Drawing.Point(22, 56);
            this.rbWomen.Name = "rbWomen";
            this.rbWomen.Size = new System.Drawing.Size(67, 19);
            this.rbWomen.TabIndex = 1;
            this.rbWomen.Text = "Women";
            this.rbWomen.UseVisualStyleBackColor = true;
            // 
            // rbMen
            // 
            this.rbMen.AutoSize = true;
            this.rbMen.Checked = true;
            this.rbMen.Location = new System.Drawing.Point(22, 25);
            this.rbMen.Name = "rbMen";
            this.rbMen.Size = new System.Drawing.Size(49, 19);
            this.rbMen.TabIndex = 0;
            this.rbMen.TabStop = true;
            this.rbMen.Text = "Men";
            this.rbMen.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(277, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 78);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(306, 54);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(122, 37);
            this.lblSettings.TabIndex = 9;
            this.lblSettings.Text = "Settings";
            // 
            // SettingsFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbLanguage);
            this.Name = "SettingsFormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsFormTest";
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbLanguage;
        private RadioButton rbEnglish;
        private RadioButton rbCroatia;
        private GroupBox gbGender;
        private RadioButton rbWomen;
        private RadioButton rbMen;
        private Button btnSubmit;
        private Label lblSettings;
    }
}