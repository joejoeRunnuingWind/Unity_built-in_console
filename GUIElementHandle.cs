using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GUIElementHandle : MonoBehaviour {

	GameObject previousClicked;
	Sprite imageN;
	Sprite imageG;

	// Use this for initialization
	void Start () {
		imageN = (Sprite)Resources.Load("Images/GUI/ButtonNoir", typeof(Sprite));
		imageG = (Sprite)Resources.Load("Images/GUI/ButtonGris", typeof(Sprite));
	}
	
	// Update is called once per frame
	void Update () {
		if (EventSystem.current.currentSelectedGameObject != null) {
			if (previousClicked != null) {
				previousClicked.GetComponent<Image> ().overrideSprite = imageG;
			}
			//Debug.Log (EventSystem.current.currentSelectedGameObject);
			GameObject currentOnClick = EventSystem.current.currentSelectedGameObject;
			if (currentOnClick.tag == "alertButton") {
				//Debug.Log ("change color");
				//Sprite imageN = (Sprite)Resources.Load("Images/GUI/ButtonNoir", typeof(Sprite));
				//Texture2D imageB = (Texture2D)Resources.Load("Images/GUI/ButtonNoir", typeof(Texture2D));
				Debug.Log (imageN);
				currentOnClick.GetComponent<Image> ().overrideSprite = imageN;
				previousClicked = currentOnClick;
			}
		}
	}
}
