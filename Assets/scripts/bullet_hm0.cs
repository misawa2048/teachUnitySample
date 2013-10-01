using UnityEngine;
using System.Collections;

public class bullet_hm0 : MonoBehaviour {
	public float speed=200.0f;
	public float lifeTime=4.0f;
	public GameObject explodeObj;
	public float homingRate=10.0f;
	private GameObject plObj;

	// Use this for initialization
	void Start () {
		plObj = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(plObj!=null){
			Quaternion qua = Quaternion.LookRotation(plObj.transform.position-transform.position);
			transform.rotation = Quaternion.Lerp(transform.rotation,qua,homingRate*Time.deltaTime);
		}
		rigidbody.AddForce(transform.forward*speed*Time.deltaTime);
		
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
