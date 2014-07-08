private var UDPHost : String = "127.0.0.1";
private var listenerPort : int = 9000;
private var broadcastPort : int = 9001;
private var oscHandler : Osc;

private var eventName : String = "";
private var eventData : String = "";
private var counter : int = 0;
//public var output_txt : GUIText;
//private var tC = Color();
static var OSC_color : Color = Color();

private var red : float = 0;
private var green : float = 0;
private var blue : float = 0;
var tinter;


public function Start ()
{	
	tinter = GameObject.Find("Tinterator");
	var udp : UDPPacketIO = GetComponent("UDPPacketIO");
	udp.init(UDPHost, broadcastPort, listenerPort);
	oscHandler = GetComponent("Osc");
	oscHandler.init(udp);
			
	oscHandler.SetAddressHandler("/eventTest", updateText);
	oscHandler.SetAddressHandler("/counterTest", counterTest);
	oscHandler.SetAddressHandler("/color", updateColor);
	
}
Debug.Log("Running");

public function Update () 
{
	//output_txt.text = "Event: " + eventName + " Event data: " + eventData;
	//var tinter = GameObject.Find("Tinterator");
	tC = Color(red,green,blue);
	tinter.GetComponent("TintSprite").Tint(tC);
    //for (var child : Transform in transform) {
    //	tinter.child.transform.renderer.material.color = tC;
	//}
}	

public function updateColor(oscMessage : OscMessage) : void
{
	//Debug.Log("color!");
	red = oscMessage.Values[0];
	green = oscMessage.Values[1];
	blue = oscMessage.Values[2];
}


public function updateText(oscMessage : OscMessage) : void
{	
	eventName = Osc.OscMessageToString(oscMessage);
	eventData = oscMessage.Values[0];
} 

public function counterTest(oscMessage : OscMessage) : void
{	
	Osc.OscMessageToString(oscMessage);
	counter = oscMessage.Values[0];
} 

