namespace TrafficLights;

public class GreenLight : ITrafficLight
{
  public TrafficLightType Type { get; } = TrafficLightType.GreenLight;

  public Task Next(ITrafficSignal signal)
  {
    signal.CurrentLight = new YellowLight();

    return Task.CompletedTask;
  }

  public void Report(ITrafficSignal signal)
  {
    signal.ReportLight("Green Light...🟢");
  }
}