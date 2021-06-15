using System;
using System.Collections.Generic;
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
using VehicleTracker.Models;

namespace VehicleTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VehicleModel selectedVehicle;

        public MainWindow()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            var vehicles = App.VehicleRepository.GetAll();

            uxVehicleList.ItemsSource = vehicles
                .Select(t => VehicleModel.ToModel(t))
                .ToList();
            uxStatus.Text = "Total vehicles: " + vehicles.Count;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new VehicleWindow();

            if (window.ShowDialog() == true)
            {
                var uiVehicleModel = window.Vehicle;

                var repositoryVehicleModel = uiVehicleModel.ToRepositoryModel();

                App.VehicleRepository.Add(repositoryVehicleModel);

                LoadVehicles();
            }
        }
        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxVehicleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedVehicle = (VehicleModel)uxVehicleList.SelectedValue;
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            var window = new VehicleWindow();
            window.Vehicle = selectedVehicle.Clone();

            if (window.ShowDialog() == true)
            {
                App.VehicleRepository.Update(window.Vehicle.ToRepositoryModel());
                LoadVehicles();
            }
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedVehicle != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.VehicleRepository.Remove(selectedVehicle.Id);
            selectedVehicle = null;
            LoadVehicles();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedVehicle != null);
        }

        private void uxSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string field = uxSearchField.Text;
            string searchStr = uxSearchBox.Text;
            if (string.IsNullOrEmpty(searchStr))
            {
                LoadVehicles();
                return;
            }

            var vehicles = App.VehicleRepository.GetAll();

            uxVehicleList.ItemsSource = vehicles
                .Where(t => typeof(VehicleRepository.VehicleModel).GetProperty(field).GetValue(t).ToString().Contains(searchStr))
                .Select(t => VehicleModel.ToModel(t))
                .ToList();
        }

        private void uxClearBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadVehicles();
        }
    }
}
