using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showX : MonoBehaviour {

	private Text xCoord;

	// Use this for initialization
	void Start () 
	{

		xCoord = gameObject.GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		xCoord.text =  "" + displayX.newX;


	}
}
