﻿using System;
using System.Windows.Forms;
using CarServiceAPI.Model;

namespace WinForm
{
    partial class CarServiceForm
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
            this.comandaLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.detaliuCreateButton = new System.Windows.Forms.Button();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.mecanicComboBox = new System.Windows.Forms.ComboBox();
            this.mecanicLabel = new System.Windows.Forms.Label();
            this.comandaComboBox = new System.Windows.Forms.ComboBox();
            this.imagineComboBox = new System.Windows.Forms.ComboBox();
            this.operatirComboBox = new System.Windows.Forms.ComboBox();
            this.imagineLabel = new System.Windows.Forms.Label();
            this.operatieLabel = new System.Windows.Forms.Label();
            this.detaliuGridView = new System.Windows.Forms.DataGridView();
            this.imagineColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatieColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mecanicColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comandaColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detaliuComandaIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagineTab = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.imagineGridView = new System.Windows.Forms.DataGridView();
            this.imagineIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuComandaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereImagineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImagineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.chooseFotoButton = new System.Windows.Forms.Button();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.dataImaginePicker = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.detaliuComandaComboBox = new System.Windows.Forms.ComboBox();
            this.imagineCreateButton = new System.Windows.Forms.Button();
            this.descriereImagineLabel = new System.Windows.Forms.Label();
            this.titluLabel = new System.Windows.Forms.Label();
            this.detatiluComandaLabel = new System.Windows.Forms.Label();
            this.descriereTextBox = new System.Windows.Forms.TextBox();
            this.titluTextBox = new System.Windows.Forms.TextBox();
            this.operatieTab = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.operatieGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireOperatieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.operatieCreateButton = new System.Windows.Forms.Button();
            this.timpDeExecutieLabel = new System.Windows.Forms.Label();
            this.denumireOperatie = new System.Windows.Forms.Label();
            this.timpDeExecutieTextBox = new System.Windows.Forms.TextBox();
            this.denumireOperatieTextBox = new System.Windows.Forms.TextBox();
            this.materialTab = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.materialIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAprovizionareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dataAprovizionarePicker = new System.Windows.Forms.DateTimePicker();
            this.materialCreateButton = new System.Windows.Forms.Button();
            this.dataAprovizionareLabel = new System.Windows.Forms.Label();
            this.pretLabel = new System.Windows.Forms.Label();
            this.cantitateLabel = new System.Windows.Forms.Label();
            this.DenumireMaterialLabel = new System.Windows.Forms.Label();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.denumireMaterialTextBox = new System.Windows.Forms.TextBox();
            this.mecanicTab = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.mecanicGridView = new System.Windows.Forms.DataGridView();
            this.mecanicIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeMecanicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeMecanicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.mecanicCreateButton = new System.Windows.Forms.Button();
            this.prenumeMecanicLabel = new System.Windows.Forms.Label();
            this.numeMecanicLabel = new System.Windows.Forms.Label();
            this.prenumeMecanicTextBox = new System.Windows.Forms.TextBox();
            this.numeMecanicTextBox = new System.Windows.Forms.TextBox();
            this.sasiuTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.sasiuGridView = new System.Windows.Forms.DataGridView();
            this.sasiuIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.sasiuCreateButton = new System.Windows.Forms.Button();
            this.denumireLabel = new System.Windows.Forms.Label();
            this.codSasiuLabel = new System.Windows.Forms.Label();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.codSasiuTextBox = new System.Windows.Forms.TextBox();
            this.comandaTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comandaGridView = new System.Windows.Forms.DataGridView();
            this.comandaIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stareComandaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSystemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProgramareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalizareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmBordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoriPieseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientComandaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stareComandaComboBox = new System.Windows.Forms.ComboBox();
            this.dataFinalizarePicker = new System.Windows.Forms.DateTimePicker();
            this.dataProgramarePicker = new System.Windows.Forms.DateTimePicker();
            this.clientComandaLabel = new System.Windows.Forms.Label();
            this.clientComandaComboBox = new System.Windows.Forms.ComboBox();
            this.autoComboBox = new System.Windows.Forms.ComboBox();
            this.comandaCreateButton = new System.Windows.Forms.Button();
            this.autoLabel = new System.Windows.Forms.Label();
            this.valoarePieseLabel = new System.Windows.Forms.Label();
            this.descriereLabel = new System.Windows.Forms.Label();
            this.kmBordLabel = new System.Windows.Forms.Label();
            this.dataFinalizareLabel = new System.Windows.Forms.Label();
            this.dataProgramareLabel = new System.Windows.Forms.Label();
            this.stareComandaLabel = new System.Windows.Forms.Label();
            this.valoarePieseTextBox = new System.Windows.Forms.TextBox();
            this.descriereComandaTextBox = new System.Windows.Forms.TextBox();
            this.kmBordTextBox = new System.Windows.Forms.TextBox();
            this.autoTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoGridView = new System.Windows.Forms.DataGridView();
            this.autoIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarAutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieSasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SasiuComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.autoCreateButton = new System.Windows.Forms.Button();
            this.sasiuLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.serieSasiuLabel = new System.Windows.Forms.Label();
            this.numarAutoLabel = new System.Windows.Forms.Label();
            this.serieSasiuTextBox = new System.Windows.Forms.TextBox();
            this.numarAutoTextBox = new System.Windows.Forms.TextBox();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.clientCreateButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.judetLabel = new System.Windows.Forms.Label();
            this.localitateLabel = new System.Windows.Forms.Label();
            this.adresaLabel = new System.Windows.Forms.Label();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.judetTextBox = new System.Windows.Forms.TextBox();
            this.localitateTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.generalTabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.detaliuGridView)).BeginInit();
            this.imagineTab.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagineGridView)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.operatieTab.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatieGridView)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.materialTab.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.mecanicTab.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecanicGridView)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.sasiuTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sasiuGridView)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.comandaTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comandaGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.autoTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            this.createGroupBox.SuspendLayout();
            this.generalTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // comandaLabel
            // 
            this.comandaLabel.AutoSize = true;
            this.comandaLabel.Location = new System.Drawing.Point(5, 37);
            this.comandaLabel.Name = "comandaLabel";
            this.comandaLabel.Size = new System.Drawing.Size(68, 17);
            this.comandaLabel.TabIndex = 8;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(5, 102);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(58, 17);
            this.materialLabel.TabIndex = 14;
            // 
            // detaliuCreateButton
            // 
            this.detaliuCreateButton.Location = new System.Drawing.Point(211, 386);
            this.detaliuCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detaliuCreateButton.Name = "detaliuCreateButton";
            this.detaliuCreateButton.Size = new System.Drawing.Size(75, 23);
            this.detaliuCreateButton.TabIndex = 15;
            this.detaliuCreateButton.Text = "Create";
            this.detaliuCreateButton.UseVisualStyleBackColor = true;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(120, 102);
            this.materialComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(164, 25);
            this.materialComboBox.TabIndex = 18;
            // 
            // mecanicComboBox
            // 
            this.mecanicComboBox.FormattingEnabled = true;
            this.mecanicComboBox.Location = new System.Drawing.Point(121, 68);
            this.mecanicComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicComboBox.Name = "mecanicComboBox";
            this.mecanicComboBox.Size = new System.Drawing.Size(164, 25);
            this.mecanicComboBox.TabIndex = 19;
            // 
            // mecanicLabel
            // 
            this.mecanicLabel.AutoSize = true;
            this.mecanicLabel.Location = new System.Drawing.Point(5, 71);
            this.mecanicLabel.Name = "mecanicLabel";
            this.mecanicLabel.Size = new System.Drawing.Size(60, 17);
            this.mecanicLabel.TabIndex = 20;
            // 
            // comandaComboBox
            // 
            this.comandaComboBox.FormattingEnabled = true;
            this.comandaComboBox.Location = new System.Drawing.Point(121, 34);
            this.comandaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comandaComboBox.Name = "comandaComboBox";
            this.comandaComboBox.Size = new System.Drawing.Size(163, 25);
            this.comandaComboBox.TabIndex = 23;
            // 
            // imagineComboBox
            // 
            this.imagineComboBox.FormattingEnabled = true;
            this.imagineComboBox.Location = new System.Drawing.Point(120, 180);
            this.imagineComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineComboBox.Name = "imagineComboBox";
            this.imagineComboBox.Size = new System.Drawing.Size(164, 25);
            this.imagineComboBox.TabIndex = 24;
            // 
            // operatirComboBox
            // 
            this.operatirComboBox.FormattingEnabled = true;
            this.operatirComboBox.Location = new System.Drawing.Point(120, 142);
            this.operatirComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatirComboBox.Name = "operatirComboBox";
            this.operatirComboBox.Size = new System.Drawing.Size(164, 25);
            this.operatirComboBox.TabIndex = 25;
            // 
            // imagineLabel
            // 
            this.imagineLabel.AutoSize = true;
            this.imagineLabel.Location = new System.Drawing.Point(5, 183);
            this.imagineLabel.Name = "imagineLabel";
            this.imagineLabel.Size = new System.Drawing.Size(57, 17);
            this.imagineLabel.TabIndex = 26;
            // 
            // operatieLabel
            // 
            this.operatieLabel.AutoSize = true;
            this.operatieLabel.Location = new System.Drawing.Point(5, 144);
            this.operatieLabel.Name = "operatieLabel";
            this.operatieLabel.Size = new System.Drawing.Size(63, 17);
            this.operatieLabel.TabIndex = 27;
            // 
            // detaliuGridView
            // 
            this.detaliuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detaliuGridView.Location = new System.Drawing.Point(5, 16);
            this.detaliuGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detaliuGridView.Name = "detaliuGridView";
            this.detaliuGridView.RowTemplate.Height = 24;
            this.detaliuGridView.Size = new System.Drawing.Size(771, 406);
            this.detaliuGridView.TabIndex = 0;
            // 
            // imagineColumn
            // 
            this.imagineColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagineColumn.HeaderText = "Imagine";
            this.imagineColumn.Name = "imagineColumn";
            // 
            // operatieColumn
            // 
            this.operatieColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatieColumn.HeaderText = "Operatie";
            this.operatieColumn.Name = "operatieColumn";
            this.operatieColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operatieColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // materialColumn
            // 
            this.materialColumn.HeaderText = "Material";
            this.materialColumn.Name = "materialColumn";
            this.materialColumn.Width = 150;
            // 
            // mecanicColumn
            // 
            this.mecanicColumn.HeaderText = "Mecanic";
            this.mecanicColumn.Name = "mecanicColumn";
            this.mecanicColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mecanicColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mecanicColumn.Width = 150;
            // 
            // comandaColumn
            // 
            this.comandaColumn.HeaderText = "Comanda";
            this.comandaColumn.Name = "comandaColumn";
            this.comandaColumn.ReadOnly = true;
            this.comandaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comandaColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comandaColumn.Width = 150;
            // 
            // detaliuComandaIdColumn
            // 
            this.detaliuComandaIdColumn.HeaderText = "Id";
            this.detaliuComandaIdColumn.Name = "detaliuComandaIdColumn";
            this.detaliuComandaIdColumn.ReadOnly = true;
            this.detaliuComandaIdColumn.Width = 30;
            // 
            // imagineTab
            // 
            this.imagineTab.Controls.Add(this.groupBox15);
            this.imagineTab.Controls.Add(this.groupBox16);
            this.imagineTab.Location = new System.Drawing.Point(4, 25);
            this.imagineTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineTab.Name = "imagineTab";
            this.imagineTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineTab.Size = new System.Drawing.Size(1140, 505);
            this.imagineTab.TabIndex = 8;
            this.imagineTab.Text = "Imagine";
            this.imagineTab.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.imagineGridView);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(294, 2);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.Size = new System.Drawing.Size(843, 501);
            this.groupBox15.TabIndex = 4;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "View";
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
            this.imagineGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagineGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.imagineGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.imagineGridView.Location = new System.Drawing.Point(3, 17);
            this.imagineGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineGridView.Name = "imagineGridView";
            this.imagineGridView.RowTemplate.Height = 24;
            this.imagineGridView.Size = new System.Drawing.Size(837, 482);
            this.imagineGridView.TabIndex = 0;
            this.imagineGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.imagineGridView_CellEndEdit);
            this.imagineGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.imagineGridView_CellValidating);
            this.imagineGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagineGridView_MouseDown);
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
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.chooseFotoButton);
            this.groupBox16.Controls.Add(this.fotoTextBox);
            this.groupBox16.Controls.Add(this.dataImaginePicker);
            this.groupBox16.Controls.Add(this.dataLabel);
            this.groupBox16.Controls.Add(this.detaliuComandaComboBox);
            this.groupBox16.Controls.Add(this.imagineCreateButton);
            this.groupBox16.Controls.Add(this.descriereImagineLabel);
            this.groupBox16.Controls.Add(this.titluLabel);
            this.groupBox16.Controls.Add(this.detatiluComandaLabel);
            this.groupBox16.Controls.Add(this.descriereTextBox);
            this.groupBox16.Controls.Add(this.titluTextBox);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox16.Location = new System.Drawing.Point(3, 2);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox16.Size = new System.Drawing.Size(291, 501);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Creare";
            // 
            // chooseFotoButton
            // 
            this.chooseFotoButton.Location = new System.Drawing.Point(0, 217);
            this.chooseFotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseFotoButton.Name = "chooseFotoButton";
            this.chooseFotoButton.Size = new System.Drawing.Size(97, 23);
            this.chooseFotoButton.TabIndex = 21;
            this.chooseFotoButton.Text = "Choose Foto";
            this.chooseFotoButton.UseVisualStyleBackColor = true;
            this.chooseFotoButton.Click += new System.EventHandler(this.chooseFotoButton_Click);
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.Location = new System.Drawing.Point(120, 217);
            this.fotoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.ReadOnly = true;
            this.fotoTextBox.Size = new System.Drawing.Size(165, 22);
            this.fotoTextBox.TabIndex = 20;
            // 
            // dataImaginePicker
            // 
            this.dataImaginePicker.Location = new System.Drawing.Point(120, 186);
            this.dataImaginePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataImaginePicker.Name = "dataImaginePicker";
            this.dataImaginePicker.Size = new System.Drawing.Size(165, 22);
            this.dataImaginePicker.TabIndex = 18;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(0, 186);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(42, 17);
            this.dataLabel.TabIndex = 17;
            this.dataLabel.Text = "Data ";
            // 
            // detaliuComandaComboBox
            // 
            this.detaliuComandaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.detaliuComandaComboBox.FormattingEnabled = true;
            this.detaliuComandaComboBox.Location = new System.Drawing.Point(120, 32);
            this.detaliuComandaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detaliuComandaComboBox.Name = "detaliuComandaComboBox";
            this.detaliuComandaComboBox.Size = new System.Drawing.Size(165, 24);
            this.detaliuComandaComboBox.TabIndex = 16;
            this.detaliuComandaComboBox.Enter += new System.EventHandler(this.detaliuComandaComboBox_Enter);
            // 
            // imagineCreateButton
            // 
            this.imagineCreateButton.Location = new System.Drawing.Point(195, 274);
            this.imagineCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagineCreateButton.Name = "imagineCreateButton";
            this.imagineCreateButton.Size = new System.Drawing.Size(75, 23);
            this.imagineCreateButton.TabIndex = 15;
            this.imagineCreateButton.Text = "Create";
            this.imagineCreateButton.UseVisualStyleBackColor = true;
            this.imagineCreateButton.Click += new System.EventHandler(this.imagineCreateButton_Click);
            // 
            // descriereImagineLabel
            // 
            this.descriereImagineLabel.AutoSize = true;
            this.descriereImagineLabel.Location = new System.Drawing.Point(0, 91);
            this.descriereImagineLabel.Name = "descriereImagineLabel";
            this.descriereImagineLabel.Size = new System.Drawing.Size(69, 17);
            this.descriereImagineLabel.TabIndex = 10;
            this.descriereImagineLabel.Text = "Descriere";
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.Location = new System.Drawing.Point(0, 66);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(35, 17);
            this.titluLabel.TabIndex = 9;
            this.titluLabel.Text = "Titlu";
            // 
            // detatiluComandaLabel
            // 
            this.detatiluComandaLabel.AutoSize = true;
            this.detatiluComandaLabel.Location = new System.Drawing.Point(0, 32);
            this.detatiluComandaLabel.Name = "detatiluComandaLabel";
            this.detatiluComandaLabel.Size = new System.Drawing.Size(116, 17);
            this.detatiluComandaLabel.TabIndex = 8;
            this.detatiluComandaLabel.Text = "Detaliu Comanda";
            // 
            // descriereTextBox
            // 
            this.descriereTextBox.AcceptsTab = true;
            this.descriereTextBox.Location = new System.Drawing.Point(120, 91);
            this.descriereTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriereTextBox.MaxLength = 256;
            this.descriereTextBox.Multiline = true;
            this.descriereTextBox.Name = "descriereTextBox";
            this.descriereTextBox.Size = new System.Drawing.Size(165, 80);
            this.descriereTextBox.TabIndex = 2;
            // 
            // titluTextBox
            // 
            this.titluTextBox.Location = new System.Drawing.Point(120, 63);
            this.titluTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titluTextBox.MaxLength = 15;
            this.titluTextBox.Name = "titluTextBox";
            this.titluTextBox.Size = new System.Drawing.Size(165, 22);
            this.titluTextBox.TabIndex = 1;
            // 
            // operatieTab
            // 
            this.operatieTab.Controls.Add(this.groupBox13);
            this.operatieTab.Controls.Add(this.groupBox14);
            this.operatieTab.Location = new System.Drawing.Point(4, 25);
            this.operatieTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatieTab.Name = "operatieTab";
            this.operatieTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatieTab.Size = new System.Drawing.Size(1140, 505);
            this.operatieTab.TabIndex = 7;
            this.operatieTab.Text = "Operatie";
            this.operatieTab.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.operatieGridView);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(322, 2);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Size = new System.Drawing.Size(815, 501);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "View";
            // 
            // operatieGridView
            // 
            this.operatieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatieGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.denumireOperatieColumn,
            this.dataGridViewTextBoxColumn27});
            this.operatieGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatieGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.operatieGridView.Location = new System.Drawing.Point(3, 17);
            this.operatieGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatieGridView.Name = "operatieGridView";
            this.operatieGridView.RowTemplate.Height = 24;
            this.operatieGridView.Size = new System.Drawing.Size(809, 482);
            this.operatieGridView.TabIndex = 0;
            this.operatieGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.operatieGridView_CellEndEdit);
            this.operatieGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.operatieGridView_CellValidating);
            this.operatieGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.operatieGridView_EditingControlShowing);
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
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.operatieCreateButton);
            this.groupBox14.Controls.Add(this.timpDeExecutieLabel);
            this.groupBox14.Controls.Add(this.denumireOperatie);
            this.groupBox14.Controls.Add(this.timpDeExecutieTextBox);
            this.groupBox14.Controls.Add(this.denumireOperatieTextBox);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox14.Location = new System.Drawing.Point(3, 2);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Size = new System.Drawing.Size(319, 501);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Creare";
            // 
            // operatieCreateButton
            // 
            this.operatieCreateButton.Location = new System.Drawing.Point(195, 274);
            this.operatieCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatieCreateButton.Name = "operatieCreateButton";
            this.operatieCreateButton.Size = new System.Drawing.Size(75, 23);
            this.operatieCreateButton.TabIndex = 15;
            this.operatieCreateButton.Text = "Create";
            this.operatieCreateButton.UseVisualStyleBackColor = true;
            this.operatieCreateButton.Click += new System.EventHandler(this.operatieCreateButton_Click);
            // 
            // timpDeExecutieLabel
            // 
            this.timpDeExecutieLabel.AutoSize = true;
            this.timpDeExecutieLabel.Location = new System.Drawing.Point(-3, 140);
            this.timpDeExecutieLabel.Name = "timpDeExecutieLabel";
            this.timpDeExecutieLabel.Size = new System.Drawing.Size(116, 17);
            this.timpDeExecutieLabel.TabIndex = 9;
            this.timpDeExecutieLabel.Text = "Timp de Executie";
            // 
            // denumireOperatie
            // 
            this.denumireOperatie.AutoSize = true;
            this.denumireOperatie.Location = new System.Drawing.Point(-3, 38);
            this.denumireOperatie.Name = "denumireOperatie";
            this.denumireOperatie.Size = new System.Drawing.Size(69, 17);
            this.denumireOperatie.TabIndex = 8;
            this.denumireOperatie.Text = "Denumire";
            // 
            // timpDeExecutieTextBox
            // 
            this.timpDeExecutieTextBox.Location = new System.Drawing.Point(115, 140);
            this.timpDeExecutieTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timpDeExecutieTextBox.MaxLength = 9;
            this.timpDeExecutieTextBox.Name = "timpDeExecutieTextBox";
            this.timpDeExecutieTextBox.Size = new System.Drawing.Size(188, 22);
            this.timpDeExecutieTextBox.TabIndex = 1;
            this.timpDeExecutieTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsOnly_KeyPress);
            // 
            // denumireOperatieTextBox
            // 
            this.denumireOperatieTextBox.Location = new System.Drawing.Point(115, 34);
            this.denumireOperatieTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denumireOperatieTextBox.MaxLength = 256;
            this.denumireOperatieTextBox.Multiline = true;
            this.denumireOperatieTextBox.Name = "denumireOperatieTextBox";
            this.denumireOperatieTextBox.Size = new System.Drawing.Size(188, 86);
            this.denumireOperatieTextBox.TabIndex = 0;
            // 
            // materialTab
            // 
            this.materialTab.Controls.Add(this.groupBox11);
            this.materialTab.Controls.Add(this.groupBox12);
            this.materialTab.Location = new System.Drawing.Point(4, 25);
            this.materialTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTab.Name = "materialTab";
            this.materialTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTab.Size = new System.Drawing.Size(1140, 505);
            this.materialTab.TabIndex = 6;
            this.materialTab.Text = "Material";
            this.materialTab.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.materialGridView);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(312, 2);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(825, 501);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "View";
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
            this.materialGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.materialGridView.Location = new System.Drawing.Point(3, 17);
            this.materialGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.RowTemplate.Height = 24;
            this.materialGridView.Size = new System.Drawing.Size(819, 482);
            this.materialGridView.TabIndex = 0;
            this.materialGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGridView_CellEndEdit);
            this.materialGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.materialGridView_CellValidating);
            this.materialGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.materialGridView_EditingControlShowing);
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
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dataAprovizionarePicker);
            this.groupBox12.Controls.Add(this.materialCreateButton);
            this.groupBox12.Controls.Add(this.dataAprovizionareLabel);
            this.groupBox12.Controls.Add(this.pretLabel);
            this.groupBox12.Controls.Add(this.cantitateLabel);
            this.groupBox12.Controls.Add(this.DenumireMaterialLabel);
            this.groupBox12.Controls.Add(this.pretTextBox);
            this.groupBox12.Controls.Add(this.cantitateTextBox);
            this.groupBox12.Controls.Add(this.denumireMaterialTextBox);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.Location = new System.Drawing.Point(3, 2);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Size = new System.Drawing.Size(309, 501);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Creare";
            // 
            // dataAprovizionarePicker
            // 
            this.dataAprovizionarePicker.Location = new System.Drawing.Point(125, 182);
            this.dataAprovizionarePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataAprovizionarePicker.Name = "dataAprovizionarePicker";
            this.dataAprovizionarePicker.Size = new System.Drawing.Size(165, 22);
            this.dataAprovizionarePicker.TabIndex = 16;
            // 
            // materialCreateButton
            // 
            this.materialCreateButton.Location = new System.Drawing.Point(195, 274);
            this.materialCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCreateButton.Name = "materialCreateButton";
            this.materialCreateButton.Size = new System.Drawing.Size(75, 23);
            this.materialCreateButton.TabIndex = 15;
            this.materialCreateButton.Text = "Create";
            this.materialCreateButton.UseVisualStyleBackColor = true;
            this.materialCreateButton.Click += new System.EventHandler(this.materialCreateButton_Click);
            // 
            // dataAprovizionareLabel
            // 
            this.dataAprovizionareLabel.AutoSize = true;
            this.dataAprovizionareLabel.Location = new System.Drawing.Point(5, 153);
            this.dataAprovizionareLabel.Name = "dataAprovizionareLabel";
            this.dataAprovizionareLabel.Size = new System.Drawing.Size(129, 17);
            this.dataAprovizionareLabel.TabIndex = 11;
            this.dataAprovizionareLabel.Text = "Data Aprovizionare";
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.Location = new System.Drawing.Point(5, 98);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(34, 17);
            this.pretLabel.TabIndex = 10;
            this.pretLabel.Text = "Pret";
            // 
            // cantitateLabel
            // 
            this.cantitateLabel.AutoSize = true;
            this.cantitateLabel.Location = new System.Drawing.Point(5, 68);
            this.cantitateLabel.Name = "cantitateLabel";
            this.cantitateLabel.Size = new System.Drawing.Size(64, 17);
            this.cantitateLabel.TabIndex = 9;
            this.cantitateLabel.Text = "Cantitate";
            // 
            // DenumireMaterialLabel
            // 
            this.DenumireMaterialLabel.AutoSize = true;
            this.DenumireMaterialLabel.Location = new System.Drawing.Point(5, 39);
            this.DenumireMaterialLabel.Name = "DenumireMaterialLabel";
            this.DenumireMaterialLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireMaterialLabel.TabIndex = 8;
            this.DenumireMaterialLabel.Text = "Denumire";
            // 
            // pretTextBox
            // 
            this.pretTextBox.AcceptsTab = true;
            this.pretTextBox.Location = new System.Drawing.Point(125, 96);
            this.pretTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pretTextBox.MaxLength = 13;
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(165, 22);
            this.pretTextBox.TabIndex = 2;
            this.pretTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsOnly_KeyPress);
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(125, 63);
            this.cantitateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantitateTextBox.MaxLength = 13;
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(165, 22);
            this.cantitateTextBox.TabIndex = 1;
            this.cantitateTextBox.TextChanged += new System.EventHandler(this.cantitateTextBox_TextChanged);
            this.cantitateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsOnly_KeyPress);
            // 
            // denumireMaterialTextBox
            // 
            this.denumireMaterialTextBox.Location = new System.Drawing.Point(125, 34);
            this.denumireMaterialTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denumireMaterialTextBox.MaxLength = 50;
            this.denumireMaterialTextBox.Name = "denumireMaterialTextBox";
            this.denumireMaterialTextBox.Size = new System.Drawing.Size(165, 22);
            this.denumireMaterialTextBox.TabIndex = 0;
            // 
            // mecanicTab
            // 
            this.mecanicTab.Controls.Add(this.groupBox9);
            this.mecanicTab.Controls.Add(this.groupBox10);
            this.mecanicTab.Location = new System.Drawing.Point(4, 25);
            this.mecanicTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicTab.Name = "mecanicTab";
            this.mecanicTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicTab.Size = new System.Drawing.Size(1140, 505);
            this.mecanicTab.TabIndex = 5;
            this.mecanicTab.Text = "Mecanic";
            this.mecanicTab.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.mecanicGridView);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(294, 2);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(843, 501);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "View";
            // 
            // mecanicGridView
            // 
            this.mecanicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mecanicGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mecanicIdColumn,
            this.numeMecanicColumn,
            this.prenumeMecanicColumn});
            this.mecanicGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mecanicGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.mecanicGridView.Location = new System.Drawing.Point(3, 17);
            this.mecanicGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicGridView.Name = "mecanicGridView";
            this.mecanicGridView.RowTemplate.Height = 24;
            this.mecanicGridView.Size = new System.Drawing.Size(837, 482);
            this.mecanicGridView.TabIndex = 0;
            this.mecanicGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mecanicGridView_CellContentClick);
            this.mecanicGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mecanicGridView_CellDoubleClick);
            this.mecanicGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mecanicGridView_CellEndEdit);
            this.mecanicGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.mecanicGridView_CellValidating);
            this.mecanicGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.mecanicGridView_EditingControlShowing);
            this.mecanicGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mecanicGridView_KeyDown);
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
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.mecanicCreateButton);
            this.groupBox10.Controls.Add(this.prenumeMecanicLabel);
            this.groupBox10.Controls.Add(this.numeMecanicLabel);
            this.groupBox10.Controls.Add(this.prenumeMecanicTextBox);
            this.groupBox10.Controls.Add(this.numeMecanicTextBox);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox10.Location = new System.Drawing.Point(3, 2);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(291, 501);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Creare";
            // 
            // mecanicCreateButton
            // 
            this.mecanicCreateButton.Location = new System.Drawing.Point(195, 274);
            this.mecanicCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecanicCreateButton.Name = "mecanicCreateButton";
            this.mecanicCreateButton.Size = new System.Drawing.Size(75, 23);
            this.mecanicCreateButton.TabIndex = 15;
            this.mecanicCreateButton.Text = "Create";
            this.mecanicCreateButton.UseVisualStyleBackColor = true;
            this.mecanicCreateButton.Click += new System.EventHandler(this.mecanicCreateButton_Click);
            // 
            // prenumeMecanicLabel
            // 
            this.prenumeMecanicLabel.AutoSize = true;
            this.prenumeMecanicLabel.Location = new System.Drawing.Point(27, 68);
            this.prenumeMecanicLabel.Name = "prenumeMecanicLabel";
            this.prenumeMecanicLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeMecanicLabel.TabIndex = 9;
            this.prenumeMecanicLabel.Text = "Prenume";
            // 
            // numeMecanicLabel
            // 
            this.numeMecanicLabel.AutoSize = true;
            this.numeMecanicLabel.Location = new System.Drawing.Point(27, 39);
            this.numeMecanicLabel.Name = "numeMecanicLabel";
            this.numeMecanicLabel.Size = new System.Drawing.Size(45, 17);
            this.numeMecanicLabel.TabIndex = 8;
            this.numeMecanicLabel.Text = "Nume";
            // 
            // prenumeMecanicTextBox
            // 
            this.prenumeMecanicTextBox.Location = new System.Drawing.Point(107, 63);
            this.prenumeMecanicTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prenumeMecanicTextBox.MaxLength = 15;
            this.prenumeMecanicTextBox.Name = "prenumeMecanicTextBox";
            this.prenumeMecanicTextBox.Size = new System.Drawing.Size(165, 22);
            this.prenumeMecanicTextBox.TabIndex = 1;
            this.prenumeMecanicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prenumeMecanic_KeyPress);
            // 
            // numeMecanicTextBox
            // 
            this.numeMecanicTextBox.Location = new System.Drawing.Point(107, 34);
            this.numeMecanicTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeMecanicTextBox.MaxLength = 15;
            this.numeMecanicTextBox.Name = "numeMecanicTextBox";
            this.numeMecanicTextBox.Size = new System.Drawing.Size(165, 22);
            this.numeMecanicTextBox.TabIndex = 0;
            this.numeMecanicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeMecanic_KeyPress);
            // 
            // sasiuTab
            // 
            this.sasiuTab.Controls.Add(this.groupBox7);
            this.sasiuTab.Controls.Add(this.groupBox17);
            this.sasiuTab.Location = new System.Drawing.Point(4, 25);
            this.sasiuTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sasiuTab.Name = "sasiuTab";
            this.sasiuTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sasiuTab.Size = new System.Drawing.Size(1140, 505);
            this.sasiuTab.TabIndex = 4;
            this.sasiuTab.Text = "Sasiu";
            this.sasiuTab.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.sasiuGridView);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(294, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(843, 501);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "View";
            // 
            // sasiuGridView
            // 
            this.sasiuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sasiuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sasiuIdColumn,
            this.codSasiuColumn,
            this.denumireSasiuColumn});
            this.sasiuGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sasiuGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.sasiuGridView.Location = new System.Drawing.Point(3, 17);
            this.sasiuGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sasiuGridView.Name = "sasiuGridView";
            this.sasiuGridView.RowTemplate.Height = 24;
            this.sasiuGridView.Size = new System.Drawing.Size(837, 482);
            this.sasiuGridView.TabIndex = 0;
            this.sasiuGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.sasiuGridView_CellEndEdit);
            this.sasiuGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.sasiuGridView_CellValidating);
            this.sasiuGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.sasiuGridView_EditingControlShowing);
            this.sasiuGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sasiuGridView_KeyDown);
            this.sasiuGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sasiuGridView_MouseDown);
            // 
            // sasiuIdColumn
            // 
            this.sasiuIdColumn.DataPropertyName = "SasiuId";
            this.sasiuIdColumn.HeaderText = "Id";
            this.sasiuIdColumn.Name = "sasiuIdColumn";
            this.sasiuIdColumn.ReadOnly = true;
            // 
            // codSasiuColumn
            // 
            this.codSasiuColumn.DataPropertyName = "CodSasiu";
            this.codSasiuColumn.HeaderText = "Cod Sasiu";
            this.codSasiuColumn.MaxInputLength = 2;
            this.codSasiuColumn.Name = "codSasiuColumn";
            // 
            // denumireSasiuColumn
            // 
            this.denumireSasiuColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.denumireSasiuColumn.DataPropertyName = "Denumire";
            this.denumireSasiuColumn.HeaderText = "Denumire";
            this.denumireSasiuColumn.MaxInputLength = 25;
            this.denumireSasiuColumn.Name = "denumireSasiuColumn";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.sasiuCreateButton);
            this.groupBox17.Controls.Add(this.denumireLabel);
            this.groupBox17.Controls.Add(this.codSasiuLabel);
            this.groupBox17.Controls.Add(this.denumireTextBox);
            this.groupBox17.Controls.Add(this.codSasiuTextBox);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox17.Location = new System.Drawing.Point(3, 2);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox17.Size = new System.Drawing.Size(291, 501);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Creare";
            // 
            // sasiuCreateButton
            // 
            this.sasiuCreateButton.Location = new System.Drawing.Point(195, 274);
            this.sasiuCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sasiuCreateButton.Name = "sasiuCreateButton";
            this.sasiuCreateButton.Size = new System.Drawing.Size(75, 23);
            this.sasiuCreateButton.TabIndex = 15;
            this.sasiuCreateButton.Text = "Create";
            this.sasiuCreateButton.UseVisualStyleBackColor = true;
            this.sasiuCreateButton.Click += new System.EventHandler(this.sasiuCreateButton_Click);
            // 
            // denumireLabel
            // 
            this.denumireLabel.AutoSize = true;
            this.denumireLabel.Location = new System.Drawing.Point(27, 68);
            this.denumireLabel.Name = "denumireLabel";
            this.denumireLabel.Size = new System.Drawing.Size(69, 17);
            this.denumireLabel.TabIndex = 9;
            this.denumireLabel.Text = "Denumire";
            // 
            // codSasiuLabel
            // 
            this.codSasiuLabel.AutoSize = true;
            this.codSasiuLabel.Location = new System.Drawing.Point(27, 39);
            this.codSasiuLabel.Name = "codSasiuLabel";
            this.codSasiuLabel.Size = new System.Drawing.Size(72, 17);
            this.codSasiuLabel.TabIndex = 8;
            this.codSasiuLabel.Text = "Cod Sasiu";
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(107, 63);
            this.denumireTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denumireTextBox.MaxLength = 25;
            this.denumireTextBox.Multiline = true;
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(165, 69);
            this.denumireTextBox.TabIndex = 1;
            // 
            // codSasiuTextBox
            // 
            this.codSasiuTextBox.Location = new System.Drawing.Point(107, 34);
            this.codSasiuTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codSasiuTextBox.MaxLength = 2;
            this.codSasiuTextBox.Name = "codSasiuTextBox";
            this.codSasiuTextBox.Size = new System.Drawing.Size(165, 22);
            this.codSasiuTextBox.TabIndex = 0;
            this.codSasiuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codSasiuTextBox_KeyPress);
            // 
            // comandaTab
            // 
            this.comandaTab.Controls.Add(this.groupBox3);
            this.comandaTab.Controls.Add(this.groupBox4);
            this.comandaTab.Location = new System.Drawing.Point(4, 25);
            this.comandaTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comandaTab.Name = "comandaTab";
            this.comandaTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comandaTab.Size = new System.Drawing.Size(1140, 505);
            this.comandaTab.TabIndex = 2;
            this.comandaTab.Text = "Comanda";
            this.comandaTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comandaGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(294, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(843, 501);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // comandaGridView
            // 
            this.comandaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comandaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comandaIdColumn,
            this.stareComandaColumn,
            this.dataSystemColumn,
            this.dataProgramareColumn,
            this.dataFinalizareColumn,
            this.kmBordColumn,
            this.descriereColumn,
            this.valoriPieseColumn,
            this.clientComandaColumn,
            this.autoColumn});
            this.comandaGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comandaGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.comandaGridView.Location = new System.Drawing.Point(3, 17);
            this.comandaGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comandaGridView.Name = "comandaGridView";
            this.comandaGridView.RowTemplate.Height = 24;
            this.comandaGridView.Size = new System.Drawing.Size(837, 482);
            this.comandaGridView.TabIndex = 0;
            this.comandaGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.comandaGridView_CellEndEdit);
            this.comandaGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.comandaGridView_CellValidating);
            this.comandaGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.comandaGridView_EditingControlShowing);
            this.comandaGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comandaGridView_MouseDown);
            // 
            // comandaIdColumn
            // 
            this.comandaIdColumn.DataPropertyName = "ComandaId";
            this.comandaIdColumn.HeaderText = "Id";
            this.comandaIdColumn.Name = "comandaIdColumn";
            this.comandaIdColumn.ReadOnly = true;
            this.comandaIdColumn.Width = 30;
            // 
            // stareComandaColumn
            // 
            this.stareComandaColumn.DataPropertyName = "StareComanda";
            this.stareComandaColumn.HeaderText = "Stare Comanda";
            this.stareComandaColumn.Name = "stareComandaColumn";
            this.stareComandaColumn.ReadOnly = true;
            this.stareComandaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stareComandaColumn.Width = 150;
            // 
            // dataSystemColumn
            // 
            this.dataSystemColumn.DataPropertyName = "DataSystem";
            this.dataSystemColumn.HeaderText = "Data System";
            this.dataSystemColumn.Name = "dataSystemColumn";
            this.dataSystemColumn.ReadOnly = true;
            this.dataSystemColumn.Width = 150;
            // 
            // dataProgramareColumn
            // 
            this.dataProgramareColumn.DataPropertyName = "DataProgramare";
            this.dataProgramareColumn.HeaderText = "Data Programre";
            this.dataProgramareColumn.Name = "dataProgramareColumn";
            this.dataProgramareColumn.ReadOnly = true;
            this.dataProgramareColumn.Width = 150;
            // 
            // dataFinalizareColumn
            // 
            this.dataFinalizareColumn.DataPropertyName = "DataFinalizare";
            this.dataFinalizareColumn.HeaderText = "Data Finalizare";
            this.dataFinalizareColumn.Name = "dataFinalizareColumn";
            this.dataFinalizareColumn.ReadOnly = true;
            this.dataFinalizareColumn.Width = 150;
            // 
            // kmBordColumn
            // 
            this.kmBordColumn.DataPropertyName = "KmBord";
            this.kmBordColumn.HeaderText = "KmBord";
            this.kmBordColumn.MaxInputLength = 10;
            this.kmBordColumn.Name = "kmBordColumn";
            this.kmBordColumn.Width = 70;
            // 
            // descriereColumn
            // 
            this.descriereColumn.DataPropertyName = "Descriere";
            this.descriereColumn.HeaderText = "Descriere";
            this.descriereColumn.MaxInputLength = 1024;
            this.descriereColumn.Name = "descriereColumn";
            this.descriereColumn.Width = 450;
            // 
            // valoriPieseColumn
            // 
            this.valoriPieseColumn.DataPropertyName = "ValoarePiese";
            this.valoriPieseColumn.HeaderText = "Valoare Piese";
            this.valoriPieseColumn.MaxInputLength = 13;
            this.valoriPieseColumn.Name = "valoriPieseColumn";
            this.valoriPieseColumn.ReadOnly = true;
            // 
            // clientComandaColumn
            // 
            this.clientComandaColumn.DataPropertyName = "Client";
            this.clientComandaColumn.HeaderText = "Client";
            this.clientComandaColumn.Name = "clientComandaColumn";
            this.clientComandaColumn.ReadOnly = true;
            this.clientComandaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // autoColumn
            // 
            this.autoColumn.DataPropertyName = "Auto";
            this.autoColumn.HeaderText = "Auto";
            this.autoColumn.Name = "autoColumn";
            this.autoColumn.ReadOnly = true;
            this.autoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stareComandaComboBox);
            this.groupBox4.Controls.Add(this.dataFinalizarePicker);
            this.groupBox4.Controls.Add(this.dataProgramarePicker);
            this.groupBox4.Controls.Add(this.clientComandaLabel);
            this.groupBox4.Controls.Add(this.clientComandaComboBox);
            this.groupBox4.Controls.Add(this.autoComboBox);
            this.groupBox4.Controls.Add(this.comandaCreateButton);
            this.groupBox4.Controls.Add(this.autoLabel);
            this.groupBox4.Controls.Add(this.valoarePieseLabel);
            this.groupBox4.Controls.Add(this.descriereLabel);
            this.groupBox4.Controls.Add(this.kmBordLabel);
            this.groupBox4.Controls.Add(this.dataFinalizareLabel);
            this.groupBox4.Controls.Add(this.dataProgramareLabel);
            this.groupBox4.Controls.Add(this.stareComandaLabel);
            this.groupBox4.Controls.Add(this.valoarePieseTextBox);
            this.groupBox4.Controls.Add(this.descriereComandaTextBox);
            this.groupBox4.Controls.Add(this.kmBordTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(291, 501);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Creare";
            // 
            // stareComandaComboBox
            // 
            this.stareComandaComboBox.DataSource = new CarServiceAPI.Model.Stare[] {
        CarServiceAPI.Model.Stare.inAsteptare,
        CarServiceAPI.Model.Stare.executata,
        CarServiceAPI.Model.Stare.refuzataLaExecutie};
            this.stareComandaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stareComandaComboBox.Location = new System.Drawing.Point(121, 34);
            this.stareComandaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stareComandaComboBox.Name = "stareComandaComboBox";
            this.stareComandaComboBox.Size = new System.Drawing.Size(163, 24);
            this.stareComandaComboBox.TabIndex = 23;
            this.stareComandaComboBox.Visible = false;
            // 
            // dataFinalizarePicker
            // 
            this.dataFinalizarePicker.Location = new System.Drawing.Point(120, 111);
            this.dataFinalizarePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataFinalizarePicker.Name = "dataFinalizarePicker";
            this.dataFinalizarePicker.Size = new System.Drawing.Size(164, 22);
            this.dataFinalizarePicker.TabIndex = 22;
            // 
            // dataProgramarePicker
            // 
            this.dataProgramarePicker.Location = new System.Drawing.Point(121, 78);
            this.dataProgramarePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataProgramarePicker.Name = "dataProgramarePicker";
            this.dataProgramarePicker.Size = new System.Drawing.Size(164, 22);
            this.dataProgramarePicker.TabIndex = 21;
            // 
            // clientComandaLabel
            // 
            this.clientComandaLabel.AutoSize = true;
            this.clientComandaLabel.Location = new System.Drawing.Point(5, 303);
            this.clientComandaLabel.Name = "clientComandaLabel";
            this.clientComandaLabel.Size = new System.Drawing.Size(43, 17);
            this.clientComandaLabel.TabIndex = 20;
            this.clientComandaLabel.Text = "Client";
            // 
            // clientComandaComboBox
            // 
            this.clientComandaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComandaComboBox.FormattingEnabled = true;
            this.clientComandaComboBox.Location = new System.Drawing.Point(121, 300);
            this.clientComandaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientComandaComboBox.Name = "clientComandaComboBox";
            this.clientComandaComboBox.Size = new System.Drawing.Size(164, 24);
            this.clientComandaComboBox.TabIndex = 19;
            this.clientComandaComboBox.SelectedIndexChanged += new System.EventHandler(this.clientComandaComboBox_SelectedIndexChanged);
            this.clientComandaComboBox.Enter += new System.EventHandler(this.clientComandaComboBox_Enter);
            // 
            // autoComboBox
            // 
            this.autoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoComboBox.FormattingEnabled = true;
            this.autoComboBox.Location = new System.Drawing.Point(121, 331);
            this.autoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoComboBox.Name = "autoComboBox";
            this.autoComboBox.Size = new System.Drawing.Size(164, 24);
            this.autoComboBox.TabIndex = 18;
            this.autoComboBox.Enter += new System.EventHandler(this.autoComboBox_Enter);
            // 
            // comandaCreateButton
            // 
            this.comandaCreateButton.Location = new System.Drawing.Point(197, 364);
            this.comandaCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comandaCreateButton.Name = "comandaCreateButton";
            this.comandaCreateButton.Size = new System.Drawing.Size(75, 23);
            this.comandaCreateButton.TabIndex = 15;
            this.comandaCreateButton.Text = "Create";
            this.comandaCreateButton.UseVisualStyleBackColor = true;
            this.comandaCreateButton.Click += new System.EventHandler(this.comandaCreateButton_Click);
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(5, 334);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(37, 17);
            this.autoLabel.TabIndex = 14;
            this.autoLabel.Text = "Auto";
            // 
            // valoarePieseLabel
            // 
            this.valoarePieseLabel.AutoSize = true;
            this.valoarePieseLabel.Location = new System.Drawing.Point(5, 276);
            this.valoarePieseLabel.Name = "valoarePieseLabel";
            this.valoarePieseLabel.Size = new System.Drawing.Size(96, 17);
            this.valoarePieseLabel.TabIndex = 13;
            this.valoarePieseLabel.Text = "Valoare Piese";
            this.valoarePieseLabel.Visible = false;
            // 
            // descriereLabel
            // 
            this.descriereLabel.AutoSize = true;
            this.descriereLabel.Location = new System.Drawing.Point(5, 175);
            this.descriereLabel.Name = "descriereLabel";
            this.descriereLabel.Size = new System.Drawing.Size(69, 17);
            this.descriereLabel.TabIndex = 12;
            this.descriereLabel.Text = "Descriere";
            // 
            // kmBordLabel
            // 
            this.kmBordLabel.AutoSize = true;
            this.kmBordLabel.Location = new System.Drawing.Point(5, 145);
            this.kmBordLabel.Name = "kmBordLabel";
            this.kmBordLabel.Size = new System.Drawing.Size(58, 17);
            this.kmBordLabel.TabIndex = 11;
            this.kmBordLabel.Text = "KmBord";
            // 
            // dataFinalizareLabel
            // 
            this.dataFinalizareLabel.AutoSize = true;
            this.dataFinalizareLabel.Location = new System.Drawing.Point(5, 116);
            this.dataFinalizareLabel.Name = "dataFinalizareLabel";
            this.dataFinalizareLabel.Size = new System.Drawing.Size(103, 17);
            this.dataFinalizareLabel.TabIndex = 10;
            this.dataFinalizareLabel.Text = "Data Finalizare";
            // 
            // dataProgramareLabel
            // 
            this.dataProgramareLabel.AutoSize = true;
            this.dataProgramareLabel.Location = new System.Drawing.Point(5, 82);
            this.dataProgramareLabel.Name = "dataProgramareLabel";
            this.dataProgramareLabel.Size = new System.Drawing.Size(117, 17);
            this.dataProgramareLabel.TabIndex = 9;
            this.dataProgramareLabel.Text = "Data Programare";
            // 
            // stareComandaLabel
            // 
            this.stareComandaLabel.AutoSize = true;
            this.stareComandaLabel.Location = new System.Drawing.Point(5, 37);
            this.stareComandaLabel.Name = "stareComandaLabel";
            this.stareComandaLabel.Size = new System.Drawing.Size(106, 17);
            this.stareComandaLabel.TabIndex = 8;
            this.stareComandaLabel.Text = "Stare Comanda";
            this.stareComandaLabel.Visible = false;
            this.stareComandaLabel.Click += new System.EventHandler(this.stareComandaLabel_Click);
            // 
            // valoarePieseTextBox
            // 
            this.valoarePieseTextBox.Location = new System.Drawing.Point(120, 273);
            this.valoarePieseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valoarePieseTextBox.MaxLength = 13;
            this.valoarePieseTextBox.Name = "valoarePieseTextBox";
            this.valoarePieseTextBox.Size = new System.Drawing.Size(165, 22);
            this.valoarePieseTextBox.TabIndex = 5;
            this.valoarePieseTextBox.Visible = false;
            this.valoarePieseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsOnly_KeyPress);
            // 
            // descriereComandaTextBox
            // 
            this.descriereComandaTextBox.Location = new System.Drawing.Point(120, 172);
            this.descriereComandaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriereComandaTextBox.MaxLength = 1024;
            this.descriereComandaTextBox.Multiline = true;
            this.descriereComandaTextBox.Name = "descriereComandaTextBox";
            this.descriereComandaTextBox.Size = new System.Drawing.Size(165, 95);
            this.descriereComandaTextBox.TabIndex = 4;
            // 
            // kmBordTextBox
            // 
            this.kmBordTextBox.Location = new System.Drawing.Point(120, 142);
            this.kmBordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kmBordTextBox.MaxLength = 10;
            this.kmBordTextBox.Name = "kmBordTextBox";
            this.kmBordTextBox.Size = new System.Drawing.Size(165, 22);
            this.kmBordTextBox.TabIndex = 3;
            this.kmBordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kmBordTextBox_KeyPress);
            // 
            // autoTab
            // 
            this.autoTab.Controls.Add(this.groupBox1);
            this.autoTab.Controls.Add(this.groupBox2);
            this.autoTab.Location = new System.Drawing.Point(4, 25);
            this.autoTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoTab.Name = "autoTab";
            this.autoTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoTab.Size = new System.Drawing.Size(1140, 505);
            this.autoTab.TabIndex = 1;
            this.autoTab.Text = "Auto";
            this.autoTab.UseVisualStyleBackColor = true;
            this.autoTab.Click += new System.EventHandler(this.autoTab_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(294, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(843, 501);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
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
            this.autoGridView.Location = new System.Drawing.Point(3, 17);
            this.autoGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoGridView.Name = "autoGridView";
            this.autoGridView.RowTemplate.Height = 24;
            this.autoGridView.Size = new System.Drawing.Size(837, 482);
            this.autoGridView.TabIndex = 0;
            this.autoGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoGridView_CellEndEdit);
            this.autoGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.autoGridView_CellValidating);
            this.autoGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.autoGridView_EditingControlShowing);
            this.autoGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.autoGridView_MouseDown);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SasiuComboBox);
            this.groupBox2.Controls.Add(this.clientComboBox);
            this.groupBox2.Controls.Add(this.autoCreateButton);
            this.groupBox2.Controls.Add(this.sasiuLabel);
            this.groupBox2.Controls.Add(this.clientLabel);
            this.groupBox2.Controls.Add(this.serieSasiuLabel);
            this.groupBox2.Controls.Add(this.numarAutoLabel);
            this.groupBox2.Controls.Add(this.serieSasiuTextBox);
            this.groupBox2.Controls.Add(this.numarAutoTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 501);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creare";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // SasiuComboBox
            // 
            this.SasiuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SasiuComboBox.FormattingEnabled = true;
            this.SasiuComboBox.Location = new System.Drawing.Point(109, 146);
            this.SasiuComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SasiuComboBox.Name = "SasiuComboBox";
            this.SasiuComboBox.Size = new System.Drawing.Size(164, 24);
            this.SasiuComboBox.TabIndex = 17;
            this.SasiuComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.SasiuComboBox.Enter += new System.EventHandler(this.SasiuComboBox_Enter);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(109, 96);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(164, 24);
            this.clientComboBox.TabIndex = 16;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.clientComboBox.Enter += new System.EventHandler(this.clientComboBox_Enter);
            // 
            // autoCreateButton
            // 
            this.autoCreateButton.Location = new System.Drawing.Point(195, 274);
            this.autoCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoCreateButton.Name = "autoCreateButton";
            this.autoCreateButton.Size = new System.Drawing.Size(75, 23);
            this.autoCreateButton.TabIndex = 15;
            this.autoCreateButton.Text = "Create";
            this.autoCreateButton.UseVisualStyleBackColor = true;
            this.autoCreateButton.Click += new System.EventHandler(this.autoCreateButton_Click);
            // 
            // sasiuLabel
            // 
            this.sasiuLabel.AutoSize = true;
            this.sasiuLabel.Location = new System.Drawing.Point(27, 149);
            this.sasiuLabel.Name = "sasiuLabel";
            this.sasiuLabel.Size = new System.Drawing.Size(43, 17);
            this.sasiuLabel.TabIndex = 11;
            this.sasiuLabel.Text = "Sasiu";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(27, 96);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(43, 17);
            this.clientLabel.TabIndex = 10;
            this.clientLabel.Text = "Client";
            // 
            // serieSasiuLabel
            // 
            this.serieSasiuLabel.AutoSize = true;
            this.serieSasiuLabel.Location = new System.Drawing.Point(27, 68);
            this.serieSasiuLabel.Name = "serieSasiuLabel";
            this.serieSasiuLabel.Size = new System.Drawing.Size(80, 17);
            this.serieSasiuLabel.TabIndex = 9;
            this.serieSasiuLabel.Text = "Serie Sasiu";
            // 
            // numarAutoLabel
            // 
            this.numarAutoLabel.AutoSize = true;
            this.numarAutoLabel.Location = new System.Drawing.Point(27, 39);
            this.numarAutoLabel.Name = "numarAutoLabel";
            this.numarAutoLabel.Size = new System.Drawing.Size(83, 17);
            this.numarAutoLabel.TabIndex = 8;
            this.numarAutoLabel.Text = "Numar Auto";
            // 
            // serieSasiuTextBox
            // 
            this.serieSasiuTextBox.Location = new System.Drawing.Point(109, 63);
            this.serieSasiuTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serieSasiuTextBox.MaxLength = 25;
            this.serieSasiuTextBox.Name = "serieSasiuTextBox";
            this.serieSasiuTextBox.Size = new System.Drawing.Size(164, 22);
            this.serieSasiuTextBox.TabIndex = 1;
            this.serieSasiuTextBox.TextChanged += new System.EventHandler(this.serieSasiuTextBox_TextChanged);
            this.serieSasiuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upperOnly_KeyPress);
            // 
            // numarAutoTextBox
            // 
            this.numarAutoTextBox.Location = new System.Drawing.Point(109, 34);
            this.numarAutoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numarAutoTextBox.MaxLength = 10;
            this.numarAutoTextBox.Name = "numarAutoTextBox";
            this.numarAutoTextBox.Size = new System.Drawing.Size(164, 22);
            this.numarAutoTextBox.TabIndex = 0;
            this.numarAutoTextBox.TextChanged += new System.EventHandler(this.numarAutoTextBox_TextChanged);
            this.numarAutoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numarAutoTextBox_KeyPress);
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.viewGroupBox);
            this.clientTab.Controls.Add(this.createGroupBox);
            this.clientTab.Location = new System.Drawing.Point(4, 25);
            this.clientTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientTab.Size = new System.Drawing.Size(1140, 505);
            this.clientTab.TabIndex = 0;
            this.clientTab.Text = "Client";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.clientGridView);
            this.viewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewGroupBox.Location = new System.Drawing.Point(294, 2);
            this.viewGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewGroupBox.Size = new System.Drawing.Size(843, 501);
            this.viewGroupBox.TabIndex = 2;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            this.viewGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // clientGridView
            // 
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numeColumn,
            this.prenumeColumn,
            this.adresaColumn,
            this.localitateColumn,
            this.judetColumn,
            this.telefonColumn,
            this.emailColumn});
            this.clientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.clientGridView.Location = new System.Drawing.Point(3, 17);
            this.clientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.RowTemplate.Height = 24;
            this.clientGridView.Size = new System.Drawing.Size(837, 482);
            this.clientGridView.TabIndex = 0;
            this.clientGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGridView_CellEndEdit);
            this.clientGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.clientGridView_CellValidating);
            this.clientGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.clientGridView_EditingControlShowing);
            this.clientGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clientGridView_MouseDown);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ClientId";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 30;
            // 
            // numeColumn
            // 
            this.numeColumn.DataPropertyName = "Nume";
            this.numeColumn.HeaderText = "Nume";
            this.numeColumn.MaxInputLength = 15;
            this.numeColumn.Name = "numeColumn";
            this.numeColumn.Width = 70;
            // 
            // prenumeColumn
            // 
            this.prenumeColumn.DataPropertyName = "Prenume";
            this.prenumeColumn.HeaderText = "Prenume";
            this.prenumeColumn.MaxInputLength = 15;
            this.prenumeColumn.Name = "prenumeColumn";
            this.prenumeColumn.Width = 70;
            // 
            // adresaColumn
            // 
            this.adresaColumn.DataPropertyName = "Adresa";
            this.adresaColumn.HeaderText = "Adresa";
            this.adresaColumn.MaxInputLength = 50;
            this.adresaColumn.Name = "adresaColumn";
            this.adresaColumn.Width = 200;
            // 
            // localitateColumn
            // 
            this.localitateColumn.DataPropertyName = "Localitate";
            this.localitateColumn.HeaderText = "Localitate";
            this.localitateColumn.MaxInputLength = 10;
            this.localitateColumn.Name = "localitateColumn";
            // 
            // judetColumn
            // 
            this.judetColumn.DataPropertyName = "Judet";
            this.judetColumn.HeaderText = "Judet";
            this.judetColumn.MaxInputLength = 10;
            this.judetColumn.Name = "judetColumn";
            // 
            // telefonColumn
            // 
            this.telefonColumn.DataPropertyName = "Telefon";
            this.telefonColumn.HeaderText = "Telefon";
            this.telefonColumn.MaxInputLength = 13;
            this.telefonColumn.Name = "telefonColumn";
            // 
            // emailColumn
            // 
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MaxInputLength = 50;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 200;
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.clientCreateButton);
            this.createGroupBox.Controls.Add(this.emailLabel);
            this.createGroupBox.Controls.Add(this.telefonLabel);
            this.createGroupBox.Controls.Add(this.judetLabel);
            this.createGroupBox.Controls.Add(this.localitateLabel);
            this.createGroupBox.Controls.Add(this.adresaLabel);
            this.createGroupBox.Controls.Add(this.prenumeLabel);
            this.createGroupBox.Controls.Add(this.numeLabel);
            this.createGroupBox.Controls.Add(this.emailTextBox);
            this.createGroupBox.Controls.Add(this.telefonTextBox);
            this.createGroupBox.Controls.Add(this.judetTextBox);
            this.createGroupBox.Controls.Add(this.localitateTextBox);
            this.createGroupBox.Controls.Add(this.adresaTextBox);
            this.createGroupBox.Controls.Add(this.prenumeTextBox);
            this.createGroupBox.Controls.Add(this.numeTextBox);
            this.createGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.createGroupBox.Location = new System.Drawing.Point(3, 2);
            this.createGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGroupBox.Size = new System.Drawing.Size(291, 501);
            this.createGroupBox.TabIndex = 1;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "Creare";
            // 
            // clientCreateButton
            // 
            this.clientCreateButton.Location = new System.Drawing.Point(195, 274);
            this.clientCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientCreateButton.Name = "clientCreateButton";
            this.clientCreateButton.Size = new System.Drawing.Size(75, 23);
            this.clientCreateButton.TabIndex = 15;
            this.clientCreateButton.Text = "Create";
            this.clientCreateButton.UseVisualStyleBackColor = true;
            this.clientCreateButton.Click += new System.EventHandler(this.clientCreateButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(27, 233);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(27, 206);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(56, 17);
            this.telefonLabel.TabIndex = 13;
            this.telefonLabel.Text = "Telefon";
            // 
            // judetLabel
            // 
            this.judetLabel.AutoSize = true;
            this.judetLabel.Location = new System.Drawing.Point(27, 177);
            this.judetLabel.Name = "judetLabel";
            this.judetLabel.Size = new System.Drawing.Size(43, 17);
            this.judetLabel.TabIndex = 12;
            this.judetLabel.Text = "Judet";
            // 
            // localitateLabel
            // 
            this.localitateLabel.AutoSize = true;
            this.localitateLabel.Location = new System.Drawing.Point(27, 149);
            this.localitateLabel.Name = "localitateLabel";
            this.localitateLabel.Size = new System.Drawing.Size(69, 17);
            this.localitateLabel.TabIndex = 11;
            this.localitateLabel.Text = "Localitate";
            // 
            // adresaLabel
            // 
            this.adresaLabel.AutoSize = true;
            this.adresaLabel.Location = new System.Drawing.Point(27, 96);
            this.adresaLabel.Name = "adresaLabel";
            this.adresaLabel.Size = new System.Drawing.Size(53, 17);
            this.adresaLabel.TabIndex = 10;
            this.adresaLabel.Text = "Adresa";
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(27, 68);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeLabel.TabIndex = 9;
            this.prenumeLabel.Text = "Prenume";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(27, 39);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(45, 17);
            this.numeLabel.TabIndex = 8;
            this.numeLabel.Text = "Nume";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(107, 228);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(165, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(107, 199);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonTextBox.MaxLength = 13;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(165, 22);
            this.telefonTextBox.TabIndex = 5;
            this.telefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsOnly_KeyPress);
            // 
            // judetTextBox
            // 
            this.judetTextBox.Location = new System.Drawing.Point(107, 172);
            this.judetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.judetTextBox.MaxLength = 10;
            this.judetTextBox.Name = "judetTextBox";
            this.judetTextBox.Size = new System.Drawing.Size(165, 22);
            this.judetTextBox.TabIndex = 4;
            this.judetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lettersonly_KeyPress);
            // 
            // localitateTextBox
            // 
            this.localitateTextBox.Location = new System.Drawing.Point(107, 144);
            this.localitateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localitateTextBox.MaxLength = 10;
            this.localitateTextBox.Name = "localitateTextBox";
            this.localitateTextBox.Size = new System.Drawing.Size(165, 22);
            this.localitateTextBox.TabIndex = 3;
            this.localitateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lettersonly_KeyPress);
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.AcceptsTab = true;
            this.adresaTextBox.Location = new System.Drawing.Point(107, 91);
            this.adresaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresaTextBox.MaxLength = 50;
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(165, 47);
            this.adresaTextBox.TabIndex = 2;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(107, 63);
            this.prenumeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prenumeTextBox.MaxLength = 15;
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(165, 22);
            this.prenumeTextBox.TabIndex = 1;
            this.prenumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lettersonly_KeyPress);
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(107, 34);
            this.numeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeTextBox.MaxLength = 15;
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(165, 22);
            this.numeTextBox.TabIndex = 0;
            this.numeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lettersonly_KeyPress);
            // 
            // generalTabs
            // 
            this.generalTabs.Controls.Add(this.clientTab);
            this.generalTabs.Controls.Add(this.autoTab);
            this.generalTabs.Controls.Add(this.comandaTab);
            this.generalTabs.Controls.Add(this.sasiuTab);
            this.generalTabs.Controls.Add(this.mecanicTab);
            this.generalTabs.Controls.Add(this.materialTab);
            this.generalTabs.Controls.Add(this.operatieTab);
            this.generalTabs.Controls.Add(this.imagineTab);
            this.generalTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTabs.Location = new System.Drawing.Point(0, 0);
            this.generalTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalTabs.Name = "generalTabs";
            this.generalTabs.SelectedIndex = 0;
            this.generalTabs.Size = new System.Drawing.Size(1148, 534);
            this.generalTabs.TabIndex = 0;
            this.generalTabs.Enter += new System.EventHandler(this.generalTabs_Enter);
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 534);
            this.Controls.Add(this.generalTabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarServiceForm";
            this.Text = "CarServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.detaliuGridView)).EndInit();
            this.imagineTab.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagineGridView)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.operatieTab.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatieGridView)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.materialTab.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.mecanicTab.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mecanicGridView)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.sasiuTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sasiuGridView)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.comandaTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comandaGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.autoTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.clientTab.ResumeLayout(false);
            this.viewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            this.generalTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label comandaLabel;
        private Label materialLabel;
        private Button detaliuCreateButton;
        private ComboBox materialComboBox;
        private ComboBox mecanicComboBox;
        private Label mecanicLabel;
        private ComboBox comandaComboBox;
        private ComboBox imagineComboBox;
        private ComboBox operatirComboBox;
        private Label imagineLabel;
        private Label operatieLabel;
        private DataGridView detaliuGridView;
        private DataGridViewComboBoxColumn imagineColumn;
        private DataGridViewComboBoxColumn operatieColumn;
        private DataGridViewComboBoxColumn materialColumn;
        private DataGridViewComboBoxColumn mecanicColumn;
        private DataGridViewComboBoxColumn comandaColumn;
        private DataGridViewTextBoxColumn detaliuComandaIdColumn;
        private TabPage imagineTab;
        private GroupBox groupBox15;
        private DataGridView imagineGridView;
        private GroupBox groupBox16;
        private Button chooseFotoButton;
        private TextBox fotoTextBox;
        private DateTimePicker dataImaginePicker;
        private Label dataLabel;
        private ComboBox detaliuComandaComboBox;
        private Button imagineCreateButton;
        private Label descriereImagineLabel;
        private Label titluLabel;
        private Label detatiluComandaLabel;
        private TextBox descriereTextBox;
        private TextBox titluTextBox;
        private TabPage operatieTab;
        private GroupBox groupBox13;
        private DataGridView operatieGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn denumireOperatieColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private GroupBox groupBox14;
        private Button operatieCreateButton;
        private Label timpDeExecutieLabel;
        private Label denumireOperatie;
        private TextBox timpDeExecutieTextBox;
        private TextBox denumireOperatieTextBox;
        private TabPage materialTab;
        private GroupBox groupBox11;
        private DataGridView materialGridView;
        private DataGridViewTextBoxColumn materialIdColumn;
        private DataGridViewTextBoxColumn denumireMaterialColumn;
        private DataGridViewTextBoxColumn CantitateColumn;
        private DataGridViewTextBoxColumn pretColumn;
        private DataGridViewTextBoxColumn dataAprovizionareColumn;
        private GroupBox groupBox12;
        private DateTimePicker dataAprovizionarePicker;
        private Button materialCreateButton;
        private Label dataAprovizionareLabel;
        private Label pretLabel;
        private Label cantitateLabel;
        private Label DenumireMaterialLabel;
        private TextBox pretTextBox;
        private TextBox cantitateTextBox;
        private TextBox denumireMaterialTextBox;
        private TabPage mecanicTab;
        private GroupBox groupBox9;
        private DataGridView mecanicGridView;
        private DataGridViewTextBoxColumn mecanicIdColumn;
        private DataGridViewTextBoxColumn numeMecanicColumn;
        private DataGridViewTextBoxColumn prenumeMecanicColumn;
        private GroupBox groupBox10;
        private Button mecanicCreateButton;
        private Label prenumeMecanicLabel;
        private Label numeMecanicLabel;
        private TextBox prenumeMecanicTextBox;
        private TextBox numeMecanicTextBox;
        private TabPage sasiuTab;
        private GroupBox groupBox7;
        private DataGridView sasiuGridView;
        private DataGridViewTextBoxColumn sasiuIdColumn;
        private DataGridViewTextBoxColumn codSasiuColumn;
        private DataGridViewTextBoxColumn denumireSasiuColumn;
        private GroupBox groupBox17;
        private Button sasiuCreateButton;
        private Label denumireLabel;
        private Label codSasiuLabel;
        private TextBox denumireTextBox;
        private TextBox codSasiuTextBox;
        private TabPage comandaTab;
        private GroupBox groupBox3;
        private DataGridView comandaGridView;
        private GroupBox groupBox4;
        private ComboBox stareComandaComboBox;
        private DateTimePicker dataFinalizarePicker;
        private DateTimePicker dataProgramarePicker;
        private Label clientComandaLabel;
        private ComboBox clientComandaComboBox;
        private ComboBox autoComboBox;
        private Button comandaCreateButton;
        private Label autoLabel;
        private Label valoarePieseLabel;
        private Label descriereLabel;
        private Label kmBordLabel;
        private Label dataFinalizareLabel;
        private Label dataProgramareLabel;
        private Label stareComandaLabel;
        private TextBox valoarePieseTextBox;
        private TextBox descriereComandaTextBox;
        private TextBox kmBordTextBox;
        private TabPage autoTab;
        private GroupBox groupBox1;
        private DataGridView autoGridView;
        private DataGridViewTextBoxColumn autoIdColumn;
        private DataGridViewTextBoxColumn numarAutoColumn;
        private DataGridViewTextBoxColumn serieSasiuColumn;
        private DataGridViewTextBoxColumn clientColumn;
        private DataGridViewTextBoxColumn sasiuColumn;
        private GroupBox groupBox2;
        private ComboBox SasiuComboBox;
        private ComboBox clientComboBox;
        private Button autoCreateButton;
        private Label sasiuLabel;
        private Label clientLabel;
        private Label serieSasiuLabel;
        private Label numarAutoLabel;
        private TextBox serieSasiuTextBox;
        private TextBox numarAutoTextBox;
        private TabPage clientTab;
        private GroupBox viewGroupBox;
        private DataGridView clientGridView;
        private GroupBox createGroupBox;
        private Button clientCreateButton;
        private Label emailLabel;
        private Label telefonLabel;
        private Label judetLabel;
        private Label localitateLabel;
        private Label adresaLabel;
        private Label prenumeLabel;
        private Label numeLabel;
        private TextBox emailTextBox;
        private TextBox telefonTextBox;
        private TextBox judetTextBox;
        private TextBox localitateTextBox;
        private TextBox adresaTextBox;
        private TextBox prenumeTextBox;
        private TextBox numeTextBox;
        private TabControl generalTabs;
        private DataGridViewTextBoxColumn imagineIdColumn;
        private DataGridViewTextBoxColumn detaliuComandaColumn;
        private DataGridViewTextBoxColumn titluColumn;
        private DataGridViewTextBoxColumn descriereImagineColumn;
        private DataGridViewTextBoxColumn dataImagineColumn;
        private DataGridViewImageColumn fotoColumn;
        private DataGridViewTextBoxColumn comandaIdColumn;
        private DataGridViewTextBoxColumn stareComandaColumn;
        private DataGridViewTextBoxColumn dataSystemColumn;
        private DataGridViewTextBoxColumn dataProgramareColumn;
        private DataGridViewTextBoxColumn dataFinalizareColumn;
        private DataGridViewTextBoxColumn kmBordColumn;
        private DataGridViewTextBoxColumn descriereColumn;
        private DataGridViewTextBoxColumn valoriPieseColumn;
        private DataGridViewTextBoxColumn clientComandaColumn;
        private DataGridViewTextBoxColumn autoColumn;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn numeColumn;
        private DataGridViewTextBoxColumn prenumeColumn;
        private DataGridViewTextBoxColumn adresaColumn;
        private DataGridViewTextBoxColumn localitateColumn;
        private DataGridViewTextBoxColumn judetColumn;
        private DataGridViewTextBoxColumn telefonColumn;
        private DataGridViewTextBoxColumn emailColumn;
    }
}
