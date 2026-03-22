namespace project.Model.Hardware;

public class Camera : Hardware
{ public string SensorType { get; set; } 
    public bool IncludesTripod { get; set; }
    public Camera(string name, string sensorType, bool includesTripod) : base(name)
    {
        SensorType = sensorType;
        IncludesTripod = includesTripod;
    }
}