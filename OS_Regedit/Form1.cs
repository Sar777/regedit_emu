using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OS_Regedit
{
    public partial class Form1 : Form
    {
        public static List<Key> Keys = new List<Key>();

        public Form1()
        {
            InitializeComponent();
            LoadNodes();
        }

        private void AddNodeTreeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TreeNodeAddForm(_treeView.SelectedNode);
            form.ShowDialog(this);
        }

        private void RemoveNodeTreeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _treeView.SelectedNode.Remove();
        }

        private void SaveNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pathes = new List<string>();
            foreach (TreeNode node in _treeView.Nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    pathes.Add(node.FullPath);
                    continue;
                }

                WriteNodeChilds(node, pathes);
            }

            File.WriteAllLines("node.txt", pathes);
            MessageBox.Show(@"Сохранено успешно");
        }

        private void WriteNodeChilds(TreeNode owner, ICollection<string> pathes)
        {
            if (owner.Nodes.Count == 0)
                return;

            foreach (TreeNode child in owner.Nodes)
            {
                var path = child.FullPath;
                var keys = (List<Key>)child.Tag;
                if (keys.Count != 0)
                    path = keys.Aggregate(path, (current, key) => current + (';' + key.ToString()));

                pathes.Add(path);
                WriteNodeChilds(child, pathes);
            }
        }

        private void LoadNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNodes();
            MessageBox.Show(@"Загружено успешно");
        }

        private void LoadNodes()
        {
            _treeView.Nodes.Clear();
            foreach (var path in File.ReadAllLines("node.txt"))
            {
                var splitPath = path.Split('\\').ToList();
                var treeNodes = _treeView.Nodes.Find(splitPath[0], false);
                InsertNode(treeNodes.Length != 0 ? treeNodes.First() : _treeView.Nodes.Add(splitPath[0], splitPath[0]), path.Split('\\').ToList());
            }
        }

        private void InsertNode(TreeNode owner, IList<string> path)
        {
            if (path.Count == 1)
            {
                InsertKey(owner, path[0].Split(';'));
                return;
            }

            path.RemoveAt(0);

            var treeNodes = owner.Nodes.Find(path[0], false);

            var fIdx = path[0].IndexOf(';');
            var nodeName = fIdx != -1 ? path[0].Remove(fIdx) : path[0];
            var treeNode = treeNodes.Length != 0 ? treeNodes.First() : owner.Nodes.Add(nodeName, nodeName);

            treeNode.Tag = new List<Key>();
            InsertNode(treeNode, path);
        }

        private void InsertKey(TreeNode owner, string[] values)
        {
            if (values.Length <= 1)
                return;

            for (var i = 1; i < values.Length; ++i)
            {
                var keyInfo = values[i].Split('-');
                ((List<Key>)owner.Tag).Add(new Key(keyInfo[0], keyInfo[1], keyInfo[2]));
            }
        }

        private void AddKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddKeyForm(_treeView.SelectedNode);
            form.ShowDialog(this);
        }

        private void _treeView_AfterSelectNode(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();
            var selectedNode = _treeView.SelectedNode;
            var keys = (List<Key>)selectedNode.Tag;
            if (keys == null)
                return;

            foreach (var key in keys)
                dataGridView1.Rows.Add(key.Name, key.Type, key.Value);
        }

        private void GetKeysFromTreeNode(TreeNode owner, List<Key> keys)
        {
            if (owner.Nodes.Count == 0)
                return;

            foreach (TreeNode child in owner.Nodes)
            {
                var tempKeys = (List<Key>) child.Tag;
                tempKeys?.CopyTo(keys.ToArray());

                GetKeysFromTreeNode(child, keys);
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dataGridView1.Rows[e.RowIndex].Selected = true;
            dataGridView1.Focus();

            var m = new ContextMenu();
            m.MenuItems.Add(new MenuItem("Удалить", menuItemRemoveKey_Click));
            m.Show(dataGridView1, new Point(e.X, e.Y));
        }

        private void menuItemRemoveKey_Click(object sender, System.EventArgs e)
        {
            var keys = (List<Key>)_treeView.SelectedNode.Tag;
            keys.RemoveAll(x => x.Name.Equals(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.Update();
            dataGridView1.Refresh();

        }
    }
}
