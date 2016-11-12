namespace OS_Regedit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел3");
            this._treeView = new System.Windows.Forms.TreeView();
            this._contextTreeViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._fieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextTreeViewMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _treeView
            // 
            this._treeView.ContextMenuStrip = this._contextTreeViewMenuStrip;
            this._treeView.Location = new System.Drawing.Point(0, 36);
            this._treeView.Name = "_treeView";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Узел0";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Узел1";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "Узел2";
            treeNode4.Name = "Узел3";
            treeNode4.Text = "Узел3";
            this._treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this._treeView.Size = new System.Drawing.Size(353, 394);
            this._treeView.TabIndex = 0;
            this._treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._treeView_AfterSelectNode);
            // 
            // _contextTreeViewMenuStrip
            // 
            this._contextTreeViewMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._contextTreeViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНодуToolStripMenuItem,
            this.удалитьНодуToolStripMenuItem});
            this._contextTreeViewMenuStrip.Name = "_contextTreeViewMenuStrip";
            this._contextTreeViewMenuStrip.Size = new System.Drawing.Size(288, 64);
            this._contextTreeViewMenuStrip.Tag = "";
            // 
            // добавитьНодуToolStripMenuItem
            // 
            this.добавитьНодуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРазделToolStripMenuItem,
            this.удалитьРазделToolStripMenuItem});
            this.добавитьНодуToolStripMenuItem.Name = "добавитьНодуToolStripMenuItem";
            this.добавитьНодуToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.добавитьНодуToolStripMenuItem.Text = "Управление разделами";
            // 
            // добавитьРазделToolStripMenuItem
            // 
            this.добавитьРазделToolStripMenuItem.Name = "добавитьРазделToolStripMenuItem";
            this.добавитьРазделToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.добавитьРазделToolStripMenuItem.Text = "Добавить раздел";
            this.добавитьРазделToolStripMenuItem.Click += new System.EventHandler(this.AddNodeTreeViewToolStripMenuItem_Click);
            // 
            // удалитьРазделToolStripMenuItem
            // 
            this.удалитьРазделToolStripMenuItem.Name = "удалитьРазделToolStripMenuItem";
            this.удалитьРазделToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.удалитьРазделToolStripMenuItem.Text = "Удалить раздел";
            this.удалитьРазделToolStripMenuItem.Click += new System.EventHandler(this.RemoveNodeTreeViewToolStripMenuItem_Click);
            // 
            // удалитьНодуToolStripMenuItem
            // 
            this.удалитьНодуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлючToolStripMenuItem});
            this.удалитьНодуToolStripMenuItem.Name = "удалитьНодуToolStripMenuItem";
            this.удалитьНодуToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.удалитьНодуToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.удалитьНодуToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.удалитьНодуToolStripMenuItem.Text = "Управление ключами";
            // 
            // добавитьКлючToolStripMenuItem
            // 
            this.добавитьКлючToolStripMenuItem.Name = "добавитьКлючToolStripMenuItem";
            this.добавитьКлючToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.добавитьКлючToolStripMenuItem.Text = "Добавить ключ";
            this.добавитьКлючToolStripMenuItem.Click += new System.EventHandler(this.AddKeyToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._fieldName,
            this._fieldType,
            this._fieldValue});
            this.dataGridView1.Location = new System.Drawing.Point(346, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(604, 487);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // _fieldName
            // 
            this._fieldName.HeaderText = "Имя";
            this._fieldName.Name = "_fieldName";
            // 
            // _fieldType
            // 
            this._fieldType.HeaderText = "Тип";
            this._fieldType.Name = "_fieldType";
            // 
            // _fieldValue
            // 
            this._fieldValue.HeaderText = "Значение";
            this._fieldValue.Name = "_fieldValue";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveNodesToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.LoadNodesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._treeView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр";
            this._contextTreeViewMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fieldValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _contextTreeViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьНодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлючToolStripMenuItem;
    }
}

