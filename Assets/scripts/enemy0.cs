using UnityEngine;
using System.Collections;

public class enemy0 : MonoBehaviour {
	public GameObject playerObj;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(playerObj.transform.position);
		rigidbody.AddForce(transform.forward*0.1f);
	}
}
