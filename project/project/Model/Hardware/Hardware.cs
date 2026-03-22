namespace project.Model.Hardware;

public abstract class Hardware
{ public string Id { get; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool IsInService { get; set; } = false;
    protected Hardware(string name)
    {
        Id = "HW-" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        Name = name;
    }
}