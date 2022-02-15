using BookFlightApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookFlightApi.Repo
{
    interface IBookingDetailRepo
    {
        public void AddIBooking(BookingDetail bookingDetail);
        public void DeleteIItem(int id);

        public List<BookingDetail> getBookingIItems();
        public BookingDetail GetBookingByIId(int id);
        public int GetILastBookingID();

    }
}
