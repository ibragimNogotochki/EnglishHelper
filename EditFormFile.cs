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

            if (isDeleting)
            {
                int offset = 0;
                foreach (ListViewItem item in Editlv.Items)
                {
                    if (item.Checked)
                    {
                        dictionary.DelNode(item.Index- offset);
                        offset++;
                    }
                }
                RedrawDict();
            }
            ChangeState((sender as Control)!);
        }
        private void ChangeState(Control sender)
        {
            this.Editlv.CheckBoxes = !isDeleting;
            if (isDeleting) sender.Text = "Удаление";
            else sender.Text = "ОК";
            isDeleting = !isDeleting;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            dialog.ShowAndEdit(dictionary, Editlv.SelectedItems[0].Index);
            RedrawDict();
        }
    }
}
