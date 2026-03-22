using project.Model.Hardware;
using project.Model.Users;
using project.Service;

var rentalService = new RentalService();

Console.WriteLine("=== SYSTEM WYPOŻYCZALNI SPRZĘTU ===");

var laptop = new Laptop("Dell XPS", "Intel i7", 16);
var projector = new Projector("Epson EB", "1920x1080", 120);
var camera = new Camera("Canon R6", "Full Frame", true);

rentalService.AddHardware(laptop);
rentalService.AddHardware(projector);
rentalService.AddHardware(camera);

var student = new Student("S12345", "Diana", "Kofman");
var employee = new Employee("s45998", "Anna", "Volovikova");

rentalService.AddUser(student);
rentalService.AddUser(employee);

Console.WriteLine("\n--- Poprawne wypożyczenie ---");
var result1 = rentalService.RentEquipment(student.Id, laptop.Id);
Console.WriteLine(result1);

Console.WriteLine("\n--- Próba wypożyczenia zajętego sprzętu ---");
var result2 = rentalService.RentEquipment(employee.Id, laptop.Id);
Console.WriteLine(result2);

Console.WriteLine("\n--- Przekroczenie limitu studenta (max 2) ---");
rentalService.RentEquipment(student.Id, projector.Id); 
var result3 = rentalService.RentEquipment(student.Id, camera.Id); 
Console.WriteLine(result3);

Console.WriteLine("\n--- Zwrot w terminie ---");
var result4 = rentalService.ReturnEquipment(laptop.Id);
Console.WriteLine(result4);

Console.WriteLine("\n=== RAPORT KOŃCOWY ===");
var allItems = rentalService.GetAllHardware();
foreach (var item in allItems)
{
    Console.WriteLine($"ID: {item.Id} | Nazwa: {item.Name} | Dostepny: {item.IsAvailable}");
}