namespace project.Model.Hardware;

public class Laptop : Hardware 
{ public string Processor { get; set; }
    public int RamSize { get; set; }
    public Laptop(string name, string processor, int ram) : base(name)
    {
        Processor = processor;
        RamSize = ram;
    }
}