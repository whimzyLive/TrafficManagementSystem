namespace TrafficManagementConsoleApp.TrafficLights;

public class RedLight : ITrafficLight
{
    public TrafficSignal TrafficSignal { get; set; }

    public RedLight(TrafficSignal trafficSignal)
    {
        TrafficSignal = trafficSignal;
    }

    public void ChangeLight()
    {
        Console.WriteLine("Changing Light Red => Green...");
        TrafficSignal.CurrentLight = TrafficSignal.GreenLight;
    }
}