﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public GameObject AuraExpander;
	public GameObject AuraController;
	float PlayerFA;
	GameObject SessionManager;
	GameObject DataHolder;
	GameObject SpawnPoint1;
	GameObject SpawnPoint2;
	public int PlayerNumber = 0;
	private float breatheNow = 0f;
	private float breathePast = 0f;
	bool inBreathContinues = false;
	bool outBreathContinues = false;

	// Use this for initialization
	void Start () {



		SessionManager = GameObject.Find ("Session Manager");
		DataHolder = GameObject.Find ("Data Holder");

		SpawnPoint1 = GameObject.Find ("Spawn Point 1");
		SpawnPoint2 = GameObject.Find ("Spawn Point 2");

		//find out which player this one is, if it has not been set yet.

		if (PlayerNumber == 0) {
			float dist1 = Vector3.Distance (this.transform.position, SpawnPoint1.transform.position);
			float dist2 = Vector3.Distance (this.transform.position, SpawnPoint2.transform.position);
			if (dist1 < dist2) { 
				PlayerNumber = 2; 
				Debug.Log ("Player 2 found");
			} else {
				PlayerNumber = 1; 
				Debug.Log ("Player 1 found");
			}

			if (PlayerNumber == 1) {
				AuraController = GameObject.Find ("Player1_Manager");
				AuraExpander = GameObject.Find ("Aura_player1Expander");
			} else {
				AuraController = GameObject.Find ("Player2_Manager");
				AuraExpander = GameObject.Find ("Aura_player2Expander");
			}

		}
	}




	
	// Update is called once per frame
	void FixedUpdate () {
		breathePast = breatheNow;



		// are we simulating everything?
		if (SessionManager.GetComponent<SessionManager> ().SimulateSelf == true) {

			if (PlayerNumber == 1) {
				PlayerFA = DataHolder.GetComponent<SimulationData> ().P1FrontAs;
				breatheNow = DataHolder.GetComponent<SimulationData> ().P1Breathing;
			}

			if (PlayerNumber == 2) {
				PlayerFA = DataHolder.GetComponent<SimulationData> ().P2FrontAs;
				breatheNow = DataHolder.GetComponent<SimulationData> ().P2Breathing;

			}

		} else {  //this is the adaptation coming from sensors.
			if (PlayerNumber == 1) {
				PlayerFA = SensorData.FAOut;
				breatheNow = SensorData.RespOut;
			}

			if (PlayerNumber == 2) {
				PlayerFA = SensorData.FAOut;
				breatheNow = SensorData.RespOut;

			}

		}


	
		AuraController.GetComponent<PlayerFAScript> ().PlayerFA_Display = PlayerFA;









		// RESPIRATION CONTROLS







		// first breathe out
		if ((breatheNow < breathePast) && (outBreathContinues == false)) {

	//		Debug.Log ("Player " + PlayerNumber + " breathing out");
	//		Debug.Log (PlayerNumber + ": " + breathePast + " " + breatheNow);
		
			outBreathContinues = true;

			inBreathContinues = false;


		}

		//breathing out continues
		if (outBreathContinues == true){
			AuraExpander.GetComponent<AuraScaler> ().expand = false;

		}



		if ((breatheNow >= breathePast) && (inBreathContinues == false)) {
			//outbreathing is over, send a wave.
			GetComponent<Adap_WaveSend>().SendWave (PlayerNumber);

		//	Debug.Log ("Player " + PlayerNumber + " breathing in");
		//	Debug.Log (PlayerNumber + ": " + breathePast + " " + breatheNow);
			
		
			outBreathContinues = false;
		
			inBreathContinues = true;
		}



		//breathing in continues
		if (inBreathContinues == true){
			AuraExpander.GetComponent<AuraScaler> ().expand = true;


		}


	


		
	}
}
