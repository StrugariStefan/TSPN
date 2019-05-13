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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarServiceAPI.Model;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Mecanic> mecanicsBindingList;
        private BindingList<Sasiu> sasiusBindingList;
        private BindingList<Operatie> operatiesBindingList;
        private BindingList<Material> materialsBindingList;
        private BindingList<Client> clientsBindingList;
        private BindingList<Auto> autoesBindingList;
        private BindingList<Comanda> comandasBindingList;
        private BindingList<Imagine> imaginesBindingList;
        private CarServiceClient carServiceClient;

        public MainWindow()
        {
            InitializeComponent();
            carServiceClient = new CarServiceClient();
            //refresh_clientDataGrid();
        }

        //public MainWindow(CarServiceClient _carServiceClient) : this()
        //{
            
        //}

        private void ClientCreateButton_OnClick(object sender, RoutedEventArgs e)
        {

            if (clientNumeTextBox.Text.Length == 0 || clientPrenumeTextBox.Text.Length == 0 ||
                clientAdresaTextBox.Text.Length == 0 || clientLocalitateTextBox.Text.Length == 0 || clientLocalitateTextBox.Text.Length == 0 || clientTelefonTextBox.Text.Length == 0 || clientEmailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is empty!", "Error");
                return;
            }

            String nume = clientNumeTextBox.Text;
            String prenume = clientPrenumeTextBox.Text;
            String adresa = clientAdresaTextBox.Text;
            String localitatea = clientLocalitateTextBox.Text;
            String judet = clientJudetTextBox.Text;
            String telefon = clientTelefonTextBox.Text;
            String email = clientEmailTextBox.Text;

            Client client = new Client()
            {
                Nume = nume,
                Prenume = prenume,
                Adresa = adresa,
                Localitate = localitatea,
                Judet = judet,
                Telefon = telefon,
                Email = email
            };

            carServiceClient.AddClient(client);
            refresh_clientDataGrid();

            clientNumeTextBox.Clear();
            clientPrenumeTextBox.Clear();
            clientAdresaTextBox.Clear();
            clientLocalitateTextBox.Clear();
            clientJudetTextBox.Clear();
            clientTelefonTextBox.Clear();
            clientEmailTextBox.Clear();
        }


        private void refresh_clientDataGrid()
        {
            List<Client> clients = carServiceClient.GetClients().ToList();
            clientsBindingList = new BindingList<Client>(clients);
            clientDataGridView.ItemsSource = clientsBindingList;
            //clientComboBox.Items.Clear();
            //clientComboBox.Items.AddRange(clients.ToArray());
            //clientComandaComboBox.Items.Clear();
            //clientComandaComboBox.Items.AddRange(clients.ToArray());
        }

        private void ClientDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContextMenu m = new ContextMenu();
            Point point = e.GetPosition(clientDataGridView);

            HitTestResult hitTestResult =
                VisualTreeHelper.HitTest(clientDataGridView, e.GetPosition(clientDataGridView));
            DataGridRow dataGridRow = hitTestResult.VisualHit.GetParentOfType<DataGridRow>();
            int currentMouseOverRow = dataGridRow.GetIndex();

            if (currentMouseOverRow >= 0 && currentMouseOverRow < clientDataGridView.Items.Count - 1)
            {
                MenuItem deleteMenuItem = new MenuItem()
                {
                    Header = string.Format("Delete Client")
                };

                deleteMenuItem.Click += (o, args) =>
                {
                    MessageBoxResult dialogResult = MessageBox.Show("Sure? This will also delete Autoes, Images and Orders linked to this client", "Delete", MessageBoxButton.YesNo);
                    if (dialogResult == MessageBoxResult.Yes)
                    {
                        int id = clientsBindingList[currentMouseOverRow].ClientId;
                        clientsBindingList.Remove(clientsBindingList.First(s => s.ClientId == id));
                        carServiceClient.DeleteClient(id);
                        //clientComboBox.Items.RemoveAt(currentMouseOverRow);
                        //clientComandaComboBox.Items.RemoveAt(currentMouseOverRow);
                        //refresh_autoGridView();
                        //refresh_comandaGridView();
                        //refresh_imagineGridView();
                    }
                };
                m.Items.Add(deleteMenuItem);

                //MenuItem viewAutosMenuItem = new MenuItem()
                //{
                //    Header = string.Format("View Autos")
                //};
                //viewAutosMenuItem.Click += (o, args) =>
                //{
                //    var autoesForm = new AutoesForm(_repository, clientsBindingList[currentMouseOverRow].ClientId);
                //    autoesForm.ShowDialog(this);
                //};
                //m.Items.Add(viewAutosMenuItem);

                //MenuItem addAutoMenuItem = new MenuItem()
                //{
                //    Header = string.Format("Add Auto")
                //};
                //addAutoMenuItem.Click += (o, args) =>
                //{
                //    CarServiceAPI.Model.Client client = clientsBindingList[currentMouseOverRow];
                //    generalTabs.SelectedTab = autoTab;
                //    clientComboBox_Enter(this.clientGridView, e);
                //    clientComboBox.SelectedItem = client;
                //};
                //m.Items.Add(addAutoMenuItem);
            }

            m.IsOpen = true;
        }

        private void AutoCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComandaCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SasiuCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MecanicCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MaterialCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OperatieCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImagineCreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AutoDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComandaDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SasiuDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MecanicDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MaterialDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OperatieDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImagineDataGridView_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
