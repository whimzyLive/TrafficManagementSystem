using TrafficLights;

public class TrafficSignal
{
  public ITrafficLight? CurrentLight { get; set; }
  public ITrafficLight? TargetLight { get; set; }
  public bool Auto { get; set; }

  public TrafficSignal(bool auto)
  {
    Auto = auto;
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

  public async Task AutoShuffle()
  {
    await Go();

    await Task.Delay((int)TimeSpan.FromSeconds(10).TotalMilliseconds);

    await Stop();

    await Task.Delay((int)TimeSpan.FromSeconds(5).TotalMilliseconds);

    if (Auto)
    {
      await AutoShuffle();
    }
  }

  public void ReportLight(string message)
  {
    Console.WriteLine(message);
  }

  public void TurnOn()
  {
    CurrentLight = new RedLight();
    Console.WriteLine("*Signal is On*");
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