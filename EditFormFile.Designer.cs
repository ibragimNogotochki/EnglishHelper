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
            SuspendLayout();
            // 
            // Editlv
            // 
            Editlv.Columns.AddRange(new ColumnHeader[] { RuHead, EngHead });
            Editlv.Location = new Point(12, 12);
            Editlv.Name = "Editlv";
            Editlv.Size = new Size(313, 409);
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
            AddBtn.Location = new Point(12, 495);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 530);
            Controls.Add(AddBtn);
            Controls.Add(Editlv);
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
    }
}