namespace EnglishHelper
{
    public partial class NodeDialog : Form
    {
        public NodeDialog()
        {
            InitializeComponent();
        }
        public void ShowAndAdd(Dictionary dict)
        {
            this.RuEdit.Text = "";
            this.EngEdit.Text = "";
            this.Text = "Добавление в словарь";

            this.ShowDialog();
            if (this.DialogResult == DialogResult.OK)
                dict.AddNode(RuEdit.Text, EngEdit.Text);
        }
        public void ShowAndEdit(Dictionary dict, int index)
        {
            this.RuEdit.Text = dict.GetRuAt(index);
            this.EngEdit.Text = dict.GetEngAt(index);
            this.Text = "Изменение записи словаря";

            this.ShowDialog();
            if (this.DialogResult == DialogResult.OK)
                dict.ChangeNode(index, EngEdit.Text, RuEdit.Text);
        }
    }
}
