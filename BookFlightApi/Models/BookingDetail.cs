using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace BookFlightApi.Models
{
    public  class BookingDetail
    {
        public int Bookingid { get; set; }
        public int? Flightid { get; set; }
        public int? Routeid { get; set; }
        public DateTime? Doj { get; set; }
        public int? Numberofpassengers { get; set; }
        public double? Totalvalue { get; set; }
        public int? Customerid { get; set; }
        static List<BookingDetail> bookings = new List<BookingDetail>();
        public BookingDetail()
        {

        }

        public BookingDetail( int Bookingid,int Flightid,int Routeid,DateTime Doj,int Numberofpassengers,double Totalvalue,int Customerid)
        {
            this.Bookingid=Bookingid;
            this.Flightid=Flightid;
            this.Doj=Doj;
            this.Numberofpassengers=Numberofpassengers;
            this.Totalvalue=Totalvalue;
            this.Customerid=Customerid;
            this.Routeid=Routeid;  
        }

        public List<BookingDetail> getBookingItems()
        {
           
            return bookings;
        }

        public void AddBooking(BookingDetail bookingDetail)
        {
            bookings.Add(bookingDetail);

        }

        public void DeleteItem(int id)
        {
            BookingDetail b= GetBookingById(id);
            bookings.Remove(b);
        }

        public BookingDetail GetBookingById(int id)
        {
            BookingDetail b = bookings.Where(p => p.Bookingid == id).FirstOrDefault();
            return b;
        }
        public int GetLastBookingID()
        {
           BookingDetail bookingDetail=bookings.OrderByDescending(x =>x.Bookingid).FirstOrDefault();
            return bookingDetail.Bookingid;
        }

    }
    
}
