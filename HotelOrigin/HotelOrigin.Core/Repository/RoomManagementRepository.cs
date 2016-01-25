using HotelOrigin.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Repository
{
   public class RoomManagementRepository
    {
        private static ObservableCollection<Rooms> rooms = new ObservableCollection<Rooms>();

        public static Rooms Create()
        {
            Rooms room = new Rooms();

            rooms.Add(room);

            return room;
        }
        public static void Add(Rooms room)
        {
            rooms.Add(room);
        }

        public static Rooms GetByNumber(int roomNumber)
        {
            return rooms.FirstOrDefault(c => c.RoomNumber == roomNumber);
        }

        public static ObservableCollection<Rooms> GetAll()
        {
            return rooms;
        }

        public static void Update(Rooms room, bool hasTv, string numberOfBeds, string dateofReservation)
        {
            room.NumberOfBeds = numberOfBeds;
            room.HasTv = hasTv;
            room.DateOfReservation = dateofReservation;
        }

        public static void Delete(int roomNumber)
        {
            var room = GetByNumber(roomNumber);
                rooms.Remove(room);
        }

    }
}
