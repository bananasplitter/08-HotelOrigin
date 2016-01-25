using HotelOrigin.Core.Domain;
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
using HotelOrigin.Core.Repository;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationManagement.xaml
    /// </summary>
    public partial class ReservationManagement : Window
    {
        private Reservations currentlySelectedRerservation = null;

        public ReservationManagement()
        {
            InitializeComponent();
            dataGridReservationManagement.ItemsSource = ReserveRepository.GetAll();
        }

        private void buttonAddReservations_Click(object sender, RoutedEventArgs e)
        {
            Reservations reservation = new Reservations()
            {
                Customer = "Enter First and Last Name",
                RoomForReservation = "Enter Room Number",
                CheckInDate = DateTime.Now,
                CheckOutDate = DateTime.Now
            };
            ReserveRepository.Add(reservation);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelectedRerservation = (Reservations)dataGridReservationManagement.SelectedItem;
        }

        private void comboBoxRoomForReserve_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
    }
}
