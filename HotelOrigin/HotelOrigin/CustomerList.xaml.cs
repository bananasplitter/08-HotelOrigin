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
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;
using HotelOrigin.Core.Domain;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : Window
    {
        private Customer currentlySelectedCustomer = null;

        public CustomerList()
        {
            InitializeComponent();
            gridCustomerNo2.ItemsSource = CustomerRepository.GetAll();
        }

        public void buttonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer()
            
            {

               Id=CustomerRepository.GetAll().Count +1,
               FirstName = "Tiana",
               LastName = "Pehle",
               EmailAddress = "tiana_pehle@pehle.com",
               TelephoneNumber = "99696969"


            };
               CustomerRepository.Add(customer);
            
        }

        private void buttonRemoveCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerRepository.Delete(currentlySelectedCustomer.Id);
        }

        private void gridCustomerNo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelectedCustomer = (Customer)gridCustomerNo2.SelectedItem;
        }
    }
}
