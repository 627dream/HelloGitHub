using UnityEngine;
using System.Collections;

public class WallCreaterScript : MonoBehaviour {
	public GameObject Wall;
	public GameObject MoveWall;
	public GameObject RotateWall;
	public GameObject EffectWall;

	float SortWall = 0;

	float timer = 0;
	int interval = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= interval) {
			SortWall = Random.Range (0, 4.0f);
			if (SortWall <= 1.0f) {
				transform.position = new Vector3 (0, Random.Range (-1.0f, 3.0f), 6);
				Instantiate (Wall, transform.position, transform.rotation);
			} else if ((SortWall > 1.0f) && (SortWall <= 2.0f)) {
				transform.position = new Vector3 (0, Random.Range (-1.0f, 3.0f), 6);
				Instantiate (MoveWall, transform.position, transform.rotation);
			} else if ((SortWall > 2.0f) && (SortWall <= 3.0f)) {
				transform.position = new Vector3 (0, Random.Range (-1.0f, 3.0f), 6);
				Instantiate (RotateWall, transform.position, transform.rotation);
			} else if ((SortWall > 3.0f) && (SortWall <= 4.0f)) {
				transform.position = new Vector3 (0, Random.Range (-1.0f, 3.0f), 6);
				Instantiate (EffectWall, transform.position, transform.rotation);
			}
			timer = 0;
		}
	}
}
