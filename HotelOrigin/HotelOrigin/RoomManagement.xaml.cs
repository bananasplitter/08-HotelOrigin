using HotelOrigin.Core.Repository;
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
using System.Windows.Shapes;
using HotelOrigin.Core.Domain;


namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        private Rooms currentlySelectedRoom = null;

        public RoomManagement()
        {
            InitializeComponent();
            dataGridRoomManagement.ItemsSource = RoomManagementRepository.GetAll();
        }

        private void buttonAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Rooms room = new Rooms()
            {
                RoomNumber = RoomManagementRepository.GetAll().Count + 1,
                NumberOfBeds = "2",
                HasTv = true,
                DateOfReservation = "Enter Date MM/DD/YYYY",

            };
            RoomManagementRepository.Add(room);
        }

        private void buttonRemoveRoom_Click(object sender, RoutedEventArgs e)
        {
            RoomManagementRepository.Delete(currentlySelectedRoom.RoomNumber);
        }

        private void dataGridRoomManagement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelectedRoom = (Rooms)dataGridRoomManagement.SelectedItem;
        }
    }
}
