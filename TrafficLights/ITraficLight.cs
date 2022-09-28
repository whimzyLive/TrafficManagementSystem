namespace TrafficLights;

public interface ITrafficLight
{
  public TrafficLightType Type { get; }
  public Task Next(TrafficSignal Signal);
  public void Report(TrafficSignal Signal);

}