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
            SuspendLayout();
            // 
            // Editlv
            // 
            Editlv.Columns.AddRange(new ColumnHeader[] { RuHead, EngHead });
            Editlv.Location = new Point(14, 16);
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
            AddBtn.Location = new Point(14, 568);
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
            DelBtn.Location = new Point(106, 568);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(86, 31);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Удаление";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 604);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(Editlv);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Shown += EditForm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ListView Editlv;
        private ColumnHeader RuHead;
        private ColumnHeader EngHead;
        private Button AddBtn;
        private Button DelBtn;
    }
}