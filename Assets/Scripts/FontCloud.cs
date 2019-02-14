using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FontCloud : MonoBehaviour {
	string letter;
	TextMeshPro thisText;
	string[] alphabet = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
	//string letters = new List<string>();

	// Use this for initialization
	void Start () {
		letter = alphabet[UnityEngine.Random.Range(0, alphabet.Length - 1)];
		thisText = gameObject.GetComponent<TextMeshPro>();
		thisText.text = letter;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
