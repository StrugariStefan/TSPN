namespace WinForm
{
    partial class AutoesForm
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
            this.autoGridView = new System.Windows.Forms.DataGridView();
            this.autoIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarAutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieSasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoGridView
            // 
            this.autoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdColumn,
            this.numarAutoColumn,
            this.serieSasiuColumn,
            this.clientColumn,
            this.sasiuColumn});
            this.autoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.autoGridView.Location = new System.Drawing.Point(0, 0);
            this.autoGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoGridView.Name = "autoGridView";
            this.autoGridView.RowTemplate.Height = 24;
            this.autoGridView.Size = new System.Drawing.Size(611, 280);
            this.autoGridView.TabIndex = 1;
            // 
            // autoIdColumn
            // 
            this.autoIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.autoIdColumn.DataPropertyName = "AutoId";
            this.autoIdColumn.HeaderText = "Id";
            this.autoIdColumn.Name = "autoIdColumn";
            this.autoIdColumn.ReadOnly = true;
            this.autoIdColumn.Width = 50;
            // 
            // numarAutoColumn
            // 
            this.numarAutoColumn.DataPropertyName = "NumarAuto";
            this.numarAutoColumn.HeaderText = "Numar Auto";
            this.numarAutoColumn.MaxInputLength = 10;
            this.numarAutoColumn.Name = "numarAutoColumn";
            // 
            // serieSasiuColumn
            // 
            this.serieSasiuColumn.DataPropertyName = "SerieSasiu";
            this.serieSasiuColumn.HeaderText = "Serie Sasaiu";
            this.serieSasiuColumn.MaxInputLength = 25;
            this.serieSasiuColumn.Name = "serieSasiuColumn";
            this.serieSasiuColumn.Width = 130;
            // 
            // clientColumn
            // 
            this.clientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientColumn.DataPropertyName = "Client";
            this.clientColumn.HeaderText = "Client";
            this.clientColumn.Name = "clientColumn";
            this.clientColumn.ReadOnly = true;
            this.clientColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sasiuColumn
            // 
            this.sasiuColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sasiuColumn.DataPropertyName = "Sasiu";
            this.sasiuColumn.HeaderText = "Sasiu";
            this.sasiuColumn.Name = "sasiuColumn";
            this.sasiuColumn.ReadOnly = true;
            this.sasiuColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sasiuColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AutoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 280);
            this.Controls.Add(this.autoGridView);
            this.Name = "AutoesForm";
            this.Text = "AutoesForm";
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView autoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarAutoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieSasiuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasiuColumn;
    }
}