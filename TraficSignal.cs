using TrafficLights;

public class TrafficSignal
{
  public ITrafficLight? CurrentLight { get; set; }
  public ITrafficLight? TargetLight { get; set; }
  public TimeSpan SignalTime { get; }

  public TrafficSignal(TimeSpan signalTime)
  {
    SignalTime = signalTime;
  }

  public async Task Go()
  {
    TargetLight = new GreenLight();
    await ChangeLights();

    Console.WriteLine("**** Go ****");
  }

  public async Task Stop()
  {
    TargetLight = new RedLight();
    await ChangeLights();

    Console.WriteLine("**** Stop ****");
  }

  public void ReportLight(string message)
  {
    Console.WriteLine(message);
  }

  public void TurnOn()
  {
    CurrentLight = new RedLight();
    Console.WriteLine("*Signal is On*");
    CurrentLight.Report(this);
  }

  private async Task ChangeLights()
  {
    await CurrentLight!.Next(this);
    CurrentLight!.Report(this);

    if (CurrentLight!.Type != TargetLight!.Type)
    {
      await ChangeLights();
    }
  }
}