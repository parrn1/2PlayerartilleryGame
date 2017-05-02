using UnityEngine;
using System.Collections;

public class arrayMap : MonoBehaviour {

	//for loop that randomly assigns values to a 6 by 6 array by rolling random nums to asign the values it keeps track of how many of certain values have been rolled so that there cannot be to many of one value

	static int arraySize = 36;//this will need to be updated in setUpCoord and clear

	public static int[,] mapArray = new int[arraySize,arraySize];


	public static int targetX;
	public static int targetY;

	int randomize;
	int setI;
	int setY;

	int setI1;
	int setY1;

	int setI2;
	int setY2;

	int force;
	int coinFlip;



	//put objects into array
	public GameObject [] piece;

	int pick;

	bool skip = false;//use to skip when the overide is set
	bool targetset = false;
	// Use this for initialization
	void Start () 
	{

		targetX = Random.Range (3, 32);
		targetY = Random.Range (3, 32);

		// we can worry about the ratios later
		for(int i = 0; i< arraySize;i++)
		{
			for (int y = 0; y < arraySize; y++) //if array size is increased then max count must be increased to compensate
			{

				pick = 1;

				if (mapArray [i, y] > 0) 
				{

					skip = true;

				}


					
				if (i == targetX && y == targetY) {
					//gets top left
					setI = i;
					setY = y;

					setI1 = i + 1;
					setY1 = y + 1;

					setI2 = setI1 + 1;
					setY2 = setY1 + 1;

					skip = true;
					pick = 6;//top left
					mapArray [i, y] = pick;
					Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY * 10), Quaternion.identity);

					if (setI1 < arraySize) {
						//top middle
						mapArray [setI1, setY] = pick;
						Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY * 10), Quaternion.identity);
					}

					if (setI2 < arraySize) {
						//top right
						mapArray [setI2, setY] = pick;
						Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY * 10), Quaternion.identity);
					}

					if (setY1 < arraySize) {
						//middle left
						mapArray [setI, setY1] = pick;
						Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY1 * 10), Quaternion.identity);
					}

					if (setI1 < arraySize && setY1 < arraySize) {
						//middle center
						mapArray [setI1, setY1] = pick;
						Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY1 * 10), Quaternion.identity);
					}

					if (setI2 < arraySize && setY1 < arraySize) {
						//middle right
						mapArray [setI2, setY1] = pick;
						Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY1 * 10), Quaternion.identity);
					}

					if (setY2 < arraySize) {
						//bottom left
						mapArray [setI, setY2] = pick;
						Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY2 * 10), Quaternion.identity);
					}

					if (setI1 < arraySize && setY2 < arraySize) {
						//bottom center
						mapArray [setI1, setY2] = pick;
						Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY2 * 10), Quaternion.identity);
					}

					if (setI2 < arraySize && setY2 < arraySize) {
						//bottom right
						mapArray [setI2, setY2] = pick;
						Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY2 * 10), Quaternion.identity);
					}

					targetset = true;
				}


				//72
				if (!skip && targetset == false && !(i > targetX - 3 && i < targetX) && !(y > targetY && y < targetY)) 
				{
					randomize = Random.Range (0, 200);//it was going out of bounds
					if (randomize <= 1 || force >= 15) {
						//gets top left
						setI = i;
						setY = y;

						setI1 = i + 1;
						setY1 = y + 1;

						setI2 = setI1 + 1;
						setY2 = setY1 + 1;

						skip = true;
						pick = Random.Range (2, 5);//top left
						mapArray [i, y] = pick;
						Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY * 10), Quaternion.identity);

						if (setI1 < arraySize) 
						{
							pick = Random.Range (2, 5);//top middle
							mapArray [setI1, setY] = pick;
							Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY * 10), Quaternion.identity);
						}

						if (setI2 < arraySize) 
						{
							pick = Random.Range (2, 5);//top right
							mapArray [setI2, setY] = pick;
							Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY * 10), Quaternion.identity);
						}

						if (setY1 < arraySize) 
						{
							pick = Random.Range (2, 5);//middle left
							mapArray [setI, setY1] = pick;
							Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY1 * 10), Quaternion.identity);
						}

						if (setI1 < arraySize && setY1 < arraySize) 
						{
							pick = Random.Range (2, 5);//middle center
							mapArray [setI1, setY1] = pick;
							Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY1 * 10), Quaternion.identity);
						}

						if (setI2 < arraySize && setY1 < arraySize) 
						{
							pick = Random.Range (2, 5);//middle right
							mapArray [setI2, setY1] = pick;
							Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY1 * 10), Quaternion.identity);
						}

						if (setY2 < arraySize) 
						{
							pick = Random.Range (2, 5);//bottom left
							mapArray [setI, setY2] = pick;
							Instantiate (piece [pick], new Vector3 (setI * 10, 0, setY2 * 10), Quaternion.identity);
						}

						if (setI1 < arraySize && setY2 < arraySize) 
						{
							pick = Random.Range (2, 5);//bottom center
							mapArray [setI1, setY2] = pick;
							Instantiate (piece [pick], new Vector3 (setI1 * 10, 0, setY2 * 10), Quaternion.identity);
						}

						if (setI2 < arraySize && setY2 < arraySize) 
						{
							pick = Random.Range (2, 5);//bottom right
							mapArray [setI2, setY2] = pick;
							Instantiate (piece [pick], new Vector3 (setI2 * 10, 0, setY2 * 10), Quaternion.identity);
						}

						force = 0;

					}
				}


				if (skip == false) 
				{
					Instantiate (piece [pick], new Vector3 (i * 10, 0, y * 10), Quaternion.identity);
					//counter [pick] = counter [pick]++;
					mapArray [i, y] = pick;

					coinFlip = Random.Range (0, 2);
					if (coinFlip >=1)
					{
					force++;//if to many blanks in a row then a town appears
					}

				} 


				skip = false;

				targetset = false;

			}

		}

		//set a target position for later use

	}

	// Update is called once per frame
	void Update () {
		
	}
}