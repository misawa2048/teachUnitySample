using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	public float speed=200.0f;
	public float lifeTime=4.0f;
	public GameObject explodeObj;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward*speed*Time.deltaTime,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if(lifeTime < 0.0f){
			Destroy(gameObject);
		}
	}
	
	private void SM_Explode(){
		GameObject.Instantiate(explodeObj,transform.position,Quaternion.identity);
		Destroy(gameObject);
	}
}
