using TrafficLights;

public class TrafficController
{
  public VehicleSignal NorthSouthSignal { get; set; }
  public VehicleSignal EastWestSignal { get; set; }


  public TrafficController()
  {
    NorthSouthSignal = new VehicleSignal(this, "NorthSouth", light: new RedLight());
    EastWestSignal = new VehicleSignal(this, "EastWest", light: new RedLight());
  }

  public async Task Run()
  {
    await NorthSouthSignal.Go(TimeSpan.FromSeconds(10));

    await EastWestSignal.Go(TimeSpan.FromSeconds(8));

    // Recursively Run forever
    await Run();
  }
}