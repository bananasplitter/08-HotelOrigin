using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;

namespace HotelOrigin.Core.Repository
{
   public class ReserveRepository
    {
        private static ObservableCollection<Reservations> reservations = new ObservableCollection<Reservations>();
        public static Reservations Create()
        {
            Reservations reservation = new Reservations();

            reservations.Add(reservation);

            return reservation;
        }
        public static void Add(Reservations reservation)
        {
            reservations.Add(reservation);
        }
       // public static Reservations GetByNumber(int roomForReservtion)
       // {
        //    return reservations.FirstOrDefault(c => c.RoomForReservtion == roomForReservtion);
      //  }
        public static ObservableCollection<Reservations> GetAll()
        {
            return reservations;
        }
        public static void Update(Reservations reservation, object customer, int roomForReservation, DateTime checkInDate, DateTime checkOutDate)
        {
            reservation.Customer = customer;
            reservation.RoomForReservation = roomForReservation;
            reservation.CheckInDate = checkInDate;
            reservation.CheckOutDate = checkOutDate;
        }
    }
}


