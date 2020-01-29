using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public static int x = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel("menu");
			x =0;
		}
		if(Input.GetKeyDown(KeyCode.Escape)){

			x =0;
		}

	}
	void OnGUI(){
		
		GUI.Box (new Rect (10, 0, 100, 30), "SCORE :"  + x);
	}
}
