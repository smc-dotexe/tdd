﻿using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;
using System;
using Xunit;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequestProcessorTest
    {
        private RoomBookingRequestProcessor _processor;

        public RoomBookingRequestProcessorTest()
        {
            _processor = new RoomBookingRequestProcessor();
        }

        [Fact]
        public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            // Arrange
            var request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2022, 10, 20)
            };

            // Act
            RoomBookingResult result = _processor.BookRoom(request);

            // Assert
            Assert.NotNull(result);
            result.ShouldNotBeNull();

            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

            // Shouldly style asserts
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);

        }

        [Fact]
        public void Should_Throw_Exception_For_Null_Request()
        {
            var processor = new RoomBookingRequestProcessor();

            var exception = Should.Throw<ArgumentNullException>(() => _processor.BookRoom(null));
            //Assert.Throw<ArgumentNullException>(() => processor.BookRoom(null));
            exception.ParamName.ShouldBe("bookingRequest");
        }
    }
}
