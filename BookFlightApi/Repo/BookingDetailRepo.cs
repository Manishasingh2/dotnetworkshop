using BookFlightApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookFlightApi.Repo
{

    public class BookingDetailRepo: IBookingDetailRepo
    {
       BookingDetail bookingDetails=new BookingDetail();

        public void AddIBooking(BookingDetail bookingDetail)
        {
            bookingDetails.AddBooking(bookingDetail);
        }

       public void DeleteIItem(int id)
        {
            bookingDetails.DeleteItem(id);
        }

        public BookingDetail GetBookingByIId(int id)
        {
            return bookingDetails.GetBookingById(id);
        }

        public List<BookingDetail> getBookingIItems()
        {
            return bookingDetails.getBookingItems();
        }
         public int GetILastBookingID()
         {
             return bookingDetails.GetLastBookingID();
         }
    
    }
}

