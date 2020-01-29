#pragma strict

public var timeleft:int =60;
private var  x:int ;
function Start () {

}
private var starttime:int;
function Update () {



starttime=(Time.timeSinceLevelLoad);
x = timeleft -starttime;

if(x == 0)
{
Application.LoadLevel("lose3");
}

}

function OnGUI()
{
GUI.Box(new Rect(500,0,100,30),"TIME :" + x);
}