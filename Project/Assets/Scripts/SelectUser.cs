using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class SelectUser : MonoBehaviour {

	public Text UserName;

	string myDocs = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
	string myGames;
	string CandD;
	string newUser;
	bool exists;



	// Use this for initialization
	public void GameDocs()
	{
		myGames = myDocs + "\\My Games";
		CandD = myGames + "\\Connect&Destroy";
		exists = Directory.Exists (myGames);

		if (exists) {
			Directory.CreateDirectory(CandD);
		} 
		else {
			CandD = myDocs + "\\Connect&Destroy";
			Directory.CreateDirectory(CandD);
		}
	}

	public void UserDocs()
	{
		if (UserName.GetComponent<Text> ().text.Length != 0) 
		{
			if (Directory.Exists (CandD)) {
					newUser = CandD + "\\" + UserName.GetComponent<Text> ().text;
					if (!Directory.Exists (newUser)) {
							Directory.CreateDirectory (newUser);
							string temp = newUser + "\\currentUser_temp";
							File.Create (temp);
					} else {
							string temp = newUser + "\\currentUser_temp";
							File.Create (temp);
					}
					Debug.Log (newUser);
			} else {
					GameDocs ();
					newUser = CandD + "\\" + UserName.GetComponent<Text> ().text;
					if (!Directory.Exists (newUser)) {
							Directory.CreateDirectory (newUser);
							string temp = newUser + "\\currentUser_temp";
							File.Create (temp);
					} else {
						string temp = newUser + "\\currentUser_temp";
						File.Create (temp);
					}
			}
			string[] dirs = Directory.GetFiles(CandD.ToString(), "currentUser_temp", SearchOption.AllDirectories);
			if(dirs.Length == 0) 
			{
				Debug.Log("File not found");
			}
			else
			{
				Debug.Log(dirs[0]);
			}
		}
	}
}
