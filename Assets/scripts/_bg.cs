using UnityEngine;
using System.Collections;

public class _bg : MonoBehaviour {
	public Vector2 spd = new Vector2(0.1f,0.1f);
	public string texPropertyName = "_MainTex";
	private Vector2 ofs;
	
#if false
	private static _bg sInstance = null;

	void Awake(){
		if(sInstance){
			DestroyImmediate(gameObject);
		}else{
			sInstance = this;
		}
	}
#endif
	
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		ofs = renderer.material.GetTextureOffset(texPropertyName);
	}
	
	// Update is called once per frame
	void Update () {
		ofs += spd* Time.deltaTime;
		renderer.material.SetTextureOffset (texPropertyName, ofs);
	}
}
