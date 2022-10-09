using TrafficLights;

public class VehicleSignal : BaseTrafficSignal
{
  public TrafficController TrafficController { get; set; }
  public VehicleSignal(
    TrafficController controller,
    string identifier,
    ITrafficLight light) : base(identifier, light)
  {
    TrafficController = controller;
  }

  public override async Task Go(TimeSpan? openFor)
  {
    TargetLight = new GreenLight();
    await ChangeLights();

    Console.WriteLine($"===> {Identifier} vehicles Go");
    if (openFor.HasValue)
    {
      await Task.Delay((int)openFor.Value.TotalMilliseconds);
      await Stop();
    }
  }

  public override async Task Stop()
  {
    TargetLight = new RedLight();
    await ChangeLights();

    Console.WriteLine($"===> {Identifier} vehicles Stop");
  }
}