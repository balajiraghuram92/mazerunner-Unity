#pragma strict

function Start () {

}

function Update () {

}
function OnGUI()
{
if(GUI.Button(new Rect(470,50,100,30),"LEVEL 1"))
{
Application.LoadLevel("level1");
}

if(GUI.Button(new Rect(470,100,100,30),"LEVEL 2"))
{
Application.LoadLevel("level2");
}
if(GUI.Button(new Rect(470,150,100,30),"LEVEL 3"))
{Application.LoadLevel("level3");
}
if(GUI.Button(new Rect(470,200,100,30),"LEVEL 4"))
{
Application.LoadLevel("s1");
}
if(GUI.Button(new Rect(470,250,100,30),"LEVEL 5"))
{
Application.LoadLevel("s2");
}if(GUI.Button(new Rect(470,300,100,30),"LEVEL 6"))
{
Application.LoadLevel("s3");
}



if(GUI.Button(new Rect(470,400,100,30),"BACK"))
{
Application.LoadLevel("menu");;
}
}