namespace project.Model.Users;

public class Student : User
{
    public override int MaxRentalLimit => 2;
    public Student(string id, string fName, string lName) : base(id, fName, lName) { }
}