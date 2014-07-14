using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float speed = 10;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.velocity=new Vector3(Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;

	}
}
