using EquipmentBookingSystem.Domain;

namespace EquipmentBookingSystem.Application;

public class BookingService
{
    private readonly AvailabilityService _availabilityService;

    // Dependency Injection via konstruktorn
    public BookingService(AvailabilityService availabilityService)
    {
        _availabilityService = availabilityService;
    }

    public BookingResult CreateBooking(
        Guid customerId,
        Guid modelId,
        DateOnly startDate,
        DateOnly endDate)
    {
        // Steg 3: Validera bokningsperioden
        bool isValid = ValidateBookingPeriod(startDate, endDate);

        // Steg 4: Ogiltig bokningsperiod
        if (!isValid)
        {
            return BookingResult.Failure("Ogiltig bokningsperiod");
        }

        // Steg 5: Hitta ett ledigt exemplar
        EquipmentItem? availableItem =
            _availabilityService.FindAvailableItem(
                modelId,
                startDate,
                endDate
            );

        // Steg 10–18 implementerar vi senare
        throw new NotImplementedException();
    }

    private bool ValidateBookingPeriod(
        DateOnly startDate,
        DateOnly endDate)
    {
        var period = new BookingPeriod(startDate, endDate);

        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        return period.IsValid(today);
    }
}