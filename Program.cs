var signal = new TrafficSignal(TimeSpan.FromSeconds(5));

signal.TurnOn();
await signal.Go();
await signal.Stop();
