using UnityEngine;
using System.Collections;

public class lose : MonoBehaviour {
	private float starttime;
	public int timelimit=60;
	int x;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = timelimit;
		starttime=(Time.timeSinceLevelLoad);
		var min=starttime/60;
		var sec=starttime%60;
		while (x>=0) {
			x--;
		}
		
		
		if (starttime >= timelimit) {
			Application.LoadLevel ("lose");
			
		}
		
	}
	
}
