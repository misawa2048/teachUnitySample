using UnityEngine;
using System.Collections;

// --set Script Execution Order--
public class _system : MonoBehaviour {

#if false
	private static _system sInstance = null;

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
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	
	}
}
