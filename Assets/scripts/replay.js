#pragma strict



 

public var 	blinkingtext = false;

 

function Start() {

blinking();


 }

function blinking()

    {

// Fancy pants flash of label on and off    

while (1) {

blinkingtext = true;

 yield WaitForSeconds(.5);

 blinkingtext = false;

 yield WaitForSeconds(.5);  

}

 

}

 

function OnGUI() {

 

 if( blinkingtext == true)
{

GUI.color = Color.white;
GUI.Box(Rect(350,500,300,30),"PRESS SPACE TO CONTINUE");

 }
 if(Input.GetKeyDown(KeyCode.Space))
{
Application.LoadLevel("levels");

}

}



