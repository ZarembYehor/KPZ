using Task2;

var runway1 = new Runway();
var runway2 = new Runway();

var commandCentre = new CommandCentre(new List<Runway> { runway1, runway2 });

var aircraft1 = new Aircraft("Plane1", commandCentre);
var aircraft2 = new Aircraft("Plane2", commandCentre);

aircraft1.RequestLanding();
aircraft2.RequestLanding();

aircraft1.RequestTakeOff();
aircraft2.RequestTakeOff();