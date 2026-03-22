namespace project.Model.Hardware;

public class Projector : Hardware
{ public string Resolution { get; set; }
    public int LampHours { get; set; }
    public Projector(string name, string resolution, int lampHours) : base(name)
    {
        Resolution = resolution;
        LampHours = lampHours;
    }
}