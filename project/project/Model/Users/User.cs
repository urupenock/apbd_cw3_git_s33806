namespace project.Model.Users;

public abstract class User
{ public string Id { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public abstract int MaxRentalLimit { get; }
    protected User(string id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}