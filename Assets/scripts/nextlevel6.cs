using UnityEngine;
using System.Collections;

public class nextlevel6 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void   OnCollisionEnter( Collision col) { 
		{
			
			if (col.gameObject.tag == "nextlevel6")
			{
				Application.LoadLevel("levels");
			}
		}
	}
}
