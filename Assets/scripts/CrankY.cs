using UnityEngine;
using System.Collections;

public class CrankY : MonoBehaviour {

	AudioSource audio;

	public static int angleY;
	int yRot = 0;
	// Use this for initialization
	void Start () 
	{

		audio = GetComponent<AudioSource>();

	}


	void Update () 
	{
		angleY = (int)this.transform.rotation.eulerAngles.z;
		Debug.Log (angleY);
		if (yRot > 0) {
			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.rotation = Quaternion.AngleAxis(yRot, transform.forward);
				yRot--;
				audio.Play ();

			}
		}

		if(yRot < 360){
			if (Input.GetKey(KeyCode.UpArrow))
			{
				transform.rotation = Quaternion.AngleAxis(yRot, transform.forward);
				yRot++;
				//xRot = (int)Mathf.Repeat(xRot, 360);
				audio.Play ();
			}

		}

		/*void OnMouseDrag()
		{

			Vector3 direction = mousePos - transform.position;
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
			Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

		}*/

	}
}
