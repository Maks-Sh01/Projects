namespace ShatLightStudio
{
    partial class FormCreatePtoject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreatePtoject));
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listboxchoice = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(7, 275);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(216, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "ㅤㅤㅤㅤㅤㅤДаліㅤㅤㅤㅤㅤ";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "C_Sharp_Icon.png");
            this.imageList1.Images.SetKeyName(1, "Cpp_icon.png");
            this.imageList1.Images.SetKeyName(2, "html_icon.png");
            // 
            // listboxchoice
            // 
            this.listboxchoice.BackColor = System.Drawing.Color.White;
            this.listboxchoice.BorderColor = System.Drawing.Color.LightGray;
            this.listboxchoice.Depth = 0;
            this.listboxchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "c# console";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "c++";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "HTML";
            this.listboxchoice.Items.Add(materialListBoxItem1);
            this.listboxchoice.Items.Add(materialListBoxItem2);
            this.listboxchoice.Items.Add(materialListBoxItem3);
            this.listboxchoice.Location = new System.Drawing.Point(6, 67);
            this.listboxchoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.listboxchoice.Name = "listboxchoice";
            this.listboxchoice.SelectedIndex = -1;
            this.listboxchoice.SelectedItem = null;
            this.listboxchoice.Size = new System.Drawing.Size(217, 199);
            this.listboxchoice.TabIndex = 2;
            // 
            // FormCreatePtoject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 318);
            this.Controls.Add(this.listboxchoice);
            this.Controls.Add(this.btnNext);
            this.Name = "FormCreatePtoject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnNext;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialListBox listboxchoice;
    }
}