namespace ShatLightStudio
{
    partial class FormCreateHTML
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
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.txtName = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtPath = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreate.Depth = 0;
            this.btnCreate.HighEmphasis = true;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(448, 456);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreate.Size = new System.Drawing.Size(99, 36);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Створити";
            this.btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreate.UseAccentColor = false;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(468, 302);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(79, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Обрати";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(340, 456);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "ㅤНАЗАДㅤ";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtName.Location = new System.Drawing.Point(157, 142);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 32);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Depth = 0;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPath.Location = new System.Drawing.Point(157, 261);
            this.txtPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(390, 32);
            this.txtPath.TabIndex = 18;
            this.txtPath.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(152, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Шлях";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(152, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ім\'я";
            // 
            // FormCreateHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 584);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.materialButton1);
            this.Name = "FormCreateHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення проєкту HTML";
            this.Load += new System.EventHandler(this.FormCreateHTML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}