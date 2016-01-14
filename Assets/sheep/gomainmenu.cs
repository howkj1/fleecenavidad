using UnityEngine;
using System.Collections;

public class gomainmenu : MonoBehaviour {
	private void OnGUI()
	{
		// if(
		// GUI.Button(new Rect ((widthPlacement), (heightPlacement), widthSize, heightSize), "buttonText")){
		// 		Application.LoadLevel("yourLevelName");
		// }

		if (GUI.Button (new Rect (Screen.width -150, Screen.height -80, 100, 60), "Menu")) 
		{
				Application.LoadLevel ("menu");
		}

	}
}
