﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour {
	float Ypipe;
	public float kecepatan;

	// Use this for initialization
	void Start () {
		Ypipe = Random.Range (-1,4);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			transform.localPosition = new Vector3 (transform.localPosition.x - kecepatan, Ypipe, 1f);
		}
	}
}
