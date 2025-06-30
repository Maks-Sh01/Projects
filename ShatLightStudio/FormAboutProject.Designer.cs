namespace ShatLightStudio
{
    partial class FormAboutProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProject));
            this.materialMultiLineTextBoxAbout = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnOK = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialMultiLineTextBoxAbout
            // 
            this.materialMultiLineTextBoxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialMultiLineTextBoxAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBoxAbout.Depth = 0;
            this.materialMultiLineTextBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBoxAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBoxAbout.Location = new System.Drawing.Point(9, 67);
            this.materialMultiLineTextBoxAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBoxAbout.Name = "materialMultiLineTextBoxAbout";
            this.materialMultiLineTextBoxAbout.Size = new System.Drawing.Size(785, 334);
            this.materialMultiLineTextBoxAbout.TabIndex = 0;
            this.materialMultiLineTextBoxAbout.Text = resources.GetString("materialMultiLineTextBoxAbout.Text");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOK.Depth = 0;
            this.btnOK.HighEmphasis = true;
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(398, 410);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOK.Size = new System.Drawing.Size(64, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOK.UseAccentColor = false;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormAboutProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.materialMultiLineTextBoxAbout);
            this.Name = "FormAboutProject";
            this.Text = "Про проєкт";
            this.Load += new System.EventHandler(this.FormAboutProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBoxAbout;
        private MaterialSkin.Controls.MaterialButton btnOK;
    }
}