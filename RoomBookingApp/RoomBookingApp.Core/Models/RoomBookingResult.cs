using RoomBookingApp.Core.Domain.Enums;
using System;

namespace RoomBookingApp.Core.Models
{
    public class RoomBookingResult : RoomBookingBase
    {
        public BookingResultFlag Flag { get; set; }
    }
}