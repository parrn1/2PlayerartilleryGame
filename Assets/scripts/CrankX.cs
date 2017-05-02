using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrankX : MonoBehaviour {

	AudioSource audio;

	public static int angleX;
	int xRot = 0;
		// Use this for initialization
		void Start () 
		{

		audio = GetComponent<AudioSource>();

		}


		void Update () 
		{
		angleX = (int)this.transform.rotation.eulerAngles.z;
		Debug.Log (angleX);
		if (xRot > 0) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.rotation = Quaternion.AngleAxis(xRot, transform.forward);
				xRot--;
				audio.Play ();
	
			}
		}

		if(xRot < 360){
		if (Input.GetKey(KeyCode.RightArrow))
		{
				transform.rotation = Quaternion.AngleAxis(xRot, transform.forward);
				xRot++;
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
