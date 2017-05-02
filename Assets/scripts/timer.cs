using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class timer : NetworkBehaviour {

	public static float timeLeft = 300;

	public static string minutes;

	public static string seconds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{


		timeLeft -= Time.deltaTime;

		minutes = Mathf.Floor (timeLeft / 60).ToString ("00");
		seconds = Mathf.Floor (timeLeft % 60).ToString ("00");


	}
}
