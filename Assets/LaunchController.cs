﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LaunchController : MonoBehaviour {

	string StaticIPString;
	string SaveFileName;
	//public InputField FilaNameInput;
	public Text IpInput_field;
	public Text FileName_field;


	// Use this for initialization
	void Start () {
		Cursor.visible = true;

		//Loading parameters from the playerrefs.
		if (PlayerPrefs.HasKey ("SaveFileNameStored")) {
			SaveFileName = PlayerPrefs.GetString ("SaveFileNameStored");
			GameObject.Find ("FileNamePlaceholderText").gameObject.GetComponent<Text> ().text = SaveFileName; 
			Debug.Log("FileNameStored: " + SaveFileName);
			//if (SingleUserSession) { Debug.Log( "single user session");
			//} else { Debug.Log ("multi user session");
		}

		if (PlayerPrefs.HasKey ("StaticIPStored")) {
			StaticIPString = PlayerPrefs.GetString ("StaticIPStored");
			GameObject.Find ("IP_PlaceholderText").gameObject.GetComponent<Text> ().text = StaticIPString; 
			Debug.Log("StaticIPStored: " + StaticIPString);
			//if (SingleUserSession) { Debug.Log( "single user session");
			//} else { Debug.Log ("multi user session");
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public  void LaunchSession0(){


		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session0");
		} else {
			string b = "Session0";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session0 parameters loaded - long baseline");
		SceneManager.LoadScene (2);
	}


// session 1, one user, no adaptations.
	public  void LaunchSession1(){
		if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
			PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespSelf")) {
			PlayerPrefsX.SetBool ("Param_RespSelf", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegSelf")) {
			PlayerPrefsX.SetBool ("Param_EegSelf", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespOther")) {
			PlayerPrefsX.SetBool ("Param_RespOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegOther")) {
			PlayerPrefsX.SetBool ("Param_EegOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session1");
		} else {
			string b = "Session1";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session1 parameters loaded - one user, no adaptations");
		SceneManager.LoadScene (1);

	}


// session 2, one user, respiration only
	public  void LaunchSession2(){
		if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
			PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespSelf")) {
			PlayerPrefsX.SetBool ("Param_RespSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_RespSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegSelf")) {
			PlayerPrefsX.SetBool ("Param_EegSelf", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespOther")) {
			PlayerPrefsX.SetBool ("Param_RespOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegOther")) {
			PlayerPrefsX.SetBool ("Param_EegOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session2");
		} else {
			string b = "Session2";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}



		Debug.Log ("Session2 parameters loaded - one user, respiration only");
		SceneManager.LoadScene (1);
		}
		





// session 3, one user, eeg only
	public  void LaunchSession3(){
	if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
		PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespSelf")) {
		PlayerPrefsX.SetBool ("Param_RespSelf", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_RespSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegSelf")) {
		PlayerPrefsX.SetBool ("Param_EegSelf", true);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_EegSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespOther")) {
		PlayerPrefsX.SetBool ("Param_RespOther", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_RespOther", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegOther")) {
		PlayerPrefsX.SetBool ("Param_EegOther", false);
	} else {
		bool b = false;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

	}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session3");
		} else {
			string b = "Session3";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session3 parameters loaded - one user, eeg only");
		SceneManager.LoadScene (1);

	}



// session 4 - two users, no adaptations.
public  void LaunchSession4(){
	if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
		PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespSelf")) {
		PlayerPrefsX.SetBool ("Param_RespSelf", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_RespSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegSelf")) {
		PlayerPrefsX.SetBool ("Param_EegSelf", false);
	} else {
		bool b = false;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespOther")) {
		PlayerPrefsX.SetBool ("Param_RespOther", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_RespOther", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegOther")) {
		PlayerPrefsX.SetBool ("Param_EegOther", false);
	} else {
		bool b = false;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

	}
		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session4");
		} else {
			string b = "Session4";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}




		Debug.Log ("Sessio4 parameters loaded - two users, no adaptations.");
		SceneManager.LoadScene (1);
	}


// session 5, two users, respiration only
public  void LaunchSession5(){
	if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
		PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
	} else {
		bool b = false;
		PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespSelf")) {
		PlayerPrefsX.SetBool ("Param_RespSelf", true);
	} else {
		bool b = true;
		PlayerPrefsX.SetBool ("Param_RespSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegSelf")) {
		PlayerPrefsX.SetBool ("Param_EegSelf", false);
	} else {
		bool b = false;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

	}

	if (PlayerPrefs.HasKey ("Param_RespOther")) {
		PlayerPrefsX.SetBool ("Param_RespOther", true);
	} else {
		bool b = true;
		PlayerPrefsX.SetBool ("Param_RespOther", b);

	}

	if (PlayerPrefs.HasKey ("Param_EegOther")) {
		PlayerPrefsX.SetBool ("Param_EegOther", true);
	} else {
		bool b = true;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

	}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session5");
		} else {
			string b = "Session5";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session5 parameters loaded - two users, respiration only");
		SceneManager.LoadScene (1);
	}


//session 6 - two users, eeg only
public  void LaunchSession6(){
		if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
			PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespSelf")) {
			PlayerPrefsX.SetBool ("Param_RespSelf", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegSelf")) {
			PlayerPrefsX.SetBool ("Param_EegSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespOther")) {
			PlayerPrefsX.SetBool ("Param_RespOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegOther")) {
			PlayerPrefsX.SetBool ("Param_EegOther", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session6");
		} else {
			string b = "Session6";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session6 parameters loaded -two users, eeg only");
		SceneManager.LoadScene (1);
	}

	//session 6 - two users, eeg only
public  void LaunchSession7(){
		if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
			PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespSelf")) {
			PlayerPrefsX.SetBool ("Param_RespSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_RespSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegSelf")) {
			PlayerPrefsX.SetBool ("Param_EegSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespOther")) {
			PlayerPrefsX.SetBool ("Param_RespOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_RespOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegOther")) {
			PlayerPrefsX.SetBool ("Param_EegOther", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session7");
		} else {
			string b = "Session7";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session7 parameters loaded -one user, eeg & respiration");
		SceneManager.LoadScene (1);
	}

public  void LaunchSession8(){
		if (PlayerPrefs.HasKey ("Param_SingleUserSession")) {
			PlayerPrefsX.SetBool ("Param_SingleUserSession", false);
		} else {
			bool b = false;
			PlayerPrefsX.SetBool ("Param_SingleUserSession", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespSelf")) {
			PlayerPrefsX.SetBool ("Param_RespSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_RespSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegSelf")) {
			PlayerPrefsX.SetBool ("Param_EegSelf", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_EegSelf", b);

		}

		if (PlayerPrefs.HasKey ("Param_RespOther")) {
			PlayerPrefsX.SetBool ("Param_RespOther", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_RespOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_EegOther")) {
			PlayerPrefsX.SetBool ("Param_EegOther", true);
		} else {
			bool b = true;
			PlayerPrefsX.SetBool ("Param_EegOther", b);

		}

		if (PlayerPrefs.HasKey ("Param_SessionID")) {
			PlayerPrefs.SetString ("Param_SessionID", "Session7");
		} else {
			string b = "Session8";
			PlayerPrefs.SetString ("Param_SessionID", b);

		}


		Debug.Log ("Session7 parameters loaded - two users, eeg & respiration");
		SceneManager.LoadScene (1);
	}




public void SetStaticIP(string value7) {
		StaticIPString = IpInput_field.text.ToString();

		if (PlayerPrefs.HasKey ("StaticIPStored")) {
			PlayerPrefs.SetString ("StaticIPStored", StaticIPString);
			Debug.Log ("IP saved as: " + StaticIPString);
		} else {
			string arvo1 = "127.0.0.1";
			PlayerPrefs.SetString ("StaticIPStored", arvo1);			
			PlayerPrefs.SetString ("StaticIPStored", StaticIPString);
			Debug.Log ("Static IP: " + StaticIPString);
		}
	}

public void SetSaveFileName(string saveFieldInput) {
		
		SaveFileName = FileName_field.text.ToString();
	

		if (PlayerPrefs.HasKey ("SaveFileNameStored")) {
			PlayerPrefs.SetString ("SaveFileNameStored", SaveFileName);
			Debug.Log ("Data file saved as: " + SaveFileName);

		} else {
			string arvo1 = "DynaEmpData001.txt";
			PlayerPrefs.SetString ("SaveFileNameStored", arvo1);			
			PlayerPrefs.SetString ("SaveFileNameStored", SaveFileName);
			Debug.Log ("Data file saved as: " + SaveFileName);
		}
	}



}
