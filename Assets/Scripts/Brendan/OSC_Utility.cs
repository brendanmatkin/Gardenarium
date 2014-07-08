// Brendan Matkin 
// http://brendanmatkin.info
// brendan@brendanmatkin.info

using UnityEngine;
using System.Collections;

//public static class OSC_Utility
public class OSC_Utility : MonoBehaviour
{
	private string UDPHost = "127.0.0.1";
	private int listenerPort = 9000;
	private int broadcastPort = 9001;
	private Osc oscHandler;

	static Color OSC_color = Color.white;

	private float red = 0;
	private float green = 0;
	private float blue = 0;

	void Start() {
		UDPPacketIO udp = GetComponent<UDPPacketIO>();
		udp.init(UDPHost, broadcastPort, listenerPort);
		oscHandler = GetComponent<Osc>();
		oscHandler.init(udp);
	}

}