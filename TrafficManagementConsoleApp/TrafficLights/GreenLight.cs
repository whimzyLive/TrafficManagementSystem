namespace TrafficManagementConsoleApp.TrafficLights;

public class GreenLight : ITrafficLight
{
    public TrafficSignal TrafficSignal { get; set; }

    public GreenLight(TrafficSignal signal)
    {
        TrafficSignal = signal;
    }

    public void ChangeLight()
    {
        Console.WriteLine("Changing Light Green => Yellow...");
        TrafficSignal.CurrentLight = TrafficSignal.YellowLight;
    }
}