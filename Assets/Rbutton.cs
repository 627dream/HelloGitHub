using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Rbutton : MonoBehaviour {
	public GameObject A;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			Destroy (A.gameObject);
			SceneManager.LoadScene ("Main");
	}
  }
}