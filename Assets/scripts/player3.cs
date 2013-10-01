using UnityEngine;
using System.Collections;

public class player3 : MonoBehaviour {
	public float speed = 2.0f;
	public GameObject touchObj;
	private Vector3 hitPos;
	private float defDist;

	// Use this for initialization
	void Start () {
		hitPos = transform.position;
		defDist = (transform.position - Camera.main.transform.position).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
#if false
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			hitPos = ray.GetPoint(defDist);
			Instantiate(touchObj,hitPos,Quaternion.identity);
		}
#endif
		rigidbody.AddForce((hitPos-transform.position).normalized*Time.deltaTime*speed);
	}

	private void SM_SetTouchPos(Ray _ray){
		hitPos = _ray.GetPoint(defDist);
		Instantiate(touchObj,hitPos,Quaternion.identity);
	}
}
