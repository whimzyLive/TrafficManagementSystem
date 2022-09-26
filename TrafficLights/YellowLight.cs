namespace TrafficLights;

public class YellowLight : ITrafficLight
{
  public YellowLight()
  {
    Console.WriteLine("Yellow Light...🟡");
  }
  public void Next(TrafficSignal signal)
  {
    signal.Light = new RedLight();
  }
}