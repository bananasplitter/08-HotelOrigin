using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Domain
{
    public class Rooms
    {

        public int RoomNumber { get; set; }
        public string NumberOfBeds { get; set; }
        public bool HasTv { get; set; }
        public string DateOfReservation { get; set; }
    }
}
