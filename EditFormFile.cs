
namespace EnglishHelper
{
    public partial class EditForm : Form
    {
        private Dictionary dictionary;
        private NodeDialog dialog;
        private bool isDeleting;
        public EditForm(Dictionary dictionary)
        {
            InitializeComponent();
            this.dictionary = dictionary;
            dialog = new NodeDialog();
            isDeleting = false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            dialog.ShowAndAdd(dictionary);
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            this.Editlv.CheckBoxes = !isDeleting;
            if (isDeleting)
            {
                int offset = 0;
                foreach(ListViewItem item in Editlv.Items)
                {
                    if (item.Checked)
                    {
                        dictionary.DelNode(item.Index- offset);
                        offset++;
                    }
                }
                RedrawDict();
                (sender as Control).Text = "Удаление";
            }
            else (sender as Control).Text = "OK";
            isDeleting = !isDeleting;
        }
    }
}
