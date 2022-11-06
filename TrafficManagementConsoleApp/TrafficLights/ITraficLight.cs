namespace TrafficManagementConsoleApp.TrafficLights;

public interface ITrafficLight
{
    public TrafficSignal TrafficSignal { get; set; }
    void ChangeLight();
}