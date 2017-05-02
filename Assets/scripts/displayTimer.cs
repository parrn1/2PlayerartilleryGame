using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayTimer : MonoBehaviour {

	private Text timerText;

	// Use this for initialization
	void Start () 
	{

		timerText = gameObject.GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		timerText.text = timer.minutes + ":" + timer.seconds;

	}
}
