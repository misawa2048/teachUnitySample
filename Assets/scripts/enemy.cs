using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public GameObject playerObj;
	public GameObject bulletObj;
	public float bulletTimer = 1.0f;
	public float texChangeTimer = 1.0f;
	private float defBulletTime;
	private float defTexChangeTime;
	private int texOfsId;
	
	// Use this for initialization
	void Start () {
		defBulletTime = bulletTimer;
		defTexChangeTime = texChangeTimer;
		texOfsId = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerObj!=null){
			transform.LookAt(playerObj.transform.position);
			rigidbody.AddForce(transform.forward*0.1f);
		}else{
			transform.Rotate(new Vector3(1.0f,1.1f,1.2f)*Time.deltaTime*100.0f);
		}
		
		bulletTimer -= Time.deltaTime;
		if(bulletTimer<0.0f){
			bulletTimer += defBulletTime;
			GameObject.Instantiate(bulletObj,transform.position+transform.forward,transform.rotation);
		}

		texChangeTimer -= Time.deltaTime;
		if(texChangeTimer<0.0f){
			texChangeTimer += defTexChangeTime;
			texOfsId++;
			texOfsId %= 6;
			Vector2 ofs = new Vector2(texOfsId%3, texOfsId/3);
			renderer.material.SetTextureOffset("_MainTex",ofs*0.3333f);
		}
	}
}
