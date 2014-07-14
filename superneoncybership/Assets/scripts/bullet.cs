using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	float speed = 80;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if(other.tag != "Player")
		Destroy (gameObject);
	}

}
