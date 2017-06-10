using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	public int score = 0;
	public Text showScore;
	public GameObject Terrain01;
	public GameObject Terrain02;
	private float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 6, 0);
			GetComponent<AudioSource> ().Play ();
		}

		Terrain01.transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
		Terrain02.transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);

		if (Terrain01.transform.position.z < -600) {
			Terrain01.transform.position = new Vector3 (-150, -20, 400);
		} else if (Terrain02.transform.position.z < -600) {
			Terrain02.transform.position = new Vector3 (-150, -20, 400);
		}
	}

		void OnCollisionEnter (Collision other){
		SceneManager.LoadScene ("GameOver");
		}

	void OnTriggerExit(Collider other){
		score++;
		showScore.text = score.ToString ();
	}
	}
