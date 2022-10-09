namespace TrafficManagementConsoleApp.TrafficLights;

public class YellowLight : ITrafficLight
{
    public TrafficLightType Type { get; } = TrafficLightType.YellowLight;

    public async Task Next(ITrafficSignal signal)
    {
        await Task.Delay((int)TimeSpan.FromSeconds(2).TotalMilliseconds);

        signal.CurrentLight = new RedLight();
    }

    public void Report(ITrafficSignal Signal)
    {
        Signal.ReportLight($"Yellow Light...🟡");
    }
}