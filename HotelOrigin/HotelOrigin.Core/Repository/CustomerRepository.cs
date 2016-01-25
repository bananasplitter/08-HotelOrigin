using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HotelOrigin.Core.Domain;

namespace HotelOrigin.Core.Repository

{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        public static Customer Create()
        {
            Customer customer = new Customer();

            customers.Add(customer);

            return customer;
        }
        public static void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public static Customer GetById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }

        public static ObservableCollection<Customer> GetAll()
        {
            return customers;
        }

        public static void Update(Customer customer, string firstName, string lastName, string telephoneNumber, string emailAddress)
        {

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.TelephoneNumber = telephoneNumber;
            customer.EmailAddress = emailAddress;

        }

        public static void Delete(int id)
        {
            var customer = GetById(id);
            customers.Remove(customer);
        }

    }
}
