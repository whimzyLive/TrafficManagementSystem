namespace TrafficLights;

public interface ITrafficLight
{
  public TrafficLightType Type { get; }
  public Task Next(ITrafficSignal Signal);
  public void Report(ITrafficSignal Signal);

}