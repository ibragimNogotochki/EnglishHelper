using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
