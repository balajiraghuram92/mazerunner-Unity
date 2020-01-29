#pragma strict

function Start () {

}

function Update () {

}
function OnGUI()
{
if(GUI.Button(new Rect(250,100,100,30),"START"))
{
Application.LoadLevel("level1");

}

if(GUI.Button(new Rect(250,200,100,30),"LEVELS"))
{
Application.LoadLevel("levels");
}

if(GUI.Button(new Rect(250,300,100,30),"QUIT"))
{
Application.Quit();
}
}