#pragma strict
var moveRight : KeyCode;
 
var moveLeft : KeyCode;
var speed : float = 10;
function Update ()
 
{
 
if (Input.GetKey(moveRight))
 
{
 
GetComponent.<Rigidbody2D>().velocity.x = speed;
 
}
 
else if (Input.GetKey(moveLeft))
 
{
 
GetComponent.<Rigidbody2D>().velocity.x = speed *-1;
 
}
 
else
 
{
 
GetComponent.<Rigidbody2D>().velocity.x = 0;
 
}
 
}