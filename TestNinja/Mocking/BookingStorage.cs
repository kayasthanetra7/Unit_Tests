using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IBookingStorage
    {
        IQueryable<Booking> GetActiveBookings(int? excludedBookingID = null);
    }

    public class BookingStorage : IBookingStorage
    {
        public IQueryable<Booking> GetActiveBookings(int? excludedBookingID = null)
        {
            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.Status != "Cancelled");

            if (excludedBookingID.HasValue)
                bookings = bookings.Where(b => b.Id != excludedBookingID.Value);

            return bookings;
        }
    }
}
