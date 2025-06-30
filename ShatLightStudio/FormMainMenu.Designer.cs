namespace ShatLightStudio
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проєктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSharpOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.CppOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПроєктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.виглядToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem});
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.створитиToolStripMenuItem.Text = "Створити";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.проектToolStripMenuItem.Text = "Проєкт";
            this.проектToolStripMenuItem.Click += new System.EventHandler(this.проектToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проєктToolStripMenuItem});
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // проєктToolStripMenuItem
            // 
            this.проєктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSharpOpen,
            this.CppOpen,
            this.HTMLOpen});
            this.проєктToolStripMenuItem.Name = "проєктToolStripMenuItem";
            this.проєктToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.проєктToolStripMenuItem.Text = "Проєкт";
            // 
            // CSharpOpen
            // 
            this.CSharpOpen.Name = "CSharpOpen";
            this.CSharpOpen.Size = new System.Drawing.Size(135, 22);
            this.CSharpOpen.Text = "C# Console";
            this.CSharpOpen.Click += new System.EventHandler(this.CSharpOpen_Click);
            // 
            // CppOpen
            // 
            this.CppOpen.Name = "CppOpen";
            this.CppOpen.Size = new System.Drawing.Size(135, 22);
            this.CppOpen.Text = "C++";
            this.CppOpen.Click += new System.EventHandler(this.CppOpen_Click);
            // 
            // HTMLOpen
            // 
            this.HTMLOpen.Name = "HTMLOpen";
            this.HTMLOpen.Size = new System.Drawing.Size(135, 22);
            this.HTMLOpen.Text = "HTML";
            this.HTMLOpen.Click += new System.EventHandler(this.HTMLOpen_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // виглядToolStripMenuItem
            // 
            this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem});
            this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            this.виглядToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.виглядToolStripMenuItem.Text = "Вигляд";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПроєктToolStripMenuItem,
            this.контактнаІнформаціяToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПроєктToolStripMenuItem
            // 
            this.проПроєктToolStripMenuItem.Name = "проПроєктToolStripMenuItem";
            this.проПроєктToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.проПроєктToolStripMenuItem.Text = "Про проєкт";
            this.проПроєктToolStripMenuItem.Click += new System.EventHandler(this.проПроєктToolStripMenuItem_Click);
            // 
            // контактнаІнформаціяToolStripMenuItem
            // 
            this.контактнаІнформаціяToolStripMenuItem.Name = "контактнаІнформаціяToolStripMenuItem";
            this.контактнаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.контактнаІнформаціяToolStripMenuItem.Text = "Контактна інформація";
            this.контактнаІнформаціяToolStripMenuItem.Click += new System.EventHandler(this.контактнаІнформаціяToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 602);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проєктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПроєктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаІнформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CSharpOpen;
        private System.Windows.Forms.ToolStripMenuItem CppOpen;
        private System.Windows.Forms.ToolStripMenuItem HTMLOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}