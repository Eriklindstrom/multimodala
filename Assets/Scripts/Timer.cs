﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

	public Text timerText;
	public Text countText;

	private int score;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		timerText.text =  "Time: " + minutes + ":" + seconds;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ring"))
		{
			score += 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + score.ToString ();
	}

}
