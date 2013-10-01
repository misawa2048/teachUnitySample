using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {
	private Vector3 defScale;
	private float scaleTimer;
	
	// Use this for initialization
	void Start () {
		defScale = transform.localScale;
		scaleTimer = 0.0f;
		transform.localScale = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		scaleTimer += Time.deltaTime*5.0f;
		if(scaleTimer>Mathf.PI){
			Destroy(gameObject);
		}else{
			transform.localScale = Mathf.Sin(scaleTimer)*defScale;
		}
	}
}
