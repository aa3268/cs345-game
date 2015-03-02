 var gText: GUIText; // drag here the GUIText from Hierarchy view
 var timer: float;
 var count: int;
 var stop : float;
 var asd : int;
 public var newTime : boolean;
 function Start()
 {
 	timer = 30;
 	stop = 5;
 
 	newTime = false;
 
 }
 function Reset()
 {
 	var name : String;
 	name = GameObject.FindGameObjectWithTag("Level").gameObject.name;
  	switch(name)
 	{
 		case "Level1(Clone)":
 			timer = 30;
 			stop = 5;
 		break;
 		case "Level2(Clone)":
 			timer = 40;
 			stop = 10;
 		break;
 		case "Level3(Clone)":
 			timer = 40;
 			stop = 10;
 		break;
 	}
 	newTime = false;
 
 }
 function Update(){
 	asd = GameObject.FindGameObjectsWithTag("Asteroids").Length;
	 if(GameObject.FindGameObjectWithTag("Level").transform.position.y <= stop)
	 {
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
	 if(asd == 0)
	 {
	 	gText.text = "Timer";
	 	newTime = true;
	 }
	 
	 if(newTime == true)
	 {
	 	Reset();
	 }
	 
}