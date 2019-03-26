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
        public DetaliuComanda DetaliuComanda { get; private set; }

        public DetaliuComandaForm(DetaliuComanda detaliu)
        {
            InitializeComponent();
            DetaliuComanda = detaliu;
            _repository = new RepositoryWrapper();
            refresh_operatieGridView();
            ComandNameTextBox.Text = DetaliuComanda.ToString();
        }

        private void materialGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void operatieComboBox_Enter(object sender, EventArgs e)
        {
            List<Operatie> operaties =
                _repository.OperatieReadRepository.GetAll() as List<Operatie>;
            operaties = operaties.Where(o => !DetaliuComanda.Operaties.Contains(o)).ToList();
            operatieComboBox.Items.Clear();
            operatieComboBox.Items.AddRange(operaties.ToArray());
        }

        private void refresh_operatieGridView()
        {
            List<Operatie> operaties =
                _repository.OperatieReadRepository.GetAll() as List<Operatie>;
            operaties = operaties.Where(o => DetaliuComanda.Operaties.Contains(o)).ToList();
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
            _repository.DetaliuWriteRepository.AddOperatie(DetaliuComanda.DetaliuComandaId, operatie);
            _repository.DetaliuWriteRepository.SaveChanges();
            refresh_operatieGridView();

            operatieComboBox.ResetText();
        }
    }
}
