 var gText: GUIText; // drag here the GUIText from Hierarchy view
 var timer: float;
 var count: int;
 var stop : float;
 var asd : int;

 function Start()
 {
 	var name : String;
 	name = GameObject.FindGameObjectWithTag("Level").gameObject.name;
  	switch(name)
 	{
 		case "Level1":
 			timer = 21;
 			stop = 10;
 		break;
 		case "Level2":
 			timer = 31;
 			stop = 10;
 		break;
 		case "Level3":
 			timer = 31;
 			stop = 10;
 		break;
 		case "Level4":
 			timer = 36;
 			stop = 10;
 		break;
 		case "Level5":
 			timer = 46;
 			stop = 10;
 		break;
 		case "Level6":
 			timer = 61;
 			stop = 10;
 		break;
 		case "Level7":
 			timer = 91;
 			stop = 10;
 		break;
 		case "Level8":
 			timer = 101;
 			stop = 10;
 		break;
 		case "Level9":
 			timer = 76;
 			stop = 10;
 		break;
 		case "Level10":
 			timer = 61;
 			stop = 10;
 		break;
 		case "Level11":
 			timer = 71;
 			stop = 10;
 		break;
 		case "Level12":
 			timer = 121;
 			stop = 10;
 		break;
 
 	}
 }

 function Update(){
 	 asd = GameObject.FindGameObjectsWithTag("Asteroids").Length;
	 if(GameObject.FindGameObjectWithTag("Level").transform.position.y <= stop)
	 {
		if(timer >= 0)
		{
	   		timer -= Time.deltaTime;
	   		count = timer;
	   		if(count >= 10)
	   		{
	   			gText.text = count.ToString();
	   		}
	   		else
	   		{
	   			gText.text = "0" + count.ToString();
	   			gText.color = Color.red;
	   		}
	   			
	   	}
	 }
}