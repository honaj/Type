using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour {
	public int letterAmount = 16;
	public float cloudSize = 10;
	public GameObject letter;
	public List<GameObject> letters = new List<GameObject>();

	// Use this for initialization
	void Start () {
		for(int i = 0; i < cloudSize; i++) {
			GameObject newLetter = Instantiate(letter, Random.insideUnitSphere * cloudSize, transform.rotation);
			letters.Add(newLetter);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
