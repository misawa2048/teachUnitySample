using UnityEngine;
using System.Collections;

public class player4 : MonoBehaviour {
	public float speed = 200.0f;
	public GameObject touchObj;
	private Vector3 hitPos;
	private float defDist;
	private float defSspeed;

	// Use this for initialization
	void Start () {
		hitPos = transform.position;
		defDist = (transform.position - Camera.main.transform.position).magnitude;
		defSspeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce((hitPos-transform.position).normalized*Time.deltaTime*speed);
	}
	
	private void SM_SpeedUp(){
		if(speed<defSspeed*5.0f){
			speed += defSspeed;
		}else{
			speed = defSspeed;
		}
	}

	private void SM_SetTouchPos(Ray _ray){
		hitPos = _ray.GetPoint(defDist);
		Instantiate(touchObj,hitPos,Quaternion.identity);
	}
}
