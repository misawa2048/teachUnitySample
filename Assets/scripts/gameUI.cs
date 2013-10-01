using UnityEngine;
using System.Collections;

// --set Script Execution Order--
public class gameUI : MonoBehaviour {
	public GameObject bombBtnObj;
	public GameObject speedBtnObj;
	private GameObject plObj;
	private bool isButtonHit;
	
	// Use this for initialization
	void Start () {
		plObj = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit mouseHit;
			bool isMouseHit = Physics.Raycast(ray,out mouseHit);
			GameObject hitObj = null;
			if(isMouseHit && (mouseHit.collider!=null)){
				hitObj = mouseHit.collider.gameObject;
			}
			if(hitObj==bombBtnObj){
				GameObject[] gos = GameObject.FindGameObjectsWithTag("TagBullet");
				foreach(GameObject go in gos){
					go.SendMessage("SM_Explode");
				}
			}else if(hitObj==speedBtnObj){
				plObj.SendMessage("SM_SpeedUp");
			}else{
				plObj.SendMessage("SM_SetTouchPos",ray);
			}
		}
	}
	
#if false
	void OnGUI(){
		if (GUI.Button(new Rect(5,5,80,30), "BOMB!")){
			GameObject[] gos = GameObject.FindGameObjectsWithTag("TagBullet");
			foreach(GameObject go in gos){
				go.SendMessage("SM_Explode");
			}
		}
		if (GUI.Button(new Rect(100,5,80,30), "SpeedUp")){
			plObj.SendMessage("SM_SpeedUp");
		}
	}
#endif
}
