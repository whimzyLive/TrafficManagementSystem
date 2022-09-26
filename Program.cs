using TrafficLights;

var signal = new TrafficSignal();

signal.TurnOn(new RedLight());

signal.ChangeLight();
signal.ChangeLight();
