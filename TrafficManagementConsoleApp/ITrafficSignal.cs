using TrafficManagementConsoleApp.TrafficLights;

namespace TrafficManagementConsoleApp;

public interface ITrafficSignal
{
    public ITrafficLight CurrentLight { get; set; }
    public ITrafficLight? TargetLight { get; set; }

    public Task Go(TimeSpan? openFor);
    public Task Stop();
    public void ReportLight(string message);
    public Task ChangeLights();
}