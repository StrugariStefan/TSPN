namespace WinForm
{
    partial class DetaliuComandaForm
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
            this.operatiiGroupBox = new System.Windows.Forms.GroupBox();
            this.operatieComboBox = new System.Windows.Forms.ComboBox();
            this.addOperatieButton = new System.Windows.Forms.Button();
            this.operatieGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireOperatieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialeGroupBox = new System.Windows.Forms.GroupBox();
            this.materialeComboBox = new System.Windows.Forms.ComboBox();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.materialIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAprovizionareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecaniciGroupBox = new System.Windows.Forms.GroupBox();
            this.mecanicComboBox = new System.Windows.Forms.ComboBox();
            this.addMecanicButton = new System.Windows.Forms.Button();
            this.mecanicGridView = new System.Windows.Forms.DataGridView();
            this.mecanicIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeMecanicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeMecanicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imaginiGroupBox = new System.Windows.Forms.GroupBox();
            this.imagineGridView = new System.Windows.Forms.DataGridView();
            this.imagineIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuComandaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereImagineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImagineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ComandNameTextBox = new System.Windows.Forms.TextBox();
            this.operatiiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatieGridView)).BeginInit();
            this.materialeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            this.mecaniciGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecanicGridView)).BeginInit();
            this.imaginiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // operatiiGroupBox
            // 
            this.operatiiGroupBox.Controls.Add(this.operatieComboBox);
            this.operatiiGroupBox.Controls.Add(this.addOperatieButton);
            this.operatiiGroupBox.Controls.Add(this.operatieGridView);
            this.operatiiGroupBox.Location = new System.Drawing.Point(32, 87);
            this.operatiiGroupBox.Name = "operatiiGroupBox";
            this.operatiiGroupBox.Size = new System.Drawing.Size(756, 117);
            this.operatiiGroupBox.TabIndex = 0;
            this.operatiiGroupBox.TabStop = false;
            this.operatiiGroupBox.Text = "Operatii";
            // 
            // operatieComboBox
            // 
            this.operatieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatieComboBox.FormattingEnabled = true;
            this.operatieComboBox.Location = new System.Drawing.Point(6, 35);
            this.operatieComboBox.Name = "operatieComboBox";
            this.operatieComboBox.Size = new System.Drawing.Size(150, 24);
            this.operatieComboBox.TabIndex = 3;
            this.operatieComboBox.Enter += new System.EventHandler(this.operatieComboBox_Enter);
            // 
            // addOperatieButton
            // 
            this.addOperatieButton.Location = new System.Drawing.Point(81, 88);
            this.addOperatieButton.Name = "addOperatieButton";
            this.addOperatieButton.Size = new System.Drawing.Size(75, 23);
            this.addOperatieButton.TabIndex = 2;
            this.addOperatieButton.Text = "Add";
            this.addOperatieButton.UseVisualStyleBackColor = true;
            this.addOperatieButton.Click += new System.EventHandler(this.addOperatieButton_Click);
            // 
            // operatieGridView
            // 
            this.operatieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatieGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.denumireOperatieColumn,
            this.dataGridViewTextBoxColumn27});
            this.operatieGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.operatieGridView.Location = new System.Drawing.Point(166, 10);
            this.operatieGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatieGridView.Name = "operatieGridView";
            this.operatieGridView.RowTemplate.Height = 24;
            this.operatieGridView.Size = new System.Drawing.Size(590, 102);
            this.operatieGridView.TabIndex = 1;
            this.operatieGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.operatieGridView_MouseDown);
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "OperatieId";
            this.dataGridViewTextBoxColumn25.HeaderText = "Id";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 30;
            // 
            // denumireOperatieColumn
            // 
            this.denumireOperatieColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.denumireOperatieColumn.DataPropertyName = "Denumire";
            this.denumireOperatieColumn.HeaderText = "Denumire";
            this.denumireOperatieColumn.MaxInputLength = 256;
            this.denumireOperatieColumn.Name = "denumireOperatieColumn";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "TimpDeExecutie";
            this.dataGridViewTextBoxColumn27.HeaderText = "Timp De Executie";
            this.dataGridViewTextBoxColumn27.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 200;
            // 
            // materialeGroupBox
            // 
            this.materialeGroupBox.Controls.Add(this.materialeComboBox);
            this.materialeGroupBox.Controls.Add(this.addMaterialButton);
            this.materialeGroupBox.Controls.Add(this.materialGridView);
            this.materialeGroupBox.Location = new System.Drawing.Point(32, 210);
            this.materialeGroupBox.Name = "materialeGroupBox";
            this.materialeGroupBox.Size = new System.Drawing.Size(756, 117);
            this.materialeGroupBox.TabIndex = 1;
            this.materialeGroupBox.TabStop = false;
            this.materialeGroupBox.Text = "Materiale";
            // 
            // materialeComboBox
            // 
            this.materialeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialeComboBox.FormattingEnabled = true;
            this.materialeComboBox.Location = new System.Drawing.Point(6, 31);
            this.materialeComboBox.Name = "materialeComboBox";
            this.materialeComboBox.Size = new System.Drawing.Size(150, 24);
            this.materialeComboBox.TabIndex = 4;
            this.materialeComboBox.Enter += new System.EventHandler(this.materialeComboBox_Enter);
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(81, 88);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(75, 23);
            this.addMaterialButton.TabIndex = 3;
            this.addMaterialButton.Text = "Add";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // materialGridView
            // 
            this.materialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIdColumn,
            this.denumireMaterialColumn,
            this.CantitateColumn,
            this.pretColumn,
            this.dataAprovizionareColumn});
            this.materialGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.materialGridView.Location = new System.Drawing.Point(166, 10);
            this.materialGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.RowTemplate.Height = 24;
            this.materialGridView.Size = new System.Drawing.Size(590, 107);
            this.materialGridView.TabIndex = 1;
            this.materialGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGridView_CellContentClick);
            this.materialGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialGridView_MouseDown);
            // 
            // materialIdColumn
            // 
            this.materialIdColumn.DataPropertyName = "MaterialId";
            this.materialIdColumn.HeaderText = "Id";
            this.materialIdColumn.Name = "materialIdColumn";
            this.materialIdColumn.ReadOnly = true;
            this.materialIdColumn.Width = 50;
            // 
            // denumireMaterialColumn
            // 
            this.denumireMaterialColumn.DataPropertyName = "Denumire";
            this.denumireMaterialColumn.HeaderText = "Denumire";
            this.denumireMaterialColumn.MaxInputLength = 50;
            this.denumireMaterialColumn.Name = "denumireMaterialColumn";
            this.denumireMaterialColumn.Width = 200;
            // 
            // CantitateColumn
            // 
            this.CantitateColumn.DataPropertyName = "Cantitate";
            this.CantitateColumn.HeaderText = "Cantitate";
            this.CantitateColumn.MaxInputLength = 13;
            this.CantitateColumn.Name = "CantitateColumn";
            // 
            // pretColumn
            // 
            this.pretColumn.DataPropertyName = "Pret";
            this.pretColumn.HeaderText = "Pret";
            this.pretColumn.MaxInputLength = 13;
            this.pretColumn.Name = "pretColumn";
            // 
            // dataAprovizionareColumn
            // 
            this.dataAprovizionareColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataAprovizionareColumn.DataPropertyName = "DataAprovizionare";
            this.dataAprovizionareColumn.HeaderText = "Data Aprovizionare";
            this.dataAprovizionareColumn.Name = "dataAprovizionareColumn";
            this.dataAprovizionareColumn.ReadOnly = true;
            // 
            // mecaniciGroupBox
            // 
            this.mecaniciGroupBox.Controls.Add(this.mecanicComboBox);
            this.mecaniciGroupBox.Controls.Add(this.addMecanicButton);
            this.mecaniciGroupBox.Controls.Add(this.mecanicGridView);
            this.mecaniciGroupBox.Location = new System.Drawing.Point(32, 333);
            this.mecaniciGroupBox.Name = "mecaniciGroupBox";
            this.mecaniciGroupBox.Size = new System.Drawing.Size(756, 117);
            this.mecaniciGroupBox.TabIndex = 2;
            this.mecaniciGroupBox.TabStop = false;
            this.mecaniciGroupBox.Text = "Mecanici";
            // 
            // mecanicComboBox
            // 
            this.mecanicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mecanicComboBox.FormattingEnabled = true;
            this.mecanicComboBox.Location = new System.Drawing.Point(6, 32);
            this.mecanicComboBox.Name = "mecanicComboBox";
            this.mecanicComboBox.Size = new System.Drawing.Size(150, 24);
            this.mecanicComboBox.TabIndex = 4;
            this.mecanicComboBox.Enter += new System.EventHandler(this.mecanicComboBox_Enter);
            // 
            // addMecanicButton
            // 
            this.addMecanicButton.Location = new System.Drawing.Point(81, 88);
            this.addMecanicButton.Name = "addMecanicButton";
            this.addMecanicButton.Size = new System.Drawing.Size(75, 23);
            this.addMecanicButton.TabIndex = 3;
            this.addMecanicButton.Text = "Add";
            this.addMecanicButton.UseVisualStyleBackColor = true;
            this.addMecanicButton.Click += new System.EventHandler(this.addMecanicButton_Click);
            this.addMecanicButton.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.addMecanicButton_ChangeUICues);
            // 
            // mecanicGridView
            // 
            this.mecanicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mecanicGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mecanicIdColumn,
            this.numeMecanicColumn,
            this.prenumeMecanicColumn});
            this.mecanicGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.mecanicGridView.Location = new System.Drawing.Point(166, 12);
            this.mecanicGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicGridView.Name = "mecanicGridView";
            this.mecanicGridView.RowTemplate.Height = 24;
            this.mecanicGridView.Size = new System.Drawing.Size(590, 106);
            this.mecanicGridView.TabIndex = 1;
            this.mecanicGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mecanicGridView_MouseDown);
            // 
            // mecanicIdColumn
            // 
            this.mecanicIdColumn.DataPropertyName = "MecanicId";
            this.mecanicIdColumn.HeaderText = "Id";
            this.mecanicIdColumn.Name = "mecanicIdColumn";
            this.mecanicIdColumn.ReadOnly = true;
            this.mecanicIdColumn.Width = 30;
            // 
            // numeMecanicColumn
            // 
            this.numeMecanicColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeMecanicColumn.DataPropertyName = "Nume";
            this.numeMecanicColumn.HeaderText = "Nume";
            this.numeMecanicColumn.MaxInputLength = 15;
            this.numeMecanicColumn.Name = "numeMecanicColumn";
            // 
            // prenumeMecanicColumn
            // 
            this.prenumeMecanicColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenumeMecanicColumn.DataPropertyName = "Prenume";
            this.prenumeMecanicColumn.HeaderText = "Prenume";
            this.prenumeMecanicColumn.MaxInputLength = 15;
            this.prenumeMecanicColumn.Name = "prenumeMecanicColumn";
            // 
            // imaginiGroupBox
            // 
            this.imaginiGroupBox.Controls.Add(this.imagineGridView);
            this.imaginiGroupBox.Location = new System.Drawing.Point(32, 456);
            this.imaginiGroupBox.Name = "imaginiGroupBox";
            this.imaginiGroupBox.Size = new System.Drawing.Size(756, 117);
            this.imaginiGroupBox.TabIndex = 3;
            this.imaginiGroupBox.TabStop = false;
            this.imaginiGroupBox.Text = "Imagini";
            // 
            // imagineGridView
            // 
            this.imagineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagineIdColumn,
            this.detaliuComandaColumn,
            this.titluColumn,
            this.descriereImagineColumn,
            this.dataImagineColumn,
            this.fotoColumn});
            this.imagineGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.imagineGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.imagineGridView.Location = new System.Drawing.Point(166, 12);
            this.imagineGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineGridView.Name = "imagineGridView";
            this.imagineGridView.RowTemplate.Height = 24;
            this.imagineGridView.Size = new System.Drawing.Size(590, 105);
            this.imagineGridView.TabIndex = 1;
            // 
            // imagineIdColumn
            // 
            this.imagineIdColumn.DataPropertyName = "ImagineId";
            this.imagineIdColumn.HeaderText = "Id";
            this.imagineIdColumn.Name = "imagineIdColumn";
            this.imagineIdColumn.ReadOnly = true;
            this.imagineIdColumn.Width = 50;
            // 
            // detaliuComandaColumn
            // 
            this.detaliuComandaColumn.DataPropertyName = "DetaliuComanda";
            this.detaliuComandaColumn.HeaderText = "Detaliu Comanda";
            this.detaliuComandaColumn.Name = "detaliuComandaColumn";
            this.detaliuComandaColumn.ReadOnly = true;
            this.detaliuComandaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detaliuComandaColumn.Width = 150;
            // 
            // titluColumn
            // 
            this.titluColumn.DataPropertyName = "Titlu";
            this.titluColumn.HeaderText = "Titlu";
            this.titluColumn.MaxInputLength = 15;
            this.titluColumn.Name = "titluColumn";
            // 
            // descriereImagineColumn
            // 
            this.descriereImagineColumn.DataPropertyName = "Descriere";
            this.descriereImagineColumn.HeaderText = "Descriere";
            this.descriereImagineColumn.MaxInputLength = 256;
            this.descriereImagineColumn.Name = "descriereImagineColumn";
            this.descriereImagineColumn.Width = 250;
            // 
            // dataImagineColumn
            // 
            this.dataImagineColumn.DataPropertyName = "Data";
            this.dataImagineColumn.HeaderText = "Data";
            this.dataImagineColumn.Name = "dataImagineColumn";
            this.dataImagineColumn.ReadOnly = true;
            this.dataImagineColumn.Width = 150;
            // 
            // fotoColumn
            // 
            this.fotoColumn.DataPropertyName = "Foto";
            this.fotoColumn.HeaderText = "Foto";
            this.fotoColumn.Name = "fotoColumn";
            this.fotoColumn.ReadOnly = true;
            this.fotoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fotoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fotoColumn.Width = 200;
            // 
            // ComandNameTextBox
            // 
            this.ComandNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ComandNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComandNameTextBox.Location = new System.Drawing.Point(32, 26);
            this.ComandNameTextBox.Name = "ComandNameTextBox";
            this.ComandNameTextBox.ReadOnly = true;
            this.ComandNameTextBox.Size = new System.Drawing.Size(233, 15);
            this.ComandNameTextBox.TabIndex = 4;
            // 
            // DetaliuComandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.ComandNameTextBox);
            this.Controls.Add(this.imaginiGroupBox);
            this.Controls.Add(this.mecaniciGroupBox);
            this.Controls.Add(this.materialeGroupBox);
            this.Controls.Add(this.operatiiGroupBox);
            this.Name = "DetaliuComandaForm";
            this.Text = "DetaliuComandaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetaliuComandaForm_FormClosing);
            this.operatiiGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatieGridView)).EndInit();
            this.materialeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            this.mecaniciGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mecanicGridView)).EndInit();
            this.imaginiGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox operatiiGroupBox;
        private System.Windows.Forms.GroupBox materialeGroupBox;
        private System.Windows.Forms.GroupBox mecaniciGroupBox;
        private System.Windows.Forms.GroupBox imaginiGroupBox;
        private System.Windows.Forms.DataGridView operatieGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireOperatieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridView materialGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireMaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantitateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAprovizionareColumn;
        private System.Windows.Forms.DataGridView mecanicGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mecanicIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeMecanicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeMecanicColumn;
        private System.Windows.Forms.DataGridView imagineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagineIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliuComandaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereImagineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImagineColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoColumn;
        private System.Windows.Forms.TextBox ComandNameTextBox;
        private System.Windows.Forms.ComboBox operatieComboBox;
        private System.Windows.Forms.Button addOperatieButton;
        private System.Windows.Forms.ComboBox materialeComboBox;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.ComboBox mecanicComboBox;
        private System.Windows.Forms.Button addMecanicButton;
    }
}