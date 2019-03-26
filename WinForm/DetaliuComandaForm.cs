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
        private int _detaliuComandaId;
        private DetaliuComanda _detaliuComanda;

        public DetaliuComandaForm(int detaliuComandaId, RepositoryWrapper repository)
        {
            InitializeComponent();
            _detaliuComandaId = detaliuComandaId;
            _repository = repository;
            _detaliuComanda = _repository.DetaliuReadRepository.GetById(_detaliuComandaId);
            refresh_operatieGridView();
            ComandNameTextBox.Text = _detaliuComanda.ToString();
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
    }
}
