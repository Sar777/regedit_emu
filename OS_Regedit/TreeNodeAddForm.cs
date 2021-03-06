﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace OS_Regedit
{
    public partial class TreeNodeAddForm : Form
    {
        private readonly TreeNode _node;

        public TreeNodeAddForm(TreeNode node)
        {
            InitializeComponent();
            _node = node;
        }

        private void _btAddNode_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(_tbNodeName.Text))
                return;

            var node = _node.Nodes.Add(_tbNodeName.Text);
            _node.Expand();
            node.Tag = new List<Key>();
            Close();
        }
    }
}
