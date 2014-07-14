using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	public static Transform location;
	public GameObject Bullet;
	public static int numBullets = 10;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")){
			Instantiate (Bullet, transform.position, transform.rotation);
			location = transform;
		}
		location = transform;
	}

}
