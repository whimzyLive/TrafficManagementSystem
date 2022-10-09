using TrafficManagementConsoleApp.TrafficLights;

namespace TrafficManagementConsoleApp;


public abstract class BaseTrafficSignal : ITrafficSignal
{
    public string Identifier { get; set; }
    public ITrafficLight CurrentLight { get; set; }
    public ITrafficLight? TargetLight { get; set; }

    public BaseTrafficSignal(string identifier, ITrafficLight light)
    {
        Identifier = identifier;
        CurrentLight = light;
    }

    public abstract Task Go(TimeSpan? openFor);

    public abstract Task Stop();

    public void ReportLight(string message)
    {
        Console.WriteLine(message);
    }

    public async Task ChangeLights()
    {
        await CurrentLight.Next(this);
        CurrentLight.Report(this);

        if (CurrentLight.Type != TargetLight!.Type)
        {
            await ChangeLights();
        }
    }
}