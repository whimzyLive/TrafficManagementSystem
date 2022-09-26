namespace TrafficLights;

public class GreenLight : ITrafficLight
{
  public GreenLight()
  {
    Console.WriteLine("Green Light...🟢");
  }
  public void Next(TrafficSignal signal)
  {
    signal.Light = new YellowLight();
  }
}