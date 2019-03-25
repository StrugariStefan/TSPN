using System;
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

        public Form1()
        {
            _repository = new RepositoryWrapper();
            InitializeComponent();
            refresh_mecanicGridView();
            refresh_sasiuGridView();
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
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Delete Person"), (o, args) =>
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
            if (e.KeyCode == Keys.Tab && (mecanicGridView.CurrentCell.ColumnIndex == 1 || mecanicGridView.CurrentCell.ColumnIndex == 2))
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
            sasiusBindingList = new BindingList<Sasiu>(_repository.SasiuReadRepository.GetAll());
            sasiuGridView.DataSource = new BindingSource(sasiusBindingList, null);
        }
    }

    
}
