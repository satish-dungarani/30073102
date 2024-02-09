namespace PasswordManagerSystem.UI
{
    partial class PasswordGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPasswordGrid = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewPassword = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasswordGrid
            // 
            this.dgvPasswordGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPasswordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.ViewPassword});
            this.dgvPasswordGrid.Location = new System.Drawing.Point(6, 96);
            this.dgvPasswordGrid.Name = "dgvPasswordGrid";
            this.dgvPasswordGrid.RowHeadersWidth = 51;
            this.dgvPasswordGrid.RowTemplate.Height = 24;
            this.dgvPasswordGrid.Size = new System.Drawing.Size(977, 391);
            this.dgvPasswordGrid.TabIndex = 0;
            this.dgvPasswordGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswordGrid_CellContentClick);
            this.dgvPasswordGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvPasswordGrid_ColumnAdded);
            this.dgvPasswordGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPasswordGrid_ColumnHeaderMouseClick);
            this.dgvPasswordGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPasswordGrid_DataBindingComplete);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // ViewPassword
            // 
            this.ViewPassword.HeaderText = "Password";
            this.ViewPassword.MinimumWidth = 6;
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Text = "View";
            this.ViewPassword.UseColumnTextForLinkValue = true;
            this.ViewPassword.Width = 60;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(842, 43);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(141, 34);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.Text = "Add Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.dgvPasswordGrid);
            this.Name = "PasswordGrid";
            this.Size = new System.Drawing.Size(999, 539);
            this.Load += new System.EventHandler(this.PasswordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasswordGrid;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn ViewPassword;
    }
}
