using UnityEngine;
using System.Collections;

public class splashGUI : MonoBehaviour {

	public GUISkin customSkin = null;

	public void OnGUI() {
		if (customSkin != null)
			GUI.skin = customSkin;

		int buttonWidth = 100;
		int buttonHeight = 100;
		int halfButtonWidth = buttonWidth / 2;
		int halfScreenWidth = Screen.width / 2;

		if( GUI.Button(
			new Rect(halfScreenWidth-halfButtonWidth, 390, buttonWidth, buttonHeight), "Play") )


		{
	Application.LoadLevel("omg");
}
}
}
