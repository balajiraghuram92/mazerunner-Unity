using UnityEngine;
using System.Collections;

public class nextlevel4 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void   OnCollisionEnter( Collision col) { 
		{
			
			if (col.gameObject.tag == "nextlevel4")
			{
				Application.LoadLevel("s2");
			}
		}
	}
}
