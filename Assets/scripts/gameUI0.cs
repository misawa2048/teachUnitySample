using UnityEngine;
using System.Collections;

// --set Script Execution Order--
public class gameUI0 : MonoBehaviour {
	private bool isButtonHit;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI(){
		if (GUI.Button(new Rect(5,5,80,30), "BOMB!")){
			GameObject[] gos = GameObject.FindGameObjectsWithTag("TagBullet");
			foreach(GameObject go in gos){
				go.SendMessage("SM_Explode");
			}
		}
	}
}
