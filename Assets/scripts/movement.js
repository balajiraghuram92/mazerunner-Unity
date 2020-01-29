#pragma strict
var speed :float = 0.04f ;

function Start () {

}

function Update () {
 

if(Input.GetKey(KeyCode.UpArrow))
{
transform.position.y += speed;
}
if(Input.GetKey(KeyCode.DownArrow))
{
transform.position.y -=speed;
}
if(Input.GetKey(KeyCode.LeftArrow))
{
transform.position.x -= speed;
}
if(Input.GetKey(KeyCode.RightArrow))
{
transform.position.x +=speed;
}

}