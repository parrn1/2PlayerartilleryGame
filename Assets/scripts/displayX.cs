using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public  class displayX : MonoBehaviour {

	public Text xCoord;

	float angleX;
	public static int newX;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		angleX = gameObject.transform.rotation.eulerAngles.z;

		newX = (int)(angleX / 10);

	}
}
