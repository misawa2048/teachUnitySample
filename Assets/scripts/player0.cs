using UnityEngine;
using System.Collections;

public class player0 : MonoBehaviour {
	public float speed = 200.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			rigidbody.AddForce(transform.up*Time.deltaTime*speed);
		}else if(Input.GetKey(KeyCode.DownArrow)){
			rigidbody.AddForce(-transform.up*Time.deltaTime*speed);
		}else if(Input.GetKey(KeyCode.RightArrow)){
			rigidbody.AddForce(transform.right*Time.deltaTime*speed);
		}else if(Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.AddForce(-transform.right*Time.deltaTime*speed);
		}
	}
}
