using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class arrayHolderSpawn : NetworkBehaviour {
	[SyncVar]
	public float angleX, angleY;

	float originalX = -1;
	float originalY = -1;
	float sendX, sendY;
	public GameObject array, crankx, cranky, canvas, crankOne, crankTwo, cmdTable, cmdCranks, cmdGun, cmdChair, timerCanvas;
	// Use this for initialization
	void Start () {
		angleX = originalX;
		angleY = originalY;
		if (this.isLocalPlayer == true) {
			if (this.isServer == true)
				Instantiate (array, new Vector3 (0, 0, 0), Quaternion.identity);
			if (this.isServer == false) {
				crankOne = (GameObject) Instantiate (crankx, new Vector3 (204.57f, 49.04327f, 226.1f), Quaternion.identity);
				crankTwo = (GameObject) Instantiate (cranky, new Vector3 (194.6998f, 49.04327f, 226.1f), Quaternion.identity);
				Instantiate (cmdTable, new Vector3 (247.8098f, 58.09328f, 256.607f), Quaternion.Euler(0,270,0));
				Instantiate (cmdCranks, new Vector3 (180.6098f, 28.49327f, 258.4037f), Quaternion.Euler(0,270,0));
				Instantiate (cmdGun, new Vector3 (39.40974f, 4.393274f, 227.1037f), Quaternion.Euler(0,270,0));
				Instantiate (canvas, new Vector3 (400f, 5.393274f, 2f), Quaternion.Euler(0,270,0));
				Instantiate (cmdChair, new Vector3 (175.3498f, 15.42327f, 287.3037f), Quaternion.Euler(0,270,0));
				Instantiate (timerCanvas, new Vector3(512,384,0), Quaternion.identity);
				//Instantiate (canvas, new Vector3 (0, 0, 442), Quaternion.identity);

			}
		}
	}

	// Update is called once per frame
	void Update () {
		//References the shooter while playing as the shooter
		if (this.isLocalPlayer == true) {
			if (this.isServer == false) {
				angleX = crankOne.transform.rotation.eulerAngles.z/10;
				angleY = crankTwo.transform.rotation.eulerAngles.z/10;
				if (Input.GetKeyDown (KeyCode.Space) == true)
					CmdGetAngle (angleX, angleY);
			}

		}

		//References the shooter while playing as the spotter

			if (this.isServer == false) {
				if (angleX > -1 || angleY >-1 ) {
					sendX = angleX;
					sendY = angleY;
					angleX = -1;
					angleY = -1;
					setUpCoord.shoot (sendX, sendY);
				}

			if (timer.timeLeft<= 1) 
			{

				CmdGameOver();

			}

							
		}

		if (clear.win == true) {
			CmdVictory();
		}

	}

	[Command]
	public void CmdGetAngle (float angle1, float angle2){
		angleX = angle1;
		angleY = angle2;
		RpcSetAngle (angle1, angle2);
	}

	[ClientRpc]
	public void RpcSetAngle (float angle1, float angle2){
		angleX = angle1;
		angleY = angle2;
		setUpCoord.shoot (angleX, angleY);
	
	}
		

	[Command]
	public void CmdGameOver(){
		RpcGameOver();
	}

[ClientRpc]
public void RpcGameOver(){
	SceneManager.LoadScene ("GameOver");
}

	[Command]
	public void CmdVictory(){
		RpcVictory();
	}

	[ClientRpc]
	public void RpcVictory(){
		SceneManager.LoadScene ("victory");
	}
}
