#pragma strict
var text : UnityEngine.UI.Text;
var fadeOut : boolean;
var fadeIn : boolean;
var speed : float;
function Start () {
	Time.timeScale = 1;
	fadeOut = true;
	fadeIn = false;
}

function Update () {
	if(text.color.a > 0 && fadeOut)
	{
		text.color.a = text.color.a - speed * Time.deltaTime;
		if(text.color.a <= 0)
		{
			fadeOut = false;
			fadeIn = true;
		}
	}
	if(text.color.a < 1 && fadeIn)
	{
		
		text.color.a = text.color.a + speed * Time.deltaTime;
		if(text.color.a >= 1)
		{
			fadeOut = true;
			fadeIn = false;
		}
	}
}