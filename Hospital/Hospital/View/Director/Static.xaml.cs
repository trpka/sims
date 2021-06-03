﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hospital.View.Director
{
    /// <summary>
    /// Interaction logic for Static.xaml
    /// </summary>
    public partial class Static : Window
    {
        Controller.StaticEquipmentController equipmentController = new Controller.StaticEquipmentController();
        public Static()
        {
            InitializeComponent();
            staticDataGrid.ItemsSource = equipmentController.GetAll();
        }
        private void AddStatic_Click(object sender, RoutedEventArgs e)
        {
            StaticAdd roomAdd = new StaticAdd();
            roomAdd.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        private void Sreach_Click(object sender, RoutedEventArgs e)
        { // ukoliko nema nista u searchu izbaci poruku ispod bara 
            //roomsDataGrid.ItemsSource = roomController.GetByName(searchData.Text);   
        }
        private void Detail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.StaticEquipment equipment = (Model.StaticEquipment)staticDataGrid.SelectedItem;
                StaticDetail staticDetail = new StaticDetail(equipment.Name, equipment.Quantity, equipment.Description);
                staticDetail.Show();
                Close();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Morate odabrati sobu da bi ste prikazali detalje");
            }
        }
    }
}