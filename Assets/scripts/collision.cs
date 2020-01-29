using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void   OnCollisionEnter( Collision col) { 
		{
			if (col.gameObject.tag == "coin")
			{
				Destroy (col.gameObject);
				score.x +=10;
				audio.Play();
			}
			else if (col.gameObject.tag == "star")
			{
				Destroy (col.gameObject);
				score.x  +=30;
				audio.Play();
			}
		}
	}
}