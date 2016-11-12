using System.Collections.Generic;
using System.Windows.Forms;

namespace OS_Regedit
{
    public partial class AddKeyForm : Form
    {
        private TreeNode _node;

        public AddKeyForm(TreeNode node)
        {
            InitializeComponent();
            _node = node;
        }

        private void _btAddKey_Click(object sender, System.EventArgs e)
        {
            ((List<Key>)_node.Tag).Add(new Key(_tbName.Text, _cbTypes.Text, _tbValue.Text));
            Close();
        }
    }
}
