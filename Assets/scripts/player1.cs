using UnityEngine;
using System.Collections;

public class player1 : MonoBehaviour {
	public float speed = 200.0f;
	private Vector3 hitPos;
	private float defDist;

	// Use this for initialization
	void Start () {
		hitPos = transform.position;
		defDist = (transform.position - Camera.main.transform.position).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			hitPos = ray.GetPoint(defDist);
		}
		rigidbody.AddForce((hitPos-transform.position).normalized*Time.deltaTime*speed);
	}
}
