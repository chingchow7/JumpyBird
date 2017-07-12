using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolvingDoor : MonoBehaviour {

	private int groundSpawnRNG;
	private float GroundWidth = 7.2f;
	private float SkyWidth = 3.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "GroundObstacle") {

			Vector3 groundSpawnPos = other.gameObject.transform.position;
			groundSpawnPos.x += GroundWidth * 5f; // 5 grounds 

			groundSpawnRNG = Random.Range (0, 4);

			switch (groundSpawnRNG) {
			case 0:
				GameObject.Instantiate(Resources.Load("Prefabs/Ground-Full"), groundSpawnPos,new Quaternion(0,0,0,0));
				break;

			case 1:
				GameObject.Instantiate(Resources.Load("Prefabs/Ground-One"), groundSpawnPos,new Quaternion(0,0,0,0));
				break;

			case 2:
				GameObject.Instantiate(Resources.Load("Prefabs/Ground-Two"), groundSpawnPos,new Quaternion(0,0,0,0));
				break;

			case 3:
				GameObject.Instantiate(Resources.Load("Prefabs/Ground-Three"), groundSpawnPos,new Quaternion(0,0,0,0));
				break;
			}

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "Sky") {
			//other.gameObject.transform.position = new Vector3 (skySpawnLoc.transform.position.x, skySpawnLoc.transform.position.y, skySpawnLoc.transform.position.z);
			Vector3 pos = other.gameObject.transform.position;
			pos.x += SkyWidth * 13f; // 13 skies
			other.gameObject.transform.position = pos;

		}
	}
}
