using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CarServiceAPI.Model;

namespace WPFClient
{
    


    /// <summary>
    /// Interaction logic for AutoesWindow.xaml
    /// </summary>
    public partial class AutoesWindow : Window
    {
        private BindingList<Auto> autoesBindingList;
        private CarServiceClient carServiceClient;
        private int clientId;
        private Client client;

        public AutoesWindow(CarServiceClient _carServiceClient, int _clientId)
        {
            carServiceClient = _carServiceClient;
            clientId = _clientId;
            client = carServiceClient.GetClientById(clientId);
            InitializeComponent();
        }

        private void refresh_autoesDataGrid()
        {
            autoesBindingList = new BindingList<Auto>(client.Autoes.ToList());
            autoesDataGridView.ItemsSource = autoesBindingList;
        }
    }
}
