using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;

public class DebugLogViewer : MonoBehaviour {

	public Text LogText;
	public DebugLogHandle debugLogHandle;

	// Use this for initialization
	void Start () {
		debugLogHandle.logChanged += OnLogChanged;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLogChanged(){
		StringBuilder stringLogs = new StringBuilder ();
		foreach (string s in debugLogHandle.logs) {
			stringLogs.AppendLine (s);
		}
		LogText.text = stringLogs.ToString ();
	}


}
