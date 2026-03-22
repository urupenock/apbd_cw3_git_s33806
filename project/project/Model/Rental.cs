using project.Model.Hardware; 
using project.Model.Users;   

namespace project.Model;

public class Rental
{ public User User { get; }
    public Hardware.Hardware Equipment { get; }
    public DateTime RentalDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ActualReturnDate { get; set; } 

    public Rental(User user, Hardware.Hardware equipment, int daysLimit)
    {
        User = user;
        Equipment = equipment;
        RentalDate = DateTime.Now;
        DueDate = DateTime.Now.AddDays(daysLimit);
        ActualReturnDate = null; 
    }
}