namespace OS_Regedit
{
    partial class TreeNodeAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btAddNode = new System.Windows.Forms.Button();
            this._tbNodeName = new System.Windows.Forms.TextBox();
            this._lbNodeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btAddNode
            // 
            this._btAddNode.Location = new System.Drawing.Point(16, 90);
            this._btAddNode.Name = "_btAddNode";
            this._btAddNode.Size = new System.Drawing.Size(208, 57);
            this._btAddNode.TabIndex = 0;
            this._btAddNode.Text = "Добавить";
            this._btAddNode.UseVisualStyleBackColor = true;
            this._btAddNode.Click += new System.EventHandler(this._btAddNode_Click);
            // 
            // _tbNodeName
            // 
            this._tbNodeName.Location = new System.Drawing.Point(62, 32);
            this._tbNodeName.Name = "_tbNodeName";
            this._tbNodeName.Size = new System.Drawing.Size(162, 26);
            this._tbNodeName.TabIndex = 1;
            // 
            // _lbNodeName
            // 
            this._lbNodeName.AutoSize = true;
            this._lbNodeName.Location = new System.Drawing.Point(12, 35);
            this._lbNodeName.Name = "_lbNodeName";
            this._lbNodeName.Size = new System.Drawing.Size(44, 20);
            this._lbNodeName.TabIndex = 2;
            this._lbNodeName.Text = "Имя:";
            // 
            // TreeNodeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 159);
            this.Controls.Add(this._lbNodeName);
            this.Controls.Add(this._tbNodeName);
            this.Controls.Add(this._btAddNode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TreeNodeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление раздела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btAddNode;
        private System.Windows.Forms.TextBox _tbNodeName;
        private System.Windows.Forms.Label _lbNodeName;
    }
}