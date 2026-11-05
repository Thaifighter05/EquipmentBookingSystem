using EquipmentBookingSystem.Domain;

namespace EquipmentBookingSystem.Application;

public class AvailabilityService
{
    private readonly IBookingRepository _bookingRepository;

    // Dependency Injection via konstruktorn
    public AvailabilityService(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public EquipmentItem? FindAvailableItem(
        Guid modelId,
        DateOnly startDate,
        DateOnly endDate)
    {
        // Steg 6: Hämta befintliga bokningar
        List<Booking> bookings =
            _bookingRepository.GetBookings();

        // Steg 7: Listan med bokningar har returnerats

        // Steg 8–9 implementerar vi härnäst
        throw new NotImplementedException();
    }
}