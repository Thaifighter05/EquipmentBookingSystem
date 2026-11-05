
using EquipmentBookingSystem.Application;
using EquipmentBookingSystem.Domain;

namespace EquipmentBookingSystem.Infrastructure;

public class InMemoryBookingRepository : IBookingRepository
{
    private readonly List<Booking> _bookings = new();

    public List<Booking> GetBookings()
    {
        return _bookings.ToList();
    }

    public SaveResult SaveBooking(Booking booking)
    {
        _bookings.Add(booking);

        return SaveResult.Success();
    }
}
