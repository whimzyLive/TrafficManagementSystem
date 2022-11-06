using TrafficManagementConsoleApp;

var signal = new TrafficSignal();

// Initial Red Light,
// Wait for 2 sec
Console.WriteLine("Waiting for 2 seconds....");
await Task.Delay(2000);

// Change to Green
signal.ChangeLight();

// Wait for 4 seconds
Console.WriteLine("Waiting for 4 seconds....");
await Task.Delay(4000);

// Change to Yellow
signal.ChangeLight();

// Wait for 1 seconds
Console.WriteLine("Waiting for 1 seconds....");
await Task.Delay(1000);

// Change to Red
signal.ChangeLight();