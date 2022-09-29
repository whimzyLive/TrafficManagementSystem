namespace TrafficLights;

public class RedLight : ITrafficLight
{
  public TrafficLightType Type { get; } = TrafficLightType.RedLight;

  public async Task Next(TrafficSignal signal)
  {
    await Task.CompletedTask;

    signal.CurrentLight = new GreenLight();
  }

  public void Report(TrafficSignal Signal)
  {
    Signal.ReportLight("Red Light...🔴");
  }
}