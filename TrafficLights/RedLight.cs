namespace TrafficLights;

public class RedLight : ITrafficLight
{
  public RedLight()
  {
    Console.WriteLine("Red Light...🔴");
  }
  public void Next(TrafficSignal signal)
  {
    signal.Light = new GreenLight();
  }
}