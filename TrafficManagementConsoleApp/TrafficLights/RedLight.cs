namespace TrafficManagementConsoleApp.TrafficLights;

public class RedLight : ITrafficLight
{
    public TrafficLightType Type { get; } = TrafficLightType.RedLight;

    public async Task Next(ITrafficSignal signal)
    {
        await Task.CompletedTask;

        signal.CurrentLight = new GreenLight();
    }

    public void Report(ITrafficSignal Signal)
    {
        Signal.ReportLight("Red Light...🔴");
    }
}