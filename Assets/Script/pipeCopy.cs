using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeCopy : MonoBehaviour {
	public GameObject pipe;
	// Use this for initialization
	void Start () {
		
	}

	void Copy(){
		Instantiate (pipe, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
