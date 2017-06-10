using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)){
			Destroy (this.gameObject);
		}
	}
}
