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
    public partial class AutoesForm : Form
    {
        private BindingList<Auto> autoesBindingList;
        private RepositoryWrapper _repository;
        private int _clientId;
        private Client _client;

        public AutoesForm(RepositoryWrapper repository, int clientId)
        {
            InitializeComponent();
            _repository = repository;
            _clientId = clientId;
            _client = _repository.ClientReadRepository.GetById(_clientId);
            refresh_autoesGridView();
        }

        private void refresh_autoesGridView()
        {
            autoesBindingList = new BindingList<Auto>(_client.Autoes.ToList());
            autoGridView.DataSource = new BindingSource(autoesBindingList, null);
        }
    }
}
