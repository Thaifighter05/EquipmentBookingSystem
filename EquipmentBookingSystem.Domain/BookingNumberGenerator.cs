namespace EquipmentBookingSystem.Application;

public class BookingNumberGenerator
{
    public Guid GenerateBookingNumber()
    {
        return Guid.NewGuid();
    }
}