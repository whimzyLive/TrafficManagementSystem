using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficManagementConsoleApp.TrafficLights;

namespace TrafficManagementConsoleApp;

public class TrafficSignal
{
	private ITrafficLight _trafficLight = null!;

	public GreenLight GreenLight { get; set; }
	public RedLight RedLight { get; set; }
	public YellowLight YellowLight { get; set; }
	public ITrafficLight CurrentLight
	{
		get { return _trafficLight; }
		set
		{
            _trafficLight = value;
			Console.WriteLine($"<<<==={_trafficLight.GetType().Name}");
		}
	}


	public TrafficSignal()
	{
		GreenLight = new GreenLight(this);
		RedLight = new RedLight(this);
		YellowLight = new YellowLight(this);

		// Initialize Platform with Red Light
		CurrentLight = RedLight;
	}

	public void ChangeLight()
	{
		CurrentLight.ChangeLight();
	}
}
