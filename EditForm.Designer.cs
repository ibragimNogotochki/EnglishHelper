namespace EnglishHelper
{
    partial class EditForm
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
            Editlv = new ListView();
            RuHead = new ColumnHeader();
            EngHead = new ColumnHeader();
            AddBtn = new Button();
            DelBtn = new Button();
            EditButton = new Button();
            menuStrip1 = new MenuStrip();
            FilesToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Editlv
            // 
            Editlv.Columns.AddRange(new ColumnHeader[] { RuHead, EngHead });
            Editlv.Location = new Point(12, 32);
            Editlv.Margin = new Padding(3, 4, 3, 4);
            Editlv.Name = "Editlv";
            Editlv.Size = new Size(357, 544);
            Editlv.TabIndex = 0;
            Editlv.UseCompatibleStateImageBehavior = false;
            Editlv.View = View.Details;
            // 
            // RuHead
            // 
            RuHead.Text = "Русский";
            RuHead.Width = 155;
            // 
            // EngHead
            // 
            EngHead.Text = "Английский";
            EngHead.Width = 155;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 581);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(86, 31);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(104, 581);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(86, 31);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Удаление";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(196, 583);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 7;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FilesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(385, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // FilesToolStripMenuItem
            // 
            FilesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, SaveToolStripMenuItem });
            FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
            FilesToolStripMenuItem.Size = new Size(70, 24);
            FilesToolStripMenuItem.Text = "Файлы";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(224, 26);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(224, 26);
            SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 618);
            Controls.Add(EditButton);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(Editlv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Shown += EditForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView Editlv;
        private ColumnHeader RuHead;
        private ColumnHeader EngHead;
        private Button AddBtn;
        private Button DelBtn;
        private Button EditButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FilesToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
    }
}