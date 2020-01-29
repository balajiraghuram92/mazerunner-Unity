using UnityEngine;
using System.Collections;

public class animation: MonoBehaviour {
	
	private Animator animator;
	
	bool up,down,left,right;
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
		
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			
			up = true;
			
			
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			down = true;
			
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			right = true;
			
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			left = true;
			
		} 
		
		if (Input.GetKeyUp(KeyCode.UpArrow)){
			up = false;
			
		}
		else if (Input.GetKeyUp(KeyCode.DownArrow)){
			down = false;
		}
		else if (Input.GetKeyUp(KeyCode.LeftArrow)){
			left = false;
		}
		else if (Input.GetKeyUp(KeyCode.RightArrow)){
			right = false;
		}
		
		if( up == true){
			animator.SetInteger ("direction", 2);
		}else if( down == true){
			animator.SetInteger ("direction", 0);
		}else if( left == true){
			animator.SetInteger ("direction", 3);
		}else if( right == true){
			animator.SetInteger ("direction", 1);
		}
		else
		{
			animator.SetInteger ("direction", 4);
		}
	}
}

