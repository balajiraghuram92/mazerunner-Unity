using UnityEngine;
using System.Collections;

public class nextlevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		}
	void   OnCollisionEnter( Collision col) { 
		{
		
		if (col.gameObject.tag == "nextlevel1")
		{
			Application.LoadLevel("level2");
		}
	}
}
}
