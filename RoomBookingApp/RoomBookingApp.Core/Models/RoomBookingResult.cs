using RoomBookingApp.Core.Domain.Enums;
using RoomBookingApp.Domain.BaseModels;
using System;

namespace RoomBookingApp.Core.Models
{
    public class RoomBookingResult : RoomBookingBase
    {
        public BookingResultFlag Flag { get; set; }
        public int? RoomBookingId { get; set; }
    }
}