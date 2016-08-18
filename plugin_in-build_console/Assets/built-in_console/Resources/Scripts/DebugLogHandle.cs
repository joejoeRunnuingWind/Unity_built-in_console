using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class DebugLogHandle : MonoBehaviour{

	public Queue<string> logs;
	const int queueSize = 30;
	public delegate void logChangedHandle ();
	public event logChangedHandle logChanged;

	// Use this for initialization
	void Start() {
		Application.logMessageReceivedThreaded += SaveInQueue;
		logs = new Queue<string> (queueSize);
	}
		
	public void AppendLine(string log){

		if (logs.Count >= queueSize) {
			logs.Dequeue ();
		}
		logs.Enqueue (log);
		logChanged ();

	}

	public void SaveInQueue(string log, string stackTrace, LogType t){
		AppendLine (log);
	}

}
