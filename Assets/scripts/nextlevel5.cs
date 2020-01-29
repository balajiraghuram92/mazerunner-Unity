using UnityEngine;
using System.Collections;

public class nextlevel5 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void   OnCollisionEnter( Collision col) { 
		{
			
			if (col.gameObject.tag == "nextlevel5")
			{
				Application.LoadLevel("s3");
			}
		}
	}
}
