using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

	float x, y, z;

	// Use this for initialization
	void Start () {
		x = Random.Range (-0.5f, 0.5f);
		y = Random.Range (-0.5f, 0.5f);
		z = Random.Range (-0.5f, 0.5f);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (x, y, z));
	}
}
