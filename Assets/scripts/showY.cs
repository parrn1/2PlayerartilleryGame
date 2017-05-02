using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showY : MonoBehaviour {

	private Text yCoord;

	// Use this for initialization
	void Start () 
	{

		yCoord = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () 
	{
		yCoord.text =  "" + displayY.newY;


	}
}
