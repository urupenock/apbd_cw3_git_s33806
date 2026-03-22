using project.Model;
using project.Model.Hardware;
using project.Model.Users;

namespace project.Service;

public class RentalService
{
    
    private readonly List<Hardware> _allHardware = new();
    private readonly List<User> _allUsers = new();
    private readonly List<Rental> _allRentals = new();
    
    public void AddHardware(Hardware item)
    {
        _allHardware.Add(item);
    }
    
    public void AddUser(User user)
    {
        _allUsers.Add(user);
    }
    
    public string RentEquipment(string userId, string hardwareId)
    {
        var user = _allUsers.Find(u => u.Id == userId);
        var item = _allHardware.Find(h => h.Id == hardwareId);
        
        if (user == null) return "Błąd: Nie znaleziono użytkownika.";
        if (item == null) return "Błąd: Nie znaleziono sprzętu.";
        if (!item.IsAvailable || item.IsInService) 
            return $"Błąd: Sprzęt {item.Name} jest obecnie niedostępny.";
        
        int activeRentalsCount = _allRentals.Count(r => r.User.Id == userId && r.ActualReturnDate == null);
        if (activeRentalsCount >= user.MaxRentalLimit)
            return $"Błąd: Użytkownik {user.FirstName} przekroczył limit ({user.MaxRentalLimit}).";
        
        var newRental = new Rental(user, item, 7);
        _allRentals.Add(newRental);
        item.IsAvailable = false; 

        return $"Sukces: Wypożyczono {item.Name} użytkownikowi {user.FirstName}.";
    }
    
    public List<Hardware> GetAllHardware() => _allHardware;
}