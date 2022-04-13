﻿using RoomBookingApp.Domain.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBookingApp.Domain
{
    public class RoomBooking : RoomBookingBase
    {
        public int Id { get; set; }
        
        // Foreign Key
        public Room Room { get; set; }
        public int RoomId { get; set; }
    }
}
