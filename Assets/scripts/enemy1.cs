using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {
	public GameObject playerObj;
	public GameObject bulletObj;
	public float bulletTimer = 1.0f;
	private float defBulletTime;
	
	// Use this for initialization
	void Start () {
		defBulletTime = bulletTimer;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(playerObj.transform.position);
		rigidbody.AddForce(transform.forward*0.1f);
		
		bulletTimer -= Time.deltaTime;
		if(bulletTimer<0.0f){
			bulletTimer += defBulletTime;
			GameObject.Instantiate(bulletObj,transform.position+transform.forward,transform.rotation);
		}
	}
}
