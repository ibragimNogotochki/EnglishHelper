
namespace EnglishHelper
{
    public partial class EditForm : Form
    {
        Dictionary dictionary;
        public EditForm(Dictionary dictionary)
        {
            InitializeComponent();
            this.dictionary = dictionary;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            dictionary.AddNode("тест", "test");
            RedrawDict();
        }
        private void RedrawDict()
        {
            ListViewItem newItem;
            this.Editlv.Items.Clear();
            this.Editlv.BeginUpdate();
            for (int i = 0; i < dictionary.GetSize(); i++)
            {
                newItem = this.Editlv.Items.Add(dictionary.GetRuAt(i));
                newItem.SubItems.Add(dictionary.GetEngAt(i));
            }
            this.Editlv.EndUpdate();
        }

        private void EditForm_Shown(object sender, EventArgs e)
        {
            RedrawDict();
        }
    }
}
