namespace OS_Regedit
{
    partial class AddKeyForm
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
            this._btAddKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._tbName = new System.Windows.Forms.TextBox();
            this._tlType = new System.Windows.Forms.Label();
            this._tlValue = new System.Windows.Forms.Label();
            this._tbValue = new System.Windows.Forms.TextBox();
            this._cbTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _btAddKey
            // 
            this._btAddKey.Location = new System.Drawing.Point(107, 152);
            this._btAddKey.Name = "_btAddKey";
            this._btAddKey.Size = new System.Drawing.Size(132, 46);
            this._btAddKey.TabIndex = 0;
            this._btAddKey.Text = "Добавить";
            this._btAddKey.UseVisualStyleBackColor = true;
            this._btAddKey.Click += new System.EventHandler(this._btAddKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // _tbName
            // 
            this._tbName.Location = new System.Drawing.Point(116, 12);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(198, 26);
            this._tbName.TabIndex = 2;
            // 
            // _tlType
            // 
            this._tlType.AutoSize = true;
            this._tlType.Location = new System.Drawing.Point(16, 59);
            this._tlType.Name = "_tlType";
            this._tlType.Size = new System.Drawing.Size(40, 20);
            this._tlType.TabIndex = 3;
            this._tlType.Text = "Тип:";
            // 
            // _tlValue
            // 
            this._tlValue.AutoSize = true;
            this._tlValue.Location = new System.Drawing.Point(12, 104);
            this._tlValue.Name = "_tlValue";
            this._tlValue.Size = new System.Drawing.Size(87, 20);
            this._tlValue.TabIndex = 4;
            this._tlValue.Text = "Значение:";
            // 
            // _tbValue
            // 
            this._tbValue.Location = new System.Drawing.Point(116, 101);
            this._tbValue.Name = "_tbValue";
            this._tbValue.Size = new System.Drawing.Size(198, 26);
            this._tbValue.TabIndex = 5;
            // 
            // _cbTypes
            // 
            this._cbTypes.FormattingEnabled = true;
            this._cbTypes.Items.AddRange(new object[] {
            "REG_SZ",
            "REG_DWORD",
            "REG_BOOL"});
            this._cbTypes.Location = new System.Drawing.Point(116, 54);
            this._cbTypes.Name = "_cbTypes";
            this._cbTypes.Size = new System.Drawing.Size(198, 28);
            this._cbTypes.TabIndex = 6;
            // 
            // AddKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 217);
            this.Controls.Add(this._cbTypes);
            this.Controls.Add(this._tbValue);
            this.Controls.Add(this._tlValue);
            this.Controls.Add(this._tlType);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btAddKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление ключа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btAddKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.Label _tlType;
        private System.Windows.Forms.Label _tlValue;
        private System.Windows.Forms.TextBox _tbValue;
        private System.Windows.Forms.ComboBox _cbTypes;
    }
}