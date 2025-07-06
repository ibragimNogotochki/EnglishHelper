namespace EnglishHelper
{
    partial class NodeDialog
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
            RuEdit = new TextBox();
            EngEdit = new TextBox();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // RuEdit
            // 
            RuEdit.Location = new Point(12, 12);
            RuEdit.Name = "RuEdit";
            RuEdit.Size = new Size(125, 27);
            RuEdit.TabIndex = 0;
            // 
            // EngEdit
            // 
            EngEdit.Location = new Point(12, 60);
            EngEdit.Name = "EngEdit";
            EngEdit.Size = new Size(125, 27);
            EngEdit.TabIndex = 1;
            // 
            // confirmBtn
            // 
            confirmBtn.DialogResult = DialogResult.OK;
            confirmBtn.Location = new Point(143, 12);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(132, 75);
            confirmBtn.TabIndex = 2;
            confirmBtn.Text = "button1";
            confirmBtn.UseVisualStyleBackColor = true;
            // 
            // NodeDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 103);
            Controls.Add(confirmBtn);
            Controls.Add(EngEdit);
            Controls.Add(RuEdit);
            Name = "NodeDialog";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RuEdit;
        private TextBox EngEdit;
        private Button confirmBtn;
    }
}