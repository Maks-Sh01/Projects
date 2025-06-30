
namespace GameComplexMaksymShatalov
{
    partial class FormSettings
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
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
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
            this.materialButtonBack.Location = new System.Drawing.Point(300, 380);
            this.materialButtonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonBack.Name = "materialButtonBack";
            this.materialButtonBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonBack.Size = new System.Drawing.Size(71, 36);
            this.materialButtonBack.TabIndex = 0;
            this.materialButtonBack.Text = "Назад";
            this.materialButtonBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonBack.UseAccentColor = false;
            this.materialButtonBack.UseVisualStyleBackColor = true;
            this.materialButtonBack.Click += new System.EventHandler(this.materialButtonBack_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(282, 103);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(115, 37);
            this.materialSwitch1.TabIndex = 1;
            this.materialSwitch1.Text = "Темний";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialButtonBack);
            this.Name = "FormSettings";
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonBack;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}