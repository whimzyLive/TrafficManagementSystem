using TrafficLights;

public class TrafficSignal
{
  public ITrafficLight? Light { get; set; } // No traffic light instance simulates light off scenario 

  public void TurnOn(ITrafficLight light)
  {
    Light = light;
  }

  public void ChangeLight()
  {
    if (Light == null)
    {
      Console.WriteLine("Light is off, start the light first...");
    }

    Light!.Next(this);
  }
}