using UnityEngine;
using System.Collections;

// --set Script Execution Order--
public class gameUI1 : MonoBehaviour {
	public GameObject bombBtnObj;
	private GameObject plObj;
	
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
			}else{
				plObj.SendMessage("SM_SetTouchPos",ray);
			}
		}
	}
}
