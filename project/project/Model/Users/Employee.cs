namespace project.Model.Users;

public class Employee : User
{
    public override int MaxRentalLimit => 5;
    public Employee(string id, string firstName, string lastName) 
        : base(id, firstName, lastName)
    {
    }
}