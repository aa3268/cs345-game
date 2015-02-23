var gText: GUIText; // drag here the GUIText from Hierarchy view
 var timer: float = 10;
 var count: int;
 function Update(){
   timer -= Time.deltaTime;
   count = timer;
   if(timer >= 0)
   {
   		gText.text = count.ToString();
   	}
   	else
   	{
   		Application.LoadLevel(0);
   	}
 }