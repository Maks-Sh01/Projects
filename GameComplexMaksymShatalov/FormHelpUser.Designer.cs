
namespace GameComplexMaksymShatalov
{
    partial class FormHelpUser
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
            this.materialButtonBack = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialButtonBack
            // 
            this.materialButtonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButtonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonBack.Depth = 0;
            this.materialButtonBack.HighEmphasis = true;
            this.materialButtonBack.Icon = null;
            this.materialButtonBack.Location = new System.Drawing.Point(376, 375);
            this.materialButtonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonBack.Name = "materialButtonBack";
            this.materialButtonBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonBack.Size = new System.Drawing.Size(71, 36);
            this.materialButtonBack.TabIndex = 1;
            this.materialButtonBack.Text = "Назад";
            this.materialButtonBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonBack.UseAccentColor = false;
            this.materialButtonBack.UseVisualStyleBackColor = true;
            this.materialButtonBack.Click += new System.EventHandler(this.materialButtonBack_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(857, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Шановний користувачу! Якщо у Вас виникли будь-які проблеми із додатком, або виник" +
    "ла якась помилка під час ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(845, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "процесу гри,а також є пропозиції як їх можна покращити, то зверніться до мене за " +
    "адресою електронної пошти\r\n";
            // 
            // materialLabelEmail
            // 
            this.materialLabelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabelEmail.AutoSize = true;
            this.materialLabelEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelEmail.Depth = 0;
            this.materialLabelEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.materialLabelEmail.Location = new System.Drawing.Point(28, 136);
            this.materialLabelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmail.Name = "materialLabelEmail";
            this.materialLabelEmail.Size = new System.Drawing.Size(260, 19);
            this.materialLabelEmail.TabIndex = 4;
            this.materialLabelEmail.Text = "Maksym.Shatalov@infiz.khpi.edu.ua";
            this.materialLabelEmail.Click += new System.EventHandler(this.materialLabelEmail_Click);
            // 
            // FormHelpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 467);
            this.Controls.Add(this.materialLabelEmail);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButtonBack);
            this.Name = "FormHelpUser";
            this.Text = "Допомога";
            this.Load += new System.EventHandler(this.FormHelpUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonBack;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmail;
    }
}