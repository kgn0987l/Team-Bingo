using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textsize : MonoBehaviour {
    public int size = 1;
    Text t;

	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        t.fontSize = Screen.height * size / 100;
	}
}
