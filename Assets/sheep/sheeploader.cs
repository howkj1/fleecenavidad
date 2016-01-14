using UnityEngine;
using System.Collections;

public class sheeploader : MonoBehaviour {

	private void OnGUI()
	{
		// if(
		// GUI.Button(new Rect ((widthPlacement), (heightPlacement), widthSize, heightSize), "buttonText")){
		// 		Application.LoadLevel("yourLevelName");
		// }

		if (GUI.Button (new Rect (Screen.width * .5f +200, Screen.height * .5f, 100, 60), "Infinity Mode"))
		{
			Application.LoadLevel ("level1");
		}



		if (GUI.Button (new Rect (Screen.width * .5f +200, Screen.height * .5f +80, 100, 60), "Sky Mode"))
		{
			Application.LoadLevel ("level2");
		}

	}
}
