﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceAPI.Model;
using CarServiceAPI.Repository;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private RepositoryWrapper _repository;
        private BindingList<Mecanic> mecanicsBindingList;
        private BindingList<Sasiu> sasiusBindingList;
        private BindingList<Operatie> operatiesBindingList;
        private BindingList<Material> materialsBindingList;
        private BindingList<Client> clientsBindingList;

        public Form1()
        {
            _repository = new RepositoryWrapper();
            InitializeComponent();
            refresh_mecanicGridView();
            refresh_sasiuGridView();
            refresh_operatieGridView();
            refresh_materialGridView();
            refresh_clientGridView();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void autoTab_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serieSasiuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numarAutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stareComandaLabel_Click(object sender, EventArgs e)
        {

        }

        private void cantitateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagineCreateButton_Click(object sender, EventArgs e)
        {

        }

        private void mecanicCreateButton_Click(object sender, EventArgs e)
        {
            if (numeMecanicTextBox.Text.Length == 0 || prenumeMecanicTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            String nume = numeMecanicTextBox.Text;
            String prenume = prenumeMecanicTextBox.Text;

            _repository.MecanicWriteRepository.Create(new Mecanic(nume, prenume));
            _repository.MecanicWriteRepository.SaveChanges();
            refresh_mecanicGridView();

            numeMecanicTextBox.Clear();
            prenumeMecanicTextBox.Clear();
        }

        private void refresh_mecanicGridView()
        {
            mecanicsBindingList = new BindingList<Mecanic>(_repository.MecanicReadRepository.GetAll());
            mecanicGridView.DataSource = new BindingSource(mecanicsBindingList, null);
        }

        private void refresh_operatieGridView()
        {
            operatiesBindingList = new BindingList<Operatie>(_repository.OperatieReadRepository.GetAll());
            operatieGridView.DataSource = new BindingSource(operatiesBindingList, null);
        }

        private void mecanicGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mecanicGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = mecanicGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < mecanicGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Mecanic"), (o, args) =>
                    {
                        int id = mecanicsBindingList[currentMouseOverRow].MecanicId;
                        _repository.MecanicWriteRepository.Delete(id);
                        _repository.MecanicWriteRepository.SaveChanges();
                        refresh_mecanicGridView();
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(mecanicGridView, new Point(e.X, e.Y));
            }
        }

        private void mecanicGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(mecanicGridView.CurrentCell.ColumnIndex);
            if (mecanicGridView.CurrentCell.ColumnIndex == 1 || mecanicGridView.CurrentCell.ColumnIndex == 2)
            {
                mecanicGridView.BeginEdit(true);
            }
        }

        private void numeMecanic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void prenumeMecanic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mecanicGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && (mecanicGridView.CurrentCell.ColumnIndex == 1 ||
                                          mecanicGridView.CurrentCell.ColumnIndex == 2))
            {
                e.Handled = true;
                mecanicGridView.BeginEdit(true);
            }
        }

        private void mecanicGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= lettersonly_KeyPress;
            e.Control.KeyPress += lettersonly_KeyPress;
        }

        private void lettersonly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void digitsAndUppersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mecanicGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                mecanicGridView.Rows[e.RowIndex].ErrorText =
                    "Field must not be empty";
                e.Cancel = true;
            }
        }

        private void mecanicGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(mecanicGridView.CurrentCell.ColumnIndex + " " + mecanicGridView.CurrentCell.RowIndex);
            _repository.MecanicWriteRepository.Update(mecanicsBindingList[mecanicGridView.CurrentCell.RowIndex]);
            _repository.MecanicWriteRepository.SaveChanges();
        }

        private void codSasiuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sasiuCreateButton_Click(object sender, EventArgs e)
        {
            if (codSasiuTextBox.Text.Length == 0 || denumireTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            String codSasiu = codSasiuTextBox.Text;
            String denumire = denumireTextBox.Text;

            _repository.SasiuWriteRepository.Create(new Sasiu(codSasiu, denumire));
            _repository.SasiuWriteRepository.SaveChanges();
            refresh_sasiuGridView();

            codSasiuTextBox.Clear();
            denumireTextBox.Clear();
        }

        private void refresh_sasiuGridView()
        {
            List<Sasiu> sasius = _repository.SasiuReadRepository.GetAll();
            sasiusBindingList = new BindingList<Sasiu>(sasius);
            sasiuGridView.DataSource = new BindingSource(sasiusBindingList, null);
            SasiuComboBox.Items.AddRange(sasius.ToArray());
        }

        private void sasiuGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = sasiuGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < sasiuGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Sasiu"), (o, args) =>
                    {
                        int id = sasiusBindingList[currentMouseOverRow].SasiuId;
                        sasiusBindingList.Remove(sasiusBindingList.First(s => s.SasiuId == id));
                        _repository.SasiuWriteRepository.Delete(id);
                        _repository.SasiuWriteRepository.SaveChanges();
                        SasiuComboBox.Items.RemoveAt(currentMouseOverRow);
                        //refresh_mecanicGridView();
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(sasiuGridView, new Point(e.X, e.Y));
            }
        }

        private void sasiuGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab &&
                (sasiuGridView.CurrentCell.ColumnIndex == 1 || sasiuGridView.CurrentCell.ColumnIndex == 2))
            {
                e.Handled = true;
                sasiuGridView.BeginEdit(true);
            }
        }

        private void sasiuGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= digitsAndUppersOnly_KeyPress;
            if (sasiuGridView.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress += digitsAndUppersOnly_KeyPress;
            }
        }

        private void sasiuGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                sasiuGridView.Rows[e.RowIndex].ErrorText =
                    "Field must not be empty";
                e.Cancel = true;
            }
        }

        private void sasiuGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository.SasiuWriteRepository.Update(sasiusBindingList[sasiuGridView.CurrentCell.RowIndex]);
            _repository.SasiuWriteRepository.SaveChanges();
            SasiuComboBox.Items.Clear();
            SasiuComboBox.Items[sasiuGridView.CurrentCell.RowIndex] =
                sasiusBindingList[sasiuGridView.CurrentCell.RowIndex];
        }

        private void operatieCreateButton_Click(object sender, EventArgs e)
        {
            if (denumireOperatieTextBox.Text.Length == 0 || timpDeExecutieTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            String denumireOperatie = denumireOperatieTextBox.Text;
            String timpDeExecutie = timpDeExecutieTextBox.Text;

            _repository.OperatieWriteRepository.Create(new Operatie(denumireOperatie, decimal.Parse(timpDeExecutie)));
            _repository.OperatieWriteRepository.SaveChanges();
            refresh_operatieGridView();

            denumireOperatieTextBox.Clear();
            timpDeExecutieTextBox.Clear();
        }

        private void operatieGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = operatieGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < operatieGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Operatie"), (o, args) =>
                    {
                        int id = operatiesBindingList[currentMouseOverRow].OperatieId;
                        operatiesBindingList.Remove(operatiesBindingList.First(s => s.OperatieId == id));
                        _repository.OperatieWriteRepository.Delete(id);
                        _repository.OperatieWriteRepository.SaveChanges();
                        //refresh_mecanicGridView();
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(operatieGridView, new Point(e.X, e.Y));
            }
        }

        private void operatieGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= digitsAndUppersOnly_KeyPress;
            if (operatieGridView.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += digitsAndUppersOnly_KeyPress;
            }
        }

        private void digitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void operatieGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                operatieGridView.Rows[e.RowIndex].ErrorText =
                    "Field must not be empty";
                e.Cancel = true;
            }
        }

        private void operatieGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository.OperatieWriteRepository.Update(operatiesBindingList[operatieGridView.CurrentCell.RowIndex]);
            _repository.OperatieWriteRepository.SaveChanges();
        }

        private void materialCreateButton_Click(object sender, EventArgs e)
        {
            if (denumireMaterialTextBox.Text.Length == 0 || cantitateTextBox.Text.Length == 0 ||
                pretTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            String denumireMaterial = denumireMaterialTextBox.Text;
            String cantitate = cantitateTextBox.Text;
            String pret = pretTextBox.Text;
            DateTime data = dataAprovizionarePicker.Value;

            _repository.MaterialWriteRepository.Create(new Material(denumireMaterial, decimal.Parse(cantitate),
                decimal.Parse(pret), data));
            _repository.MaterialWriteRepository.SaveChanges();
            refresh_materialGridView();

            denumireMaterialTextBox.Clear();
            cantitateTextBox.Clear();
            pretTextBox.Clear();
        }

        private void refresh_materialGridView()
        {
            materialsBindingList = new BindingList<Material>(_repository.MaterialReadRepository.GetAll());
            materialGridView.DataSource = new BindingSource(materialsBindingList, null);
        }

        private void materialGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = materialGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < materialGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Material"), (o, args) =>
                    {
                        int id = materialsBindingList[currentMouseOverRow].MaterialId;
                        materialsBindingList.Remove(materialsBindingList.First(s => s.MaterialId == id));
                        _repository.MaterialWriteRepository.Delete(id);
                        _repository.MaterialWriteRepository.SaveChanges();
                        //refresh_mecanicGridView();
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(materialGridView, new Point(e.X, e.Y));
            }
        }

        private void materialGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= digitsAndUppersOnly_KeyPress;
            if (materialGridView.CurrentCell.ColumnIndex == 2 || materialGridView.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += digitsAndUppersOnly_KeyPress;
            }
        }

        private void materialGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                materialGridView.Rows[e.RowIndex].ErrorText =
                    "Field must not be empty";
                e.Cancel = true;
            }
        }

        private void materialGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository.MaterialWriteRepository.Update(materialsBindingList[materialGridView.CurrentCell.RowIndex]);
            _repository.MaterialWriteRepository.SaveChanges();
        }

        private void clientCreateButton_Click(object sender, EventArgs e)
        {
            if (numeTextBox.Text.Length == 0 || prenumeTextBox.Text.Length == 0 ||
                adresaTextBox.Text.Length == 0 || localitateTextBox.Text.Length == 0 || judetTextBox.Text.Length == 0 || telefonTextBox.Text.Length == 0 || emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            String nume = numeTextBox.Text;
            String prenume = prenumeTextBox.Text;
            String adresa = adresaTextBox.Text;
            String localitatea = localitateTextBox.Text;
            String judet = judetTextBox.Text;
            String telefon = telefonTextBox.Text;
            String email = emailTextBox.Text;

            _repository.ClientWriteRepository.Create(new Client(nume, prenume,
                adresa, localitatea, judet, telefon, email));
            _repository.ClientWriteRepository.SaveChanges();
            refresh_clientGridView();

            numeTextBox.Clear();
            prenumeTextBox.Clear();
            adresaTextBox.Clear();
            localitateTextBox.Clear();
            judetTextBox.Clear();
            telefonTextBox.Clear();
            emailTextBox.Clear();
        }

        private void refresh_clientGridView()
        {
            clientsBindingList = new BindingList<Client>(_repository.ClientReadRepository.GetAll());
            clientGridView.DataSource = new BindingSource(clientsBindingList, null);
        }

        private void clientGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = clientGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < clientGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Client"), (o, args) =>
                    {
                        int id = clientsBindingList[currentMouseOverRow].ClientId;
                        clientsBindingList.Remove(clientsBindingList.First(s => s.ClientId == id));
                        _repository.ClientWriteRepository.Delete(id);
                        _repository.ClientWriteRepository.SaveChanges();
                        //refresh_mecanicGridView();
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(clientGridView, new Point(e.X, e.Y));
            }
        }

        private void clientGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= lettersonly_KeyPress;
            e.Control.KeyPress -= digitsOnly_KeyPress;

            if (clientGridView.CurrentCell.ColumnIndex == 1 || clientGridView.CurrentCell.ColumnIndex == 2 || clientGridView.CurrentCell.ColumnIndex == 4 || clientGridView.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += lettersonly_KeyPress;
            }

            if (clientGridView.CurrentCell.ColumnIndex == 6)
            {
                e.Control.KeyPress += digitsOnly_KeyPress;
            }
        }

        private void clientGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                clientGridView.Rows[e.RowIndex].ErrorText =
                    "Field must not be empty";
                e.Cancel = true;
            }
        }

        private void clientGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _repository.ClientWriteRepository.Update(clientsBindingList[clientGridView.CurrentCell.RowIndex]);
            _repository.ClientWriteRepository.SaveChanges();
        }
    }
}
