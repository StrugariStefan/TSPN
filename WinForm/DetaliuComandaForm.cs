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
    public partial class DetaliuComandaForm : Form
    {
        private RepositoryWrapper _repository;
        private BindingList<Operatie> operatiesBindingList;
        private BindingList<Mecanic> mecanicsBindingList;
        private BindingList<Material> materialsBindingList;
        private BindingList<Imagine> imaginesBindingList;
        private int _detaliuComandaId;
        private DetaliuComanda _detaliuComanda;

        public DetaliuComandaForm(int detaliuComandaId, RepositoryWrapper repository)
        {
            InitializeComponent();
            _detaliuComandaId = detaliuComandaId;
            _repository = repository;
            _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComandaId);
            refresh_operatieGridView();
            refresh_mecanicGridView();
            refresh_materialGridView();
            refresh_imagineGridView();
            ComandNameTextBox.Text = _detaliuComanda.ToString();
        }

        private void refresh_imagineGridView()
        {
            imaginesBindingList = new BindingList<Imagine>(_detaliuComanda.Imagines.ToList());
            imagineGridView.DataSource = new BindingSource(imaginesBindingList, null);
        }

        private void materialGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void operatieComboBox_Enter(object sender, EventArgs e)
        {
            List<Operatie> operaties =
                _repository.OperatieReadRepository.GetAll() as List<Operatie>;
            operaties = operaties.Where(o => !_detaliuComanda.Operaties.Contains(o)).ToList();
            operatieComboBox.Items.Clear();
            operatieComboBox.Items.AddRange(operaties.ToArray());
        }

        private void refresh_operatieGridView()
        {
            List<Operatie> operaties =
                _repository.OperatieReadRepository.GetAll() as List<Operatie>;
            operaties = operaties.Where(o => _detaliuComanda.Operaties.Contains(o)).ToList();
            operatiesBindingList = new BindingList<Operatie>(operaties);
            operatieGridView.DataSource = new BindingSource(operatiesBindingList, null);
        }

        private void DetaliuComandaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void addOperatieButton_Click(object sender, EventArgs e)
        {
            if (operatieComboBox.SelectedItem == null)
            {
                MessageBox.Show("Some field is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            Operatie operatie = operatieComboBox.SelectedItem as Operatie;
            _repository.DetaliuWriteRepository.AddOperatie(_detaliuComanda.DetaliuComandaId, operatie);
            _repository.DetaliuWriteRepository.SaveChanges();
            refresh_operatieGridView();
            _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
            operatieComboBox_Enter(this, null);


            operatieComboBox.ResetText();
        }

        private void operatieGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = operatieGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < operatieGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Detach Operatie"), (o, args) =>
                    {
                        int id = operatiesBindingList[currentMouseOverRow].OperatieId;
                        Operatie operatie = operatiesBindingList.First(s => s.OperatieId == id);
                        _repository.DetaliuWriteRepository.RemoveOperatie(_detaliuComanda.DetaliuComandaId, operatie);
                        _repository.DetaliuWriteRepository.SaveChanges();
                        operatiesBindingList.Remove(operatie);
                        _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
                        operatieComboBox_Enter(this, null);
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(operatieGridView, new Point(e.X, e.Y));
            }
        }

        

        private void refresh_materialGridView()
        {
            List<Material> materials =
                _repository.MaterialReadRepository.GetAll() as List<Material>;
            materials = materials.Where(m => _detaliuComanda.Materials.Contains(m)).ToList();
            materialsBindingList = new BindingList<Material>(materials);
            materialGridView.DataSource = new BindingSource(materialsBindingList, null);
        }

        private void materialeComboBox_Enter(object sender, EventArgs e)
        {
            List<Material> materials =
                _repository.MaterialReadRepository.GetAll() as List<Material>;
            materials = materials.Where(m => !_detaliuComanda.Materials.Contains(m)).ToList();
            materialeComboBox.Items.Clear();
            materialeComboBox.Items.AddRange(materials.ToArray());
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            if (materialeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Some field is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            Material material = materialeComboBox.SelectedItem as Material;
            _repository.DetaliuWriteRepository.AddMaterial(_detaliuComanda.DetaliuComandaId, material);
            _repository.DetaliuWriteRepository.SaveChanges();
            refresh_materialGridView();
            _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
            materialeComboBox_Enter(this, null);


            materialeComboBox.ResetText();
        }

        private void materialGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = materialGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < materialGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Detach Material"), (o, args) =>
                    {
                        int id = materialsBindingList[currentMouseOverRow].MaterialId;
                        Material material = materialsBindingList.First(s => s.MaterialId == id);
                        _repository.DetaliuWriteRepository.RemoveMaterial(_detaliuComanda.DetaliuComandaId, material);
                        _repository.DetaliuWriteRepository.SaveChanges();
                        materialsBindingList.Remove(material);
                        _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
                        materialeComboBox_Enter(this, null);
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(materialGridView, new Point(e.X, e.Y));
            }
        }

        private void refresh_mecanicGridView()
        {
            List<Mecanic> mecanics =
                _repository.MecanicReadRepository.GetAll() as List<Mecanic>;
            mecanics = mecanics.Where(m => _detaliuComanda.Mecanics.Contains(m)).ToList();
            mecanicsBindingList = new BindingList<Mecanic>(mecanics);
            mecanicGridView.DataSource = new BindingSource(mecanicsBindingList, null);
        }

        private void mecanicComboBox_Enter(object sender, EventArgs e)
        {
            List<Mecanic> mecanics =
                _repository.MecanicReadRepository.GetAll() as List<Mecanic>;
            mecanics = mecanics.Where(m => !_detaliuComanda.Mecanics.Contains(m)).ToList();
            mecanicComboBox.Items.Clear();
            mecanicComboBox.Items.AddRange(mecanics.ToArray());
        }

        private void addMecanicButton_ChangeUICues(object sender, UICuesEventArgs e)
        {
           
        }

        private void addMecanicButton_Click(object sender, EventArgs e)
        {
            if (mecanicComboBox.SelectedItem == null)
            {
                MessageBox.Show("Some field is empty!", "Error", MessageBoxButtons.OK);
                return;
            }

            Mecanic mecanic = mecanicComboBox.SelectedItem as Mecanic;
            _repository.DetaliuWriteRepository.AddMecanic(_detaliuComanda.DetaliuComandaId, mecanic);
            _repository.DetaliuWriteRepository.SaveChanges();
            refresh_mecanicGridView();
            _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
            mecanicComboBox_Enter(this, null);


            mecanicComboBox.ResetText();
        }

        private void mecanicGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = mecanicGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 && currentMouseOverRow < mecanicGridView.RowCount - 1)
                {
                    MenuItem deleteMenuItem = new MenuItem(string.Format("Detach Mecanic"), (o, args) =>
                    {
                        int id = mecanicsBindingList[currentMouseOverRow].MecanicId;
                        Mecanic mecanic = mecanicsBindingList.First(s => s.MecanicId == id);
                        _repository.DetaliuWriteRepository.RemoveMecanic(_detaliuComanda.DetaliuComandaId, mecanic);
                        _repository.DetaliuWriteRepository.SaveChanges();
                        mecanicsBindingList.Remove(mecanic);
                        _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComanda.DetaliuComandaId);
                        mecanicComboBox_Enter(this, null);
                    });
                    m.MenuItems.Add(deleteMenuItem);
                }

                m.Show(mecanicGridView, new Point(e.X, e.Y));
            }
        }

        
    }
}
