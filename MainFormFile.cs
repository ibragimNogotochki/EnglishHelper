namespace EnglishHelper
{
    public partial class mainForm : Form
    {
        private Dictionary dictionary;
        public mainForm()
        {
            InitializeComponent();
            dictionary = new Dictionary();
        }

        private void DictEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(dictionary);
            editForm.Show();
        }
    }
}
