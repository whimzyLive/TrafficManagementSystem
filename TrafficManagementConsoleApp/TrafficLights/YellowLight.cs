namespace TrafficManagementConsoleApp.TrafficLights;

public class YellowLight : ITrafficLight
{
    public TrafficSignal TrafficSignal { get; set; }

    public YellowLight(TrafficSignal trafficSignal)
    {
        TrafficSignal = trafficSignal;
    }

    public void ChangeLight()
    {
        Console.WriteLine("Changing Light Yellow => Red...");
        TrafficSignal.CurrentLight = TrafficSignal.RedLight;
    }
}