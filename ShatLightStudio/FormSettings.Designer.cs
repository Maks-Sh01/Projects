namespace ShatLightStudio
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
            this.Switch_DM = new MaterialSkin.Controls.MaterialSwitch();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.groupBoxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // Switch_DM
            // 
            this.Switch_DM.AutoSize = true;
            this.Switch_DM.Depth = 0;
            this.Switch_DM.Location = new System.Drawing.Point(71, 33);
            this.Switch_DM.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_DM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_DM.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_DM.Name = "Switch_DM";
            this.Switch_DM.Ripple = true;
            this.Switch_DM.Size = new System.Drawing.Size(115, 37);
            this.Switch_DM.TabIndex = 1;
            this.Switch_DM.Text = "Темний";
            this.Switch_DM.UseVisualStyleBackColor = true;
            this.Switch_DM.CheckedChanged += new System.EventHandler(this.Switch_DM_CheckedChanged);
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.Controls.Add(this.Switch_DM);
            this.groupBoxTheme.Location = new System.Drawing.Point(57, 105);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(320, 100);
            this.groupBoxTheme.TabIndex = 2;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "Оформлення";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 375);
            this.Controls.Add(this.groupBoxTheme);
            this.Name = "FormSettings";
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch Switch_DM;
        private System.Windows.Forms.GroupBox groupBoxTheme;
    }
}