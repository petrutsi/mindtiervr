﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFAScript : MonoBehaviour {

	public float SimuColorOffSet = 3.0f;

	public Gradient FAColorSlide = new Gradient();
	public Color PlayerColor;

	public GameObject PlayerBridgeSides;
	public GameObject PlayerAura;
	public GameObject[] PlayerLights;
	public GameObject PlayerStatue;
	public float PlayerFA_Display = 0.0f;
	public float PlayerFA_adjusted;
	public Color AuraColor;
	float auraH;
	float auraS;
	float auraV;

	//public float PlayerFA_rawInput;


	// Use this for initialization
	void Start () {

	
		GradientColorKey[] gck = new GradientColorKey[2];
		GradientAlphaKey[] gak = new GradientAlphaKey[2];
		/*gck[0].color = Color.red;
		gck[0].time = 1.0F;
		gck[1].color = Color.yellow;
		gck[1].time = 0.0F;
		gak[0].alpha = 1.0F;
		gak[0].time = 1.0F;
		gak[1].alpha = 1.0F;
		gak[1].time = 0.0F;
		FAColorSlide.SetKeys(gck, gak);*/



	}
	
	// Update is called once per frame
	void FixedUpdate () {
		PlayerFA_Display = Mathf.Abs(Mathf.Sin((SimuColorOffSet + Time.time) * 0.1f));



		PlayerColor = FAColorSlide.Evaluate(PlayerFA_Display);

		Color.RGBToHSV(PlayerColor, out auraH, out auraS, out auraV);
		auraS = 0.72f;
		auraV = 0.35f;
		AuraColor = Color.HSVToRGB(auraH,auraS,auraV);
		PlayerAura.GetComponent<Renderer> ().material.SetColor ("_TintColor", AuraColor); 



		for (int i = 0; i < PlayerLights.Length; i++) {
			
			Light l = PlayerLights[i].GetComponent<Light> ();
			l.color = PlayerColor;
			}

		PlayerBridgeSides.GetComponent<Renderer> ().material.color = PlayerColor;

		
	}
}
