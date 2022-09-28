namespace TrafficLights;

public class GreenLight : ITrafficLight
{
  public TrafficLightType Type { get; } = TrafficLightType.GreenLight;

  public Task Next(TrafficSignal signal)
  {
    signal.CurrentLight = new YellowLight();

    return Task.CompletedTask;
  }

  public void Report(TrafficSignal signal)
  {
    signal.ReportLight("Green Light...🟢");
  }
}